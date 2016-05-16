$(document).ready(function() {
    $(document).on('submit', '#add-credits', function() {
        var data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: './php/add-credits.php',
            data: data,
            success: function(response) {
                alert(response);
            }
        });
        return false;
    });
});
