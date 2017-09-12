$(document).ready(function() {
    $(document).on('submit', '#login-form', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/login.php',
            data: data,
            success: function(response) {
                if (response.includes('logged')) {
                  //use of sweetalert-master libraly to display messages
                    swal({
                        html: true,
                        title: "<span style= \"color:#fce600\" >Succesfully signed in!</span>",
                        text: "<span style= \"color:#ff9933\" >Now you are going to be redirected to your personal page!</span>",
                        type: "success",
                        confirmButtonColor: "#333399",
                        confirmButtonText: "Okay"
                    }, function(isConfirm) {
                        if (isConfirm) {
                            window.location = "../../../personal-page";
                        }
                    });
                } else {
                    swal({
                        html: true,
                        title: "<span style= \"color:#fce600\" >Unsuccessfull logging</span>",
                        text: "<span style= \"color:#ff9933\" >Please insert correct data!</span>",
                        type: "error",
                        confirmButtonColor: "#333399",
                        confirmButtonText: "Try again"
                    });
                }
            }
        });
        return false;
    });
});
