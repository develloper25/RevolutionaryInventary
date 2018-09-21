<?php

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "revolutionary";

// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);

$queryColumnNames = "SHOW COLUMNS FROM revolutionary.computers";
$resultColumnNames = $conn->query($queryColumnNames);

$queryContent = "SELECT * FROM revolutionary.computers";

if(isset($_GET["id"]))
{
	$queryContent = "SELECT * FROM revolutionary.computers WHERE ID='" . $_GET["id"] . "'" ;
	
	$resultContent = $conn->query($queryContent);
	echo "<table class='computerDetails'>";
	
	$num_rows = mysqli_num_rows($resultContent);

	echo "<tr>";
	while($row = mysqli_fetch_assoc($resultColumnNames)) {
        echo "<th>" . $row['Field'] . "</th>";
	}
	echo "</tr>";

	while($row = mysqli_fetch_assoc($resultContent)) {   
		echo "<tr>";
		foreach ($row as $col => $val) {
			if($col == "id")
			{
				echo "<td><a href='index.php?nav=computers.php" ."&id=" . $val . "'>" . $val . "</a></td>";
			}else{
				 echo "<td>" . nl2br($val) . "</td>";
			}
        }
		echo "</tr>";
    }

	
}else{
	$resultContent = $conn->query($queryContent);
	echo "<table class='computersTable'>";

	$num_rows = mysqli_num_rows($resultContent);

	echo "<tr>";
	while($row = mysqli_fetch_assoc($resultColumnNames)) {
        echo "<th>" . $row['Field'] . "</th>";
	}
	echo "</tr>";

	while($row = mysqli_fetch_assoc($resultContent)) {   
		echo "<tr>";
		foreach ($row as $col => $val) {
			if($col == "id")
			{
				echo "<td><a href='index.php?nav=computers.php" ."&id=" . $val . "'>" . $val ." Details >" . "</a></td>";
			}else{
				 echo "<td>" . $val . "</td>";
			}
        }
		echo "</tr>";
    }
	
}

echo "</tr></table>" ;


$resultContent->free();

$conn->close();


?>