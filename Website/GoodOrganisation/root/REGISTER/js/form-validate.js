//some client form validation with jQuery
(function() {
    function checkEmail() {
        if ($('#inputEmail2').val() != $('#inputEmail3').val()) {
            $('#inputEmail2').css("background-color", "#fce600");
            $('#inputEmail3').css("background-color", "#fce600");
        } else {
            $('#inputEmail2').css("background-color", "#ff9933");
            $('#inputEmail3').css("background-color", "#ff9933");
        }
    }

    function checkPass() {
        if ($('#inputPassword4').val() != $('#inputPassword3').val()) {
            $('#inputPassword4').css("background-color", "#fce600");
            $('#inputPassword3').css("background-color", "#fce600");
        } else {
            $('#inputPassword4').css("background-color", "#ff9933");
            $('#inputPassword3').css("background-color", "#ff9933");
        }
    }

    $('#form-container').on('keyup', '#inputEmail2', function() {
        checkEmail();
    });
    $('#form-container').on('keyup', '#inputEmail3', function() {
        checkEmail();
    });
    $('#form-container').on('keyup', '#inputPassword4', function() {
        checkPass();
    });
    $('#form-container').on('keyup', '#inputPassword3', function() {
        checkPass();
    });
}());
