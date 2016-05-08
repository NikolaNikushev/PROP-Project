var i;
var tenants = ["#leader","#gu1","#gu2","#gu3","#gu4","#gu5"];
	i = tenants.length;
	



$(document).ready(function() {
	// first page load
	// to load up the header
	//$( "#header").load( "../../default/headerstatic.html" );
	
	var globval= $("#tennum").val();
	for(j = globval; j < i; j++){
		$(tenants[j]).hide();
	}
	
	
	// kind of event handlers
	$(".plus").click(function(){
		var value= $("#tennum").val(); 
        if(value != 6)
		{
			value++;
			$("#tennum").val(value)
			$(tenants[value-1]).show();
		}
		
    });
    $(".minus").click(function(){
        var value= $("#tennum").val(); 
        if(value != 1)
		{
			value--;
			$("#tennum").val(value)
			$(tenants[value]).hide();
		}
    });
});


