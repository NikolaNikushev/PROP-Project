var dataMain;
var numberTennts = $("#tennum").val();
var totalPrice = $("#finprice").val();
var pricePerDay = Math.floor(totalPrice/numberTennts);
var resp;
$(document).ready(function() {
    $(document).on('submit', '#first-form', function() {
        dataMain = $(this).serialize();
        //alert(dataMain);
        //var email = $("#user_email").val();
        //var password = $("#user_password").val();
        //var partialdatastring = 'email='+ email 
          //      + '&password='+ password;
        $.ajax({
            type: 'POST',
            url: 'php/loginLeader.php',
            data: dataMain,
            success: function(response) {
                if (response.includes('logged')) {

                    $(".banner").show();
                    $(".central").load("pageparts/BannerReg.php");
                    //$("#Reg").show();
                    alert(response);

                } else {
                   $(".banner").show();
                   $(".central").load("pageparts/BannerNoReg.php");
                  //$("#noReg").show();
                  alert(response);
                  resp = response;
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
