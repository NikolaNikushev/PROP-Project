$(document).ready(function() {
  $(document).on('submit', '#login-form', function() {
    var data = $(this).serialize();
    $.ajax({
      type: 'POST',
      url: './php/logout.php',
      data: data,
      success: function(response) {
        console.log(response);
      }
    });
    return false;
  });
});
