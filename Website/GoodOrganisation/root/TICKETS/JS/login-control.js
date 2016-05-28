$(document).ready(function() {
    $(document).on('submit', '#loginform', function() {
        if(consopen)
        {
            $("#cons").remove();
        }
        
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/login.php',
            data: data,
            success: function(response) {
                if (response.includes('logged')) {
                  //use of sweetalert-master libraly to display messages
                    $(".forlogin").remove();
                    $(".central").load("pageparts/bannerCheckout.php", {price: 55});
                } else {
                    consopen = true;
                    $(".errorconsole").load("pageparts/alertBox.php", {resp: response});
//                    swal({
//                        html: true,
//                        title: "<span style= \"color:#fce600\" >Unsuccessfull logging</span>",
//                        text: "<span style= \"color:#ff9933\" >Please insert correct data!</span>",
//                        type: "error",
//                        confirmButtonColor: "#333399",
//                        confirmButtonText: "Try again"
//                    });
                }
            }
        });
        return false;
    });
});

var consopen = false;