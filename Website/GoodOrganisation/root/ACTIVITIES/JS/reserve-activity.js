$(document).ready(function () {
    //alertify.set({delay: 2000});
    $(document).on('submit', '.formreservation', function () {
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
            url: 'php/processreservation.php',
            data: dataMain,
            success: function (response) {
                if (response.includes('correct')) {
                    
                    alertify.notify('Success!', 'success', 1, function(){  console.log('success'); 
                        window.location.reload(); } );
                    
                } else {
                    if (response.includes("failure"))
                    {
                        alertify.notify("You appear to have already been registered", 'error', 2);
                    }
                    ;

                    if (response.includes("noplaces"))
                    {
                        alertify.notify("Ouch, seems like no places are left to book*.\n*However, be sure to check it out the at the festival",'error', 2);
                    }
                    ;
                    if (response.includes("noreg"))
                    {
                        alertify.notify("Hey, you need to be registered to book a place!",'error', 2);
                    }
                    ;



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
