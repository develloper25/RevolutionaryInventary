using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

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
            revInventTextBox.Text = "Connecting to inventory server ...";
            Ping ping = new Ping();

            IPAddress[] ipaddresses = Dns.GetHostAddresses("IPSLTMSPEISER");

            foreach (IPAddress ip4 in ipaddresses.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
            {
                PingReply reply = ping.Send(ip4);

                if (reply.Status == IPStatus.Success)
                {
                    revInventTextBox.AppendText(" \r\nConnected to " + ip4);
                }

            }

            Thread.Sleep(2000);

            revInventTextBox.AppendText("\r\nComputer Name : " + Environment.MachineName);
            revInventTextBox.AppendText("\r\nIP Adress : " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0]);

            revInventTextBox.AppendText("\r\nOperating System : ");
            String os = executeCommand("/C WMIC OS get caption");
            revInventTextBox.AppendText(removeUnimportantInformation(os, "Caption"));

            revInventTextBox.AppendText("\r\nProduct Key: ");
            String productKey = executeCommand("/C wmic path softwarelicensingservice get OA3xOriginalProductKey");
            revInventTextBox.AppendText(removeUnimportantInformation(productKey, "OA3xOriginalProductKey"));

            revInventTextBox.AppendText("\r\nRAM: ");
            String ram = executeCommand("/C wmic ComputerSystem get TotalPhysicalMemory");
            revInventTextBox.AppendText(getSizeInGb(removeUnimportantInformation(ram, "TotalPhysicalMemory")));

            revInventTextBox.AppendText("\r\nUser Name: " + Environment.UserName);
            revInventTextBox.AppendText("\r\nDomain : " + Environment.UserDomainName);

            revInventTextBox.AppendText("\r\nDrives : ");

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    revInventTextBox.AppendText("\r\n" + drive.Name + " size: " + getSizeInGb(drive.TotalSize.ToString()));
                }

            }

            revInventTextBox.AppendText("\r\nGraphics Card : ");
            String graphicCard = executeCommand("/C wmic path win32_VideoController get name");
            revInventTextBox.AppendText(removeUnimportantInformation(graphicCard,"Name"));

            revInventTextBox.AppendText("\r\nManufacturer : ");
            String manufacturer = executeCommand("/C wmic computersystem get manufacturer");
            revInventTextBox.AppendText(removeUnimportantInformation(manufacturer, "Manufacturer"));


        }
        /**
         * Executes a command from cmd
		 * and returns the result as a string
        **/
        String executeCommand(String command){
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
