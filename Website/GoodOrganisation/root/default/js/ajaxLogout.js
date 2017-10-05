// currently not being used

$(document).ready(function() {
    $('#logout-a').on('click', function() {
        $.ajax({
            type: 'POST',
            url: '../default/phpfunc/logout.php',
            success: function(response) {
                alert(response);
                window.location = "../../personal-page";
            }
        });
        return false;
    });
});