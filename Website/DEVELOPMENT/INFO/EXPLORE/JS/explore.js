$(document).ready(function() {
	// first page load
	// to load up the header
	$( "#header").load( "../default/headerstatic.html" );
	// to manage opening and closing the banner
	// $(".closedfirst").hide();
	// $(".closedsecond").hide();
	
	// $( ".central" ).parent().click(function() {
			// $(".banner").hide();
	// });
	$( ".x" ).click(function() {
		$(".banner").hide();
	});
	$( "#imgmap" ).click(function() {
		$(".banner").show();
	});
	
	
	
	// $( "#imgmap" ).mouseenter(function(
	// {
		
		// $("#imgmap").animate({
			// width: '+=5px'
		// });
	// });
	// $( "#imgmap" ).mouseleave(function(
	// {
		// $("#imgmap").animate({
			// width: '-=5px'
		// });
	// });
});


// $(window).on("scroll", function () {
	// if ($(this).scrollTop() > 700) {
		// $(".closedfirst").show("slow");
	// }
	// if ($(this).scrollTop() > 1400) {
		// $(".closedsecond").show("slow");
	// }
// });