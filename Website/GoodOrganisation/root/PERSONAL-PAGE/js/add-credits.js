$(document).ready(function() {
    $(document).on('submit', '#add-credits', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/addCredits.php',
            data: data,
            success: function(response) {
                if (response == 'Successfully updated') {
                    // showing message with the help of 'Sweet Alert framework'
                    swal({
                        html: true,
                        title: "<span style= \"color:#fce600\" >Succesfully updated balance!</span>",
                        text: "<span style= \"color:#ff9933\" >We are going to refresh the page for you, so you can get the latest data!</span>",
                        type: "success",
                        confirmButtonColor: "#333399",
                        confirmButtonText: "Okay"
                    }, function(isConfirm) {
                        if (isConfirm) {
                            location.reload();
                        }
                    });
                }
            }
        });
        return false;
    });
});
