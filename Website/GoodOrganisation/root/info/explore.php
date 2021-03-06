<!DOCTYPE html>
<html>
<head>
<title>EXPLORE</title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="stylesheet" type="text/css" href="../default/css/fixedmenu.css">
<link rel="stylesheet" type="text/css" href="../default/css/integral.css">
<link rel="stylesheet" type="text/css" href="../default/css/footer.css">
<link rel="stylesheet" type="text/css" href="explore/css/explore.css">
<link rel="stylesheet" type="text/css" href="explore/css/banner.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>
<script type="text/javascript" src="explore/js/explore.js"></script>
</head>
<body>
	
	<div id="header" class="scrolled">
		<?php 
			session_start();
			include '../default/pageparts/Header.php';
		?>
	</div>
	<!-- once you click the map a huge ass banner appears-->
	<div class="overlap banner">
		<div class="central">
			<div id="top">
				<img class="topcont" src="explore/img/MAPIMG.png" id="bannerapp" alt="Visit our location">
				<div class="topcont" id="toptext">
					<h2>LOCATION</h2>
					<p>Here you can find our location and plan your route!</p>
					<p>Please don't forget to drive safely.<br></p>
					<p>The park is also accesible by bike and hiking.</p>
					<p id="smallline">Click here <!--<span class="closebanner">(or anywhere outside the map below)</span>--> to close <b><span class="closebanner x">X</span></b></p>
				</div>
			</div>
			<iframe src="https://www.google.com/maps/d/u/0/embed?mid=1BTy2-mMBvfeHLNt6ua4yGi0Gsfc&q=Galloway+Forest+Park" width="860" height="640"></iframe>
		</div>
	</div>

	<!-- this div is with default display none and it 
	appears when it needs to fill the space from header-->
	<div id="ftsec" >
		<img src="explore/img/img1.jpg" class = "imgban one"/>
		<div class = "section_desc blue">
		
			<div class = "text">
				<h1>AREA</h1>
				<br/> <!-- Empty line intended-->
				<p>The festival grounds are located in the heart of Galloway Forest Park.</p>
				<br/> <!-- Empty line intended-->
				<p>By stepping inside the ancient green and shadows of the mighty trees, </p>
				<p>	you immerse yourself into a magical world, where mystical creatures </p>
				<p>dwell and old myths come alive.</p>
				<br/> <!-- Empty line intended-->
				<p>From the rocky mountaintops, vivid plains and to the deepest lakes, the </p>
				<p>Galloway Forest Park awaits to be explored by you. </p>
				<br/> <!-- Empty line intended-->
				<p>Join our professional guides for an adventure and step into the beauty of </p>
				</p>Scottish nature.</p>
                                <br/> <!-- Empty line intended-->
                        	</p>Click the map picture for more. And see the LOCATION page for routes.</p>

			</div>
                        <div id="map_pic">
				<!-- this shit will redirect to the location-info page, or maybe it will be a pop-up, I just have to figure out how to do it -->
				<img src="explore/img/MAPIMG.png" id="imgmap" alt="Visit our location">
			</div>
		</div>
	</div>
	

	<div id="scsec" >
		<img src="explore/img/img2.jpg" class = "imgban closedfirst tobeclosed two"/>
		<div class = "section_desc orange">
			<div class = "text ">
				<h1>AT NIGHT</h1>
				<br/> <!-- Empty line intended-->
				<p>The Galloway Forest Park is the darkest place of Scotland.</p>
				<br/> <!-- Empty line intended-->
				<p>It always brings stargazer, astronomers and wonderers admiring the </p>
				<p>beaty and solving mysteries of the universe together.</p>
				<br/> <!-- Empty line intended-->
				<p>In order not to polute the cleanest skies, late concerts will use special</p>
				<p>lightings, harming the nature as little as possible. </p>
				<br/> <!-- Empty line intended-->
				<p>See the beaty of the natural lighs the and discover that no spotlight is</p>
				</p>more powerful then stars.</p>
			</div>
		</div>
	</div>
	<div id="tdsec" class="closedsecond">
		<img src="explore/img/img3.jpg" class = "imgban tobeclosed three"/>
		<div class = "section_desc blue">
			<div class = "text">
				<h1>THE FESTIVAL</h1>
				<br/> <!-- Empty line intended-->
				<p>The Universe of Sound is for every open-minded soul.</p>
				<br/> <!-- Empty line intended-->
				<p>The festival is not only about music, but all about</p>
				<p>freedom, adventure, discovery, friendship and joy.</p>
				<br/> <!-- Empty line intended-->
				<p>Make new friends, discover and rise your musical</p>
				<p>skills, try various creative dishes from the best </p>
				<p>independent cooks, experiment and learn. </p>
				<br/> <!-- Empty line intended-->
				<p>Visit the location page and feel free to contact us for</p>
				</p>more information.</p>
			</div>
			
		</div>
	</div>
	<div id="fhsec" class="closedsecond">
		<img src="explore/img/img4.jpg" class = "imgban tobeclosed four"/>
		<!-- the last picture does not have a discription-->
	</div>
	<div id="footer">
<img id="footerlogo" src="../default/images/LOGOFOOT.png" />
<ul id="footernav">
  <li><a href="#">NEWS & SOCIAL</a></li>
  <li><a href="#">CONTACT US</a></li>
  <li><a href="#">TERMS AND PRIVACY</a></li>
</ul>
<div id="social">
	<img id="footerfacebook" src="../default/images/facebook.png" />
	<img id="footertwitter" src="../default/images/twitter.png" />
	<img id="footergplus" src="../default/images/gplus.png" />
</div>
<p id="copyright">COPYRIGHT:2016</p>
</div>
	
	
	
	


</body>
</html>
