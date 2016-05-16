$(document).ready(function() {
    $(document).on('submit', '#login-form', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/login.php',
            data: data,
            success: function(response) {
                if (response.includes('logged')) {

                    swal({
                        title: "Succesfully signed in!",
                        text: "Now you are going to be redirected to your personal page!",
                        type: "success",
                        confirmButtonText: "Okay"
                    }, function(isConfirm) {
                        if (isConfirm) {
                            window.location = "../PERSONAL-PAGE";
                        }
                    });
                } else {
                    swal({
                        title: "Unsuccessfull logging",
                        text: "Please insert correct data!",
                        type: "error",
                        confirmButtonText: "Try again"
                    });
                }
            }
        });
        return false;
    });
});
