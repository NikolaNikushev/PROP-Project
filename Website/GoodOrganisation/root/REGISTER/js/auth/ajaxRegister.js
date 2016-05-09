$(document).ready(function() {
  $(document).on('submit', '#register-form', function() {
    var data = $(this).serialize();
    console.log('goshe');
    $.ajax({
      type: 'POST',
      url: './php/register.php',
      data: data,
      success: function(response) {
        console.log(response);
      }
    });
    return false;
  });
});
