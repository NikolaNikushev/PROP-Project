var dataMain;
var numberTennts = $("#tennum").val();
var totalPrice = $("#finprice").val();
var pricePerDay = Math.floor(totalPrice / numberTennts);
var resp;
$(document).ready(function () {
    $(document).on('submit', '#first-form', function () {
        if ($('#check').is(":checked"))
        {
            dataMain = $(this).serialize();
            //alert(dataMain);
            //var email = $("#user_email").val();
            //var password = $("#user_password").val();
            //var partialdatastring = 'email='+ email 
            //      + '&password='+ password;
            alert(dataMain)
            $.ajax({
                type: 'POST',
                url: 'php/loginLeader.php',
                data: dataMain,
                success: function (response) {
                    if (response.includes('logged')) {

                        $(".banner").show();
                        $(".central").load("pageparts/BannerReg.php");
                        //$("#Reg").show();
                        //alert(response);

                    } else {
                        $(".banner").show();
                        $(".central").load("pageparts/BannerNoReg.php", {resp: response});
                        //$("#noReg").show();
                        //alert(response);
                        resp = response;
                    }
                }
            });
        }
        else
        {
            $(".banner").show();
            $(".central").load("pageparts/BannerNoReg.php", {resp: "Not possible to proceed without the verification"});
            //$("#noReg").show();
            //alert(response);
            return false;
        }
        ;
        return false;
    });
});
