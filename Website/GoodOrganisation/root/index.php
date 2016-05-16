<!DOCTYPE html>
<html>
<head>

<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="stylesheet" type="text/css" href="HOME/header.css">
<link rel="stylesheet" type="text/css" href="HOME/homepage.css">
<link rel="stylesheet" type="text/css" href="DEFAULT/CSS/footer.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>
<!--<script type="text/javascript" src="HOMEtest.js"></script>-->

</head>
<body>
	<div id="header">
		<img id="logo" src="DEFAULT/IMAGES/logohead.png"/>
			<ul id="nav">
				<li class="dropdown">
					<a class="dropbtn" href="index.php">INFO</a>
					<div class="dropdown-content">
						<a href="info/general.php">GENERAL</a>
						<a href="info/explore.php">EXPLORE</a>
						<a href="info/location.php">LOCATION</a>
						<a href="info/rules.php">RULES</a>
					</div>
				</li>
                                <li class="dropdown">
					<a class="dropbtn" href="program/index.php">PROGRAM</a>
					<div class="dropdown-content">
						<a href="activities/index.php">ACTIVITIES</a>
					</div>
				</li>
				<li><a href="tickets/index.php">TICKETS</a></li>
				<li><a href="camping/index.php">CAMPING</a></li>
				<li><a href="register/index.php">ACCOUNT</a></li>
			</ul>
	</div>
	<!-- this div is with default display none and it 
	appears when it needs to fill the space from header-->
	<div id="potato">
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	<p>text</p>
	</div>
	<div id="wrapper">
		<div id="txtcont">
		<h2 class="caption" id="fline">29-31 JULY 2016. GALLOWAY FOREST PARK.</h2>
		<h1 class="caption" id="sline">TICKETS SOON ON SALE!</h1>
		<p id="fart">Red Hot Chilli Peppers, DJ Carl Cox, Eminem,</p>
		<p id="sart">Dave Growl, The Drums, Dimitar Markov,</p>
		<p class="smallart" id="tart">MGMT, Jay Z, Madonna, Childish Gambino, Casiokids,</p>
		<p class="smallart" id="foart">Gay Fish, Gramatik, 痛苦的信仰, Snatam Kaur, Trevor Hall</p>
		<p class="smallart" id="tart">Yoga, Atanas Naydenov, Damon Albarn, Don Passman,</p>
		<p class="smallart" id="foart">Future Islands, Mirabai Ceiba, Noodles, Hussain AlJassmi</p>
		<p id="fiart">and much more!</p>
		<p id="emptyfart">	&nbsp</p>
		</div>
		<div id="imgs">
			<div>
			<img src="HOME/PICTOGRAMS.png" alt="Pictograms" id="pictograms">
			</div>
		</div>
		
		
	</div>
	<div id="footer">
<img id="footerlogo" src="DEFAULT/IMAGES/LOGOFOOT.png" />
<ul id="footernav">
  <li><a href="#">NEWS & SOCIAL</a></li>
  <li><a href="#">CONTACT US</a></li>
  <li><a href="#">TERMS AND PRIVACY</a></li>
</ul>
<div id="social">
	<img id="footerfacebook" src="DEFAULT/IMAGES/facebook.png" />
	<img id="footertwitter" src="DEFAULT/IMAGES/twitter.png" />
	<img id="footergplus" src="DEFAULT/IMAGES/gplus.png" />
</div>
<p id="copyright">COPYRIGHT:2016</p>
</div>
	
	
	
	

<script>
window.onload = function() {
$("#header").addClass("headernotscrolled");
document.getElementById("potato").style.display="none";
        $("#header").removeClass("scrolled");
		$("#nav").addClass("nav");
		$("#logo").addClass("logo");
		$("#header").addClass("headernotscrolled");
		logo.src = "HOME/logotext.png";
		document.getElementById("potato").style.display="none";
}
var logo = document.getElementById('logo');

$(window).on("scroll", function () {
    if ($(this).scrollTop() > 580) {
		$("#header").removeClass("headernotscrolled");
        $("#header").addClass("scrolled");
		$("#nav").removeClass("nav");
		$("#logo").removeClass("logo");
		logo.src = "DEFAULT/IMAGES/logohead.png";
		document.getElementById("potato").style.display="inline";
    }
    else {
        $("#header").removeClass("scrolled");
		$("#nav").addClass("nav");
		$("#logo").addClass("logo");
		$("#header").addClass("headernotscrolled");
		logo.src = "HOME/logotext.png";
		document.getElementById("potato").style.display="none";
    }
});
</script>

</body>
</html>
