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
		<?php if($nav != "login"){
			include 'include/menue.php'; 
		}
		?>
	</header>
	<div id="content">
			<?php  include 'include/' . $nav ; ?>
	</div>
	
	<?php include 'include/footer.php' ?>
	
	</body>
</html>