// currently not being used

$(document).ready(function() {
  $('#logout-a').on('click', function() {
    $.ajax({
      type: 'POST',
      url: '../DEFAULT/PHPFUNC/logout.php',
      success: function(response) {
        alert(response);
        window.location = "../PERSONAL-PAGE";
      }
    });
    return false;
  });
});
