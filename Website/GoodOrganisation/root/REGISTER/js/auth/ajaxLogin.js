$(document).ready(function() {
    $(document).on('submit', '#login-form', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/login.php',
            data: data,
            success: function(response) {
                if (response.includes('logged')) {
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
