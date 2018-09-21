using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RevInvent
{
    public partial class revInventForm : Form
    {
        public revInventForm()
        {
            InitializeComponent();
        }

        private void startInventoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\Users\temp\AppData\Local\RevolutionaryInventory")){
                    startInventory();
                } else{
                    Wizard wizard = new Wizard();
                    wizard.ShowDialog();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void startInventory()
        {
            revInventTextBox.Text = "Connecting to inventory server ...";
            Ping ping = new Ping();

            IPAddress[] ipaddresses = Dns.GetHostAddresses("IPSLTMSPEISER");

            foreach (IPAddress ip4 in ipaddresses.Where(ip => ip.AddressFamily.Equals(System.Net.Sockets.AddressFamily.InterNetwork))) {
                PingReply reply = ping.Send(ip4);

                if (reply.Status == IPStatus.Success) {
                    revInventTextBox.AppendText(" \r\nConnected to " + ip4);
                }
            }

            Thread.Sleep(2000);

            String computerNameForDb = Environment.MachineName;
            revInventTextBox.AppendText("\r\nComputer Name : " + computerNameForDb);


            int length = Dns.GetHostEntry(computerNameForDb).AddressList.Count<IPAddress>();
            String ipAdressForDb = "";

            for (int i = 0; i < length; i++)  {
                if (Dns.GetHostEntry(computerNameForDb).AddressList.ElementAt<IPAddress>(i).AddressFamily.Equals(System.Net.Sockets.AddressFamily.InterNetwork))  {
                    ipAdressForDb = Dns.GetHostEntry(computerNameForDb).AddressList[i].ToString();
                }
            }

            if (!String.IsNullOrEmpty(ipAdressForDb)) {
                revInventTextBox.AppendText("\r\nIP Adress : " + ipAdressForDb);
            }


            String userNameForDb = Environment.UserName;
            revInventTextBox.AppendText("\r\nUser Name: " + userNameForDb);

            String userDomainNameForDb = Environment.UserDomainName;
            revInventTextBox.AppendText("\r\nDomain : " + userDomainNameForDb);

            revInventTextBox.AppendText("\r\nOperating System : ");
            String os = executeCommand("/C WMIC OS get caption");
            String osForDb = removeUnimportantInformation(os, "Caption");
            revInventTextBox.AppendText(osForDb);

            revInventTextBox.AppendText("\r\nProduct Key: ");
            String productKey = executeCommand("/C wmic path softwarelicensingservice get OA3xOriginalProductKey");
            String prodKeyForDb = removeUnimportantInformation(productKey, "OA3xOriginalProductKey");
            revInventTextBox.AppendText(prodKeyForDb);

            revInventTextBox.AppendText("\r\nRAM: ");
            String ram = executeCommand("/C wmic ComputerSystem get TotalPhysicalMemory");
            String ramForDb = getSizeInGb(removeUnimportantInformation(ram, "TotalPhysicalMemory"));
            revInventTextBox.AppendText(ramForDb);

            revInventTextBox.AppendText("\r\nDrives : ");

            String drivesForDb = "";

            foreach (DriveInfo drive in DriveInfo.GetDrives()) {
                if (drive.IsReady)  {
                    drivesForDb = drivesForDb + "\r\n" + drive.Name + " size: " + getSizeInGb(drive.TotalSize.ToString());
                }
            }

            revInventTextBox.AppendText(drivesForDb);

            revInventTextBox.AppendText("\r\nGraphics Card : ");
            String graphicCard = executeCommand("/C wmic path win32_VideoController get name");
            String graphicCardForDb = removeUnimportantInformation(graphicCard, "Name");
            revInventTextBox.AppendText(graphicCardForDb);

            revInventTextBox.AppendText("\r\nManufacturer : ");
            String manufacturer = executeCommand("/C wmic computersystem get manufacturer");
            String manufacturerForDb = removeUnimportantInformation(manufacturer, "Manufacturer");
            revInventTextBox.AppendText(manufacturerForDb);

            MySqlConnection conn = new MySqlConnection("server=IPSLTMSPEISER;database=revolutionary;port=3306;uid=user;pwd=password;SslMode=none;");
            conn.Open();

            String mysqlCommand = "INSERT INTO revolutionary.computers(	computer_name,ip_adress, username, domain, os, product_key, ram," +
                "drives, graphics_card, manufacturer) Values('" + computerNameForDb + "','" + ipAdressForDb + "','" + userNameForDb + "','" + userDomainNameForDb + "','" + osForDb + "','" + prodKeyForDb + "','" + ramForDb + "','"
                + drivesForDb + "','" + graphicCardForDb + "','" + manufacturerForDb + "');";

            MySqlCommand cmd = new MySqlCommand(mysqlCommand, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        /**
         * Executes a command from cmd
		 * and returns the result as a string
        **/
        String executeCommand(String command) {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.Arguments = command;
            cmd.Start();

            string output = cmd.StandardOutput.ReadToEnd();
            return output;
        }

        String removeUnimportantInformation(String all, String unimportant) {
            all = all.Replace(unimportant, String.Empty);
            all = all.Replace("\r\n", String.Empty);
            all = all.Replace("  ", String.Empty);
            return all;
        }

        /**
         * returns the size of ram in GigaByte
        **/
        String getSizeInGb(String sizeInKb) {
            double totalSize = Double.Parse(sizeInKb);
            double sizeInGb = (double)totalSize / Math.Pow(1024.0, 3.0);

            string finalRes = Math.Round(sizeInGb, 0).ToString();
            return finalRes + " GB";
        }

    }
}
