$(document).ready(function () {
    // performs this function on click
    $('#tandc').click(function(){
        var pre = document.createElement('pre');
//custom style.
        pre.style.maxHeight = "600px";
        pre.style.overflowX = "scroll";
        pre.style.overflowWrap = "break-word";
        pre.style.margin = "-16px -16px -16px 0";
        pre.style.font = "normal normal 12pt odinlight"; 
        pre.style.paddingBottom = "24px";
        pre.appendChild(document.createTextNode($('#tctext').text()));
//show as confirm
        alertify.confirm('Terms and Conditions',pre, function () {
        }, function () {
        }).setting('labels', {'ok': 'Accept', 'cancel': 'Decline'});
    
    });
    
        
});



