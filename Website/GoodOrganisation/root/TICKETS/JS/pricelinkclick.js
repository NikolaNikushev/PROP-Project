$(document).ready(function() {
    $(".logged").click(function(){
        $(".central").load("pageparts/bannerCheckout.php", {price: 55});
        $(".banner").show(); 
        
            //$("#pr").val(55);   
        
    });
    $(".notlogged").click(function(){
        $(".central").load("pageparts/bannerLogin.php");
        $(".banner").show(); 
        
            $("#pr").val(55);   
        
    });
    
});

function HideBanner()
{
            $(".banner").hide();
}