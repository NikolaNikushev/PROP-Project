$(document).ready(function() {
    $(".logged").click(function(){
        $(".central").load("PAGEPARTS/bannerCheckout.php", {price: 55});
        $(".banner").show(); 
        
            //$("#pr").val(55);   
        
    });
    $(".notlogged").click(function(){
        $(".central").load("PAGEPARTS/bannerLogin.php");
        $(".banner").show(); 
        
            $("#pr").val(55);   
        
    });
    
});

function HideBanner()
{
            $(".banner").hide();
}