$(document).ready(function() {
    $(document).on('submit', '#register-form', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/register.php',
            data: data,
            success: function(response) {
                if (response.includes('Registered')) {
                    alert(response + ' - You are being redirected to your personal page');
                    window.location = "../PERSONAL-PAGE";
                } else {
                    alert(response);
                }
            }
        });
        return false;
    });
});
