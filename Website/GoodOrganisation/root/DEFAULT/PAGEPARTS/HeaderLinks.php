<?php

function is_session_started()
{
    if ( php_sapi_name() !== 'cli' ) {
        if ( version_compare(phpversion(), '5.4.0', '>=') ) {
            return session_status() === PHP_SESSION_ACTIVE ? TRUE : FALSE;
        } else {
            return session_id() === '' ? FALSE : TRUE;
        }
    }
    return FALSE;
}

// Example
if ( is_session_started() === FALSE ) session_start();


if(isset($_SESSION['USER_ID']))
{
	echo '<ul id="nav">
		<li class="dropdown">
			<a class="dropbtn" href="../index.php">INFO</a>
			<div class="dropdown-content">
				<a href="../info/general.php">GENERAL</a>
				<a href="../info/explore.php">EXPLORE</a>
				<a href="../info/location.php">LOCATION</a>
				<a href="../info/rules.php">RULES</a>
			</div>
		</li>
		<!-- <li><a href="../program/index.php">PROGRAM</a></li> -->
		<li class="dropdown">
			<a class="dropbtn" href="../program/index.php">PROGRAM</a>
			<div class="dropdown-content">
				<a href="../activities/index.php">ACTIVITIES</a>
			</div>
		</li>
		<li><a href="../tickets/index.php">TICKETS</a></li>
		<li><a href="../camping/index.php">CAMPING</a>
		<li class="dropdown">
				<a class="dropbtn" href="../register/index.php">ACCOUNT</a>
				<div class="dropdown-content">
					<a class="dropbtn" href="../register/index.php">LOGOUT</a>
				<div>
		</li>
	</ul>';
}
else {
	echo '<ul id="nav">
	 <li class="dropdown">
		 <a class="dropbtn" href="../index.php">INFO</a>
		 <div class="dropdown-content">
			 <a href="../info/general.php">GENERAL</a>
			 <a href="../info/explore.php">EXPLORE</a>
			 <a href="../info/location.php">LOCATION</a>
			 <a href="../info/rules.php">RULES</a>
		 </div>
	 </li>
	 <!-- <li><a href="../program/index.php">PROGRAM</a></li> -->
		<li class="dropdown">
		 <a class="dropbtn" href="../program/index.php">PROGRAM</a>
		 <div class="dropdown-content">
			 <a href="../activities/index.php">ACTIVITIES</a>
		 </div>
	 </li>
	 <li><a href="../tickets/index.php">TICKETS</a></li>
	 <li><a href="../camping/index.php">CAMPING</a></li>
	 <li id="logout-li"><a id="logout-a" href="../register/index.php">ACCOUNT</a></li>
 </ul>';


}
?>
