
$(document).ready(function () {
    $(document).on('submit', '#second-form', function () {
        dataNew = $(this).serialize();
        //var email = $("#user_email").val();
        //var password = $("#user_password").val();
        //var partialdatastring = 'email='+ email 
        //      + '&password='+ password;
        dataToSend = dataMain + "&" + dataNew;

        $.ajax({
            type: 'POST',
            url: 'php/ProcessBooking.php',
            data: dataToSend,
            success: function (response) {
                if (response.includes('sucessful')) {
                    $(".banner").hide();
                    window.location = "../personal-page";
//                    sweetAlert({
//                        html: true,
//                        title: "<span style= \"color:#fce600\" >Succesfully booked a tent!</span>",
//                        text: "<span style= \"color:#ff9933\" >Now you are going to be redirected to your personal page!</span>",
//                        type: "success",
//                        confirmButtonColor: "#333399",
//                        confirmButtonText: "Okay"
//                    }, function (isConfirm) {
//                        if (isConfirm) {
//                            window.location = "../personal-page";
//                        }
//                    });
                    //alert('Sorry, it is not possible yet, we are working on it though');
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
