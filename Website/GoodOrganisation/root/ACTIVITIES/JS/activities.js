// jQuery hovering functionality
$(document).ready(function() {
	
    
        $(".activity").mouseenter(function() {
		
		$(this).animate({
			paddingTop: '+=8px'
		});
                $(this).find('.chkbox').show(100);
                $(this).find('div.description').show(450);
		$(this).find('.chkbox').prop('checked', false);
	});
	$(".activity").mouseleave(function() {
		
		$(this).animate({
			paddingTop: '-=8px'
		}); 
               
                $(this).find('div.description').hide(450);
                $(this).find('.chkbox').hide();
                $(this).find('.chkbox').prop('checked', true);
		
	});
        
        $("#managingbtn").click(function(){
            closeOrOpen();
        });
       
});


$tabOpened = false;

function closeOrOpen() 
{
     if($tabOpened)
        {
                $(".tocloseoropen").hide();
                $tabOpened = false;
  
        }else
        {             
                $tabOpened=true;
                $(".tocloseoropen").show();

        }
}