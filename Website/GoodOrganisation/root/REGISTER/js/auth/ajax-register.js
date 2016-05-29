$(document).ready(function() {
    $(document).on('submit', '#register-form', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/register.php',
            data: data,
            success: function(response) {
                alert(response);
                if (response.includes('Registered')) {
                    //use of sweetalert-master libraly to display messages
                    swal({
                        html: true,
                        title: "<span style= \"color:#fce600\" >Succesfully registered!</span>",
                        text: "<span style= \"color:#ff9933\" >Now you are going to be redirected to the tickets page!</span>",
                        confirmButtonColor: "#333399",
                        type: "success",
                        confirmButtonText: "Okay"
                    }, function(isConfirm) {
                        if (isConfirm) {
                            window.location = "../tickets";
                        }
                    });

                } else {
                    swal({
                        html: true,
                        title: "<span style= \"color:#fce600\" >Unsuccessfull registration</span>",
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
