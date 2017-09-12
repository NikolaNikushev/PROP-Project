$(document).ready(function() {
  //when you click show button
    $('#show-button').click(function() {
        $('#general').css({
            "background-color": "#3b4d81"

        });
        // $('#bottom-containers').css("padding-top", "23vh");
        // // $('#container').css("padding-bottom", "23vh");

        $('#general-text').css("color", "#fce600");
        $('#general-container').css('height', 'auto');
        $('#general-container').load("ajax-loaded-content/general.php");
        $('#show-button').hide();
    });
//when you click the close button
    $(document.body).on("click", '#general-close-button', function() {
        $('#general').css({
            "background-color": "#fce600"

        });
        $('#general-text').css("color", "#3b4d81");
        $('#general-container').empty();
        $('#general-container').css('height', '0px');
        $('#show-button').show();
    });
});
