
$(document).ready(function() {
    $(document).on('submit', '#second-form', function() {
        //dataMain = $(this).serialize();
        //var email = $("#user_email").val();
        //var password = $("#user_password").val();
        //var partialdatastring = 'email='+ email 
          //      + '&password='+ password;
            dataToSend = dataMain;
        
            $.ajax({
            type: 'POST',
            url: 'php/ProcessBooking.php',
            data: dataToSend,
            success: function(response) {
                if (response.includes('shit')) {
                    
                    alert('Sorry, it is not possible yet, we are working on it though');
                    //$("#Reg").show();
                   
                } else {
                  alert(response);
                  //$("#noReg").show();
                }
            }
            });
            
       
        
        
        

        return false;
    });
});
