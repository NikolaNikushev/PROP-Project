<?php
require_once '../default/phpfunc/dbconfig.php';
require_once 'php/checkCampsAvailable.php';
$count = FillCampData($db_con);
$imgPath = "";
$linkPath = "";
if ($count > 0) {
    if ($count > 1) {
        $imgPath = "images/BTNRESERVE.png";
    } else {
        $imgPath = "images/onetipisleft.png";
    }
    $linkPath = "../tentreservation/";
} else {
    $imgPath = "images/notipisleft.png";
    $linkPath = "#";
}
?>
<!DOCTYPE html>

<html>

    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
        <link rel="stylesheet" type="text/css" href="css/main/camping.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/footer.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/alertifyjs/css/alertify.min.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/alertifyjs/css/themes/default.min.css">
        <title>Reserve Camping</title>
    </head>

    <body>
        <div id="header" class="scrolled container-fluid">
            <img id="logo" class="logo" src="images/logo.png"/>
<?php include '../DEFAULT/PAGEPARTS/HeaderLinks.php'; ?>
        </div>
        <div id="main" class="container-fluid">
            <div class="row">
                <div class="col-md-4 col-md-offset-4 " id="title">
                    <p id="title-text">TENTS</p>
                </div>
            </div>
            <div class="row" id="main-content">
                <div class="col-md-4 col-md-offset-2" id="image">
                    <a href="<?php echo $linkPath ?>"><img id="campresim" src="<?php echo $imgPath ?>" alt="Reserve a Tent!" /></a>
                </div>
                <div class="col-md-4" id="text-container">
                    <p id="text">
                        Live with friends in a comfortable tipi.
                        <br/> Be closer to the nature and the stars.
                        <br/>
                        <br/> Tipis are available for grup reservations.
                        <br/> One payment can be made for many friends.
                        <br/> The SoundAccount is needed for all.
                        <br/> members of the camping group.
                        <br/>
                    </p>
                </div>
            </div>
        </div>
<?php include '../DEFAULT/PAGEPARTS/footer.php'; ?>
<script src="../DEFAULT/alertifyjs/alertify.js"></script>
    </body>

</html>
