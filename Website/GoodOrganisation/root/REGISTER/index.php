<!DOCTYPE html>
<html>
<head>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Sound Account</title>
  <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  <link rel="stylesheet" type="text/css" href="css/main/main.css">
  <link rel="stylesheet" type="text/css" href="css/main/footer.css">
  <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/INTEGRAL.css">
  <link rel="stylesheet" type="text/css" href="css/forms/forms.css">
  <link rel="stylesheet" type="text/css" href="../DEFAULT/sweetalert-master/sweetalert-master/dist/sweetalert.css">
  <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">
</head>

<body>
  <div id="header" class="scrolled" class="container-fluid">
    <?php include '../DEFAULT/PAGEPARTS/Header.php';
    if(isset($_SESSION['USER_ID']))
    {
      //header("Location: ../PERSONAL-PAGE/index.php");
    }
    ?>
  </div>
  <div id="title" class=" container-fluid">
    <p id="title-text">
      SOUND ACCOUNT
    </p>
  </div>
  <div id="main" class="container-fluid">
    <div id="buttons-form-container" class="acc-button col-xs-10 col-md-4 col-xs-offset-1 col-md-offset-4">
      <div class="row">
        <div class="acc-button col-md-4 col-xs-4 col-md-offset-1 col-xs-offset-1">
          <a href="#">
            <p id="sign-in-link" class="acc-button-text">SIGN IN</p>
          </a>
        </div>
        <div class="acc-button col-md-4 col-xs-4 col-md-offset-2 col-xs-offset-2">
          <a href="#">
            <p id="register-link" class="acc-button-text">REGISTER</p>
          </a>
        </div>
      </div>
      <!--Here are loaded the forms  -->
      <div id="form-container">
      </div>
    </div>
  </div>
  </div>
  <?php include '../DEFAULT/PAGEPARTS/footer.php';?>
  <script src="../DEFAULT/js/jquery-2.2.3.min.js"></script>
  <script src="../DEFAULT/sweetalert-master/sweetalert-master/dist/sweetalert.min.js"></script>
  <script src="js/form-loader.js"></script>
  <script src="js/auth/ajax-login.js"></script>
  <script src="js/auth/ajax-register.js"></script>
  <script src="js/form-validate.js"></script>

</body>

</html>
