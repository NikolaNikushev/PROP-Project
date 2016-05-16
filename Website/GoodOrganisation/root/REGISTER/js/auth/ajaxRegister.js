$(document).ready(function() {
    $(document).on('submit', '#register-form', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/register.php',
            data: data,
            success: function(response) {
                if (response.includes('Registered')) {

                    swal({
                      title: "Succesfully registered!",
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
                    title: "Unsuccessfull registration",
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
