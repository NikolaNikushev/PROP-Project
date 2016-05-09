$(document).ready(function() {
    $('#add-button').click(function() {
        $('#balance').css({
            "background-color": "#3b4d81"

        });
        // $('#bottom-containers').css("padding-top", "23vh");
        $('.balance-text').css("color", "#fce600");
        $('#balance-container').css('height', 'auto');
        $('#balance-container').load("click-html/balance.php");
        $('#add-button').hide();
    });
    //when you click the close button
    $(document.body).on("click", '#balance-close-button', function() {
        $('#balance').css({
            "background-color": "#fce600"

        });
        $('.balance-text').css("color", "#3b4d81");
        $('#balance-container').empty();
        $('#balance-container').css('height', '0px');
        $('#add-button').show();
    });

});
