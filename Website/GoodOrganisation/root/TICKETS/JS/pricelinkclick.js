$(document).ready(function() {
    $("#best").click(function(){
        $(".central").load("pageparts/bannerCheckout.php");
        $(".banner").show(); 
        
            $("#pr").val(55);   
        
    });
    
});

function HideBanner()
{
            $(".banner").hide();
}