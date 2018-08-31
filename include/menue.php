<div id="menue">
	<ul>
		<li><a><img src="logo/logo3.png"></a></li>
		<li><a href="index.php?nav=dashboard" <?php if($nav == "dashboard"){echo 'class ="active"';} ?>>Dashboard</a></li>
		<li><a href="index.php?nav=devices" <?php if($nav == "devices"){echo 'class ="active"';} ?>>Devices</a></li>
		<li><a href="index.php?nav=tickets" <?php if($nav == "tickets"){echo 'class ="active"';} ?>>Tickets</a></li>
		<li><a href="index.php?nav=users" 	<?php if($nav == "users"){echo 'class ="active"';} ?>>Users</a></li>
	</ul>
</div>