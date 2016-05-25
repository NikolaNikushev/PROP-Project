
$(document).ready(function() {
    $(document).on('submit', '#second-form', function() {
        //dataMain = $(this).serialize();
        //var email = $("#user_email").val();
        //var password = $("#user_password").val();
        //var partialdatastring = 'email='+ email 
          //      + '&password='+ password;
          
        
            $.ajax({
            type: 'POST',
            url: 'php/ProcessBooking.php',
            data: dataMain,
            success: function(response) {
                if (response.includes('shit')) {
                    
                    alert('Sorry, it is not possible yet, we are working on it though');
                    //$("#Reg").show();
                   
                } else {
                  alert(response);;
                  //$("#noReg").show();
                }
            }
            });
            
       
        
        
        
//        $.ajax({
//            type: 'POST',
//            url: './php/ProcessBooking.php',
//            data: data,
//            success: function(response) {
//                if (response.includes('logged')) {
//                  //use of sweetalert-master libraly to display messages
//                    swal({
//                        html: true,
//                        title: "<span style= \"color:#fce600\" >Succesfully signed in!</span>",
//                        text: "<span style= \"color:#ff9933\" >Now you are going to be redirected to your personal page!</span>",
//                        type: "success",
//                        confirmButtonColor: "#333399",
//                        confirmButtonText: "Okay"
//                    }, function(isConfirm) {
//                        if (isConfirm) {
//                            window.location = "../PERSONAL-PAGE";
//                        }
//                    });
//                } else {
//                    swal({
//                        html: true,
//                        title: "<span style= \"color:#fce600\" >Unsuccessfull logging</span>",
//                        text: "<span style= \"color:#ff9933\" >Please insert correct data!</span>",
//                        type: "error",
//                        confirmButtonColor: "#333399",
//                        confirmButtonText: "Try again"
//                    });
//                }
//            }
//        });
        return false;
    });
});
