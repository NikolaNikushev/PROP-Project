<!DOCTYPE html>
<html>
<head>
<title>PROGRAM</title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />

<!-- TRYING TO CONNECT GOOGLE PROVIDED JQUERY -->
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
<script type="text/javascript" src="../default/js/jquery-1.12.2.min.js"></script>



<link rel="stylesheet" type="text/css" href="css/PROG.css">
<link rel="stylesheet" type="text/css" href="../default/css/INTEGRAL.css">
<link rel="stylesheet" type="text/css" href="../default/css/FOOTER.css">
<script type="text/javascript" src="JS\program.js"></script>
<link rel="stylesheet" type="text/css" href="../default/css/fixedmenu.css">

</head>
<body>
	<div id="header" class="scrolled">
		<?php include '../default/pageparts/Header.php';?>
	</div>

	<div class="TOPBAR" id="daybar">
		<div id= "days">
			<ul id="daybuttns">
				<li class="BTN" id="leftBtnDay" onclick="DayClick('leftBtnDay')">DAY 1</li>
				<li class="BTN" id="centerBtnDay" onclick="DayClick('centerBtnDay')">DAY 2</li>
				<li class="BTN" id="rightBtnDay" onclick="DayClick('rightBtnDay')">DAY 3</li>
			</ul>
		</div>
	</div>
	<!-- ORANGE -->
	<div id="wrapper">
		<!-- Categories/Tabs -->
		<div id="left_btns">
		
			<div class = "section" id="firstsec" onclick="OpenSec('firstsec','fstxt')">
				<div class="sectext" id="fstxt">
					<p>Experience the ultimate variety of music.</p> 
					<p>Dance to your favorite artists and discover new talented bands!</p>
					<p>Make friends with people as passionant about the music as you are and</p>
					<p>get lost in the Universe of Sound!</p>
				</div>
				<img class = "sectionimg" src="images/music.png"/>
			</div>
		
			<div class = "section" id="secsec" onclick="OpenSec('secsec','sstxt')">
				<div class="sectext" id="sstxt">
					<p>Be involved in various music-themed activities!</p> 
					<p>Take music lessons, organise your bands, and have your own performances.</p>
					<p>Attend various workshops and fun activities with your friends.</p>
					<p>*Some activities can be booked by registered visitors.</p>
				</div>
				<img class = "sectionimg" src="images/act.png"/>
			</div>
			
			<div class = "section" id="thirsec" onclick="OpenSec('thirsec','tstxt')">
				<div class="sectext" id="tstxt">
					<p>Fast-Food reinvented!</p> 
					<p>Discover new urban food tendencies.</p>
					<p>Try the most popular dishes from all over the world.</p>
					<p>#healthy #for_every_taste #delicious #vegan #organic</p>
				</div>
				<img class = "sectionimg" src="images/food.png"/>
			</div>
		</div>
		
		<!-- Schedule -->
		<div class="schedule" id="fday">
				<!-- Content will be filled by jquery -->
				<!-- Content will be filled by jquery -->
		</div>
		
		<!-- footer -->
		<div id="imges">
			<div>
				<img src="images/STAGES.png" alt="STAGES" id="stages">
			</div>
		</div>
	</div>
	<?php include '../default/pageparts/footer.php';?>
	
</body>
</html>
