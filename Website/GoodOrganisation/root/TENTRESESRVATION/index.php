<!DOCTYPE html>
<html>
<head>
	<title>RESERVE A TENT</title>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">
	<link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/integral.css">
	<link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/footer.css">
	<link rel="stylesheet" type="text/css" href="CSS/tentres.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
	<script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>
	<script type="text/javascript" src="JS/tentres.js"></script>
</head>
<body>
	<div id="header" class="scrolled">
		<?php include '../DEFAULT/PAGEPARTS/Header.php';?>
	</div>
	<!-- the light blue rectangle in he middle USE AJAX FORM MANIPULATION! -->
	<form action="PHP/ProcessBooking.php" method="post">
        <div id="tentform" class="content">
		<div id="grtit">
			<h1>GROUP DETAILS</h1>
		</div>
		<div id="controls" class="boxie">
			<p class="shortline ">Number of tenants: </p>
				<div class="defcont">
					<label class="deflabel minus">-</label>
					<input class="form-control form_numcon" 
						required="required" type="number" min="1" 
						value="4" max="6" readonly
						name="tennum" id="tennum">
					<label class="deflabel plus">+</label>
				</div>
				
		  <!-- do not forget to add an action-->	
			<p class="shortline dateline">Arrival date: </p>
				<div class="defcont datecont">
					<input class="rdbtn" required="required" type="radio" name="datechoice" id="dateeight">
					<label class="deflabel" for="dateeight">28 July</label>
					<input class="rdbtn" required="required" type="radio" name="datechoice" id="datenine">
					<label class="deflabel" for="datenine">29 July</label>
				</div>
		</div>
		
			<div id="leader" class="boxie">
				<h2>TENANT 1</h2>
				<p>Leader email: 
					<input autofocus="autofocus" class="form-control" required="required" type="email" name="email" id="user_email">
				</p>
				<p>Leader password:
					<input class="form-control" required="required" type="password" name="password" id="user_password">
				</p>
			</div>
			<div class="boxie tenant" id="gu1">
				<h2>TENANT 2</h2>
				<p>Email: 
					<input class="form-control" required="required" type="email" name="guest_em1" id="guest_em1">
				</p>
			</div>
			<div class="boxie tenant" id="gu2">
				<h2>TENANT 3</h2>
				<p>Email: 
					<input class="form-control" required="required" type="email" name="guest_em2" id="guest_em2">
				</p>
			</div>
			<div class="boxie tenant" id="gu3">
				<h2>TENANT 4</h2>
				<p>Email: 
					<input class="form-control" required="required" type="email" name="guest_em3" id="guest_em3">
				</p>
			</div>
			<div class="boxie tenant" id="gu4">
				<h2>TENANT 5</h2>
				<p>Email: 
					<input class="form-control" required="required" type="email" name="guest_em4" id="guest_em4">
				</p>
			</div>
			<div class="boxie tenant" id="gu5">
				<h2>TENANT 6</h2>
				<p>Email: 
					<input class="form-control" required="required" type="email" name="guest_em5" id="guest_em5">
				</p>
			</div>
			<div id="price_ver" class="boxie verify">
				<h2>RESERVATION PRICE:<input class="form-control" 
						required="required" type="number" readonly
						name="finprice" id="finprice"></h2>
				<div id="ckbx">
					
					<input type="checkbox" name="verify" value="yes" id="check" required="required">
					<label>
						I verify the information
					</label>
					<div>
						<input type="submit" value="CONTINUE" class="btn">
					</div>
				</div>
			</div>
		
	</div>
	</form>
	<!-- FOOTER -->
	<div id="imges">
			<div>
				<img src="IMG/CAMPS.png" alt="CAMPS" id="camps">
			</div>
		</div>
	</div>
		<div id="footer">
			<img id="footerlogo" src="../DEFAULT/Images/LOGOFOOT.png" />
		<ul id="footernav">
			<li><a href="#">NEWS & SOCIAL</a></li>
			<li><a href="#">CONTACT US</a></li>
			<li><a href="#">TERMS AND PRIVACY</a></li>
		</ul>
		<div id="social">
			<img id="footerfacebook" src="../DEFAULT/Images/facebook.png" />
			<img id="footertwitter" src="../DEFAULT/Images/twitter.png" />
			<img id="footergplus" src="../DEFAULT/Images/gplus.png" />
		</div>
		<p id="copyright">COPYRIGHT:2016</p>
	</div>
</body>
</html>