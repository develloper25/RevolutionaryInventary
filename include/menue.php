<div id="menue">
	<ul>
		<li><a href="index.php?nav=dashboard.php" <?php if($nav == "dashboard"){echo 'class ="active"';} ?>>Dashboard</a></li>
		<li><a  <?php if($nav == "computers" || $nav == "printers"){echo 'class ="active"';}?>>Devices</a>
			<ul>
				<li><a href="index.php?nav=computers.php" >Computers</a></li>
				<li><a href="index.php?nav=printers.php"  >Printers</a></li>
			</ul>
		</li>
		<li><a href="index.php?nav=tickets.php" <?php if($nav == "tickets"){echo 'class ="active"';} ?>>Tickets</a></li>
		<li><a href="index.php?nav=users.php" 	<?php if($nav == "users"){echo 'class ="active"';} ?>>Users</a></li>
	</ul>
</div>