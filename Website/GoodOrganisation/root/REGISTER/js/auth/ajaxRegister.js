$(document).ready(function() {
  $(document).on('submit', '#register-form', function() {
    var data = $(this).serialize();
    console.log('goshe');
    $.ajax({
      type: 'POST',
      url: './php/register.php',
      data: data,
      success: function(response) {
        alert(response + ' - You are being redirected to your personal page');
        window.location="../PERSONAL-PAGE";

      }
    });
    return false;
  });
});
