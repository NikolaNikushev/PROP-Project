$(document).ready(function() {
  $('#form-container').load('forms/register-form.html');
  $('#sign-in-link').click(function() {
    $('#form-container').load('forms/sign-in-form.html');
  });
  $('#register-link').click(function() {
    $('#form-container').load('forms/register-form.html');
  });
});
