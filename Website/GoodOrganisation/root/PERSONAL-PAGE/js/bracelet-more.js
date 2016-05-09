$(document).ready(function() {
    $('#more-button').click(function() {
        $('#bracelet').css({
            "background-color": "#3b4d81"

        });
        // $('#bottom-containers').css("padding-top", "23vh");
        $('.bracelet-text').css("color", "#fce600");
        $('#bracelet-container').css('height', 'auto');
        $('#bracelet-container').load("click-html/bracelet.php");
        $('#more-button').hide();
    });
    //when you click the close button
    $(document.body).on("click", '#bracelet-close-button', function() {
        $('#bracelet').css({
            "background-color": "#fce600"

        });
        $('.bracelet-text').css("color", "#3b4d81");
        $('#bracelet-container').empty();
        $('#bracelet-container').css('height', '0px');
        $('#more-button').show();
    });

});
