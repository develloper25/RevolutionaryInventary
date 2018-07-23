<?php

$nav = "";

if(isset($_GET["nav"]))
{
	$nav = $_GET["nav"];
}else{
	$nav = "login";
}

?>


<!doctype html>
<html>
	<head>
		<meta charset = "utf-8">
		<title>Revolutionary Inventory</title>
		<link rel="stylesheet" type="text/css" href = "css/layoutLogin.css">
	</head>
	<body>
	
	<header>
		<?php if($nav != "login")
		{
			include 'include/menue.php'; 
		}
		?>
	</header>
	
		<?php include 'include/' . $nav .'.php'; ?>
	
	</body>
</html>