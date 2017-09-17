<?php
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);
?>
<!DOCTYPE html>
<html>

<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<link rel="stylesheet" type="text/css" href="home/header.css">
	<link rel="stylesheet" type="text/css" href="home/homepage.css">
	<link rel="stylesheet" type="text/css" href="default/css/footer.css">
	<link rel="stylesheet" type="text/css" href="../DEFAULT/sweetalert-master/sweetalert-master/dist/sweetalert.css">

	<!--<script type="text/javascript" src="HOMEtest.js"></script>-->

</head>

<body>

	<div id="header" class="headernotscrolled">
		<img id="logo" class="logo" src="home/logotext.png"/>
			<?php require_once 'default/pageparts/HeaderLinksHome.php'; ?>
	</div>
	<!-- this div is with default display none and it
	appears when it needs to fill the space from header-->
	<div id="potato" style="display:none;">
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
			<p id="emptyfart"> &nbsp</p>
		</div>
		<div id="imgs">
			<div>
				<img src="home/PICTOGRAMS.png" alt="Pictograms" id="pictograms">
			</div>
		</div>
	</div>

	<div id="footer">
<img id="footerlogo" src="default/images/LOGOFOOT.png" />
<?php require_once 'default/pageparts/FooterLinksHome.php'; ?>
<div id="social">
	<img id="footerfacebook" src="default/images/facebook.png" />
	<img id="footertwitter" src="default/images/twitter.png" />
	<img id="footergplus" src="default/images/gplus.png" />
</div>
<p id="copyright">COPYRIGHT:2016</p>
</div>


	<script src="https://code.jquery.com/jquery-2.2.4.min.js" integrity="sha256-BbhdlvQf/xTY9gja0Dq3HiwQF8LaCRTXxZKRutelT44=" crossorigin="anonymous"></script>
	<script>
		var logo = document.getElementById('logo');
		var potato = document.getElementById("potato");
		$(document).on("scroll", function() {
			if ($(this).scrollTop() > 580) {
				$("#header").removeClass("headernotscrolled");
				$("#header").addClass("scrolled");
				$("#nav").removeClass("nav");
				$("#logo").removeClass("logo");
				logo.src = "DEFAULT/IMAGES/logohead.png";
				potato.style.display = "inline";
			} else {
				$("#header").removeClass("scrolled");
				$("#nav").addClass("nav");
				$("#logo").addClass("logo");
				$("#header").addClass("headernotscrolled");
				logo.src = "HOME/logotext.png";
				potato.style.display = "none";
			}
		});
	</script>

</body>

</html>
