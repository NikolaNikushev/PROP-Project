$(document).ready(function () {
    //alertify.set({delay: 2000});
    $(document).on('submit', '.cancelactform', function () {
//        alert("blob");
//        if ($('#check').is(":checked"))
//        {
        dataMain = $(this).serialize();
//            //alert(dataMain);
//            //var email = $("#user_email").val();
//            //var password = $("#user_password").val();
//            //var partialdatastring = 'email='+ email 
//            //      + '&password='+ password;
//            alert(dataMain)
        $.ajax({
            type: 'POST',
            url: 'php/cancelReservation.php',
            data: dataMain,
            success: function (response) {
                if (response.includes('correct')) {

                    alertify.notify('Thanks for a timely cancelation!', 'success', 1, function () {
                        console.log('success');
                        window.location.reload();
                    });

                } else {

                    alertify.notify("Ouch, something went terribly wrong!", 'error', 2);
                }
            }
        });
//        }
//        else
//        {
//            $(".banner").show();
//            $(".central").load("pageparts/BannerNoReg.php", {resp: "Not possible to proceed without the verification"});
//            //$("#noReg").show();
//            //alert(response);
//            return false;
//        }
//        ;
        return false;
    });
});
