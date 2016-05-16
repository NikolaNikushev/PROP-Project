<?php
session_start();
require_once 'php/dbconfig.php';
require_once 'php/loanItemsData.php';
require_once 'php/campData.php';
require_once 'php/acivitiesData.php';
 ?>
<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="css/main/footer.css">
    <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">
    <link rel="stylesheet" type="text/css" href="css/main/information-and-tipi.css">
    <link rel="stylesheet" type="text/css" href="css/main/items-and-activities.css">
    <link rel="stylesheet" type="text/css" href="css/click-html/general-show.css">
    <link rel="stylesheet" type="text/css" href="css/click-html/bracelet-more.css">
    <link rel="stylesheet" type="text/css" href="css/click-html/balance-add.css">
    <title>Personal Page</title>
</head>

<body>
    <div id="header" class="scrolled" class="container-fluid">
        <?php include '../DEFAULT/PAGEPARTS/Header.php';?>
    </div>

    <div id="container" class="container-fluid">
        <div class="row " id="top-containers">
            <!--INFORMATION BAR  -->
            <div class="col-md-3 col-md-offset-2" id="information">
                <div class="row ">
                    <p class="container-title">
                        INFORMATION
                    </p>
                </div>
                <div class="row" id="blank"></div>
                <div class="row user-text-container">
                    <p class="user-text user-text-center">
                        <?php echo $FNAME." ".$LNAME ?>
                    </p>
                </div>
                <div class="row" id="blank"></div>
                <div class="row user-text-container" id="general">
                    <div class="col-xs-4">
                        <p class="user-text" id="general-text">
                            General
                        </p>
                    </div>
                    <div class="col-xs-8">
                        <a href="#/">
                            <p class="person-button" id="show-button">
                                show
                            </p>
                        </a>
                    </div>

                </div>
                <div id="general-container" class="row">

                </div>
                <div class="row" id="blank"></div>
                <div class="row user-text-container" id="balance">
                    <div class="col-xs-4">
                        <p class="user-text balance-text">
                            Balance:
                        </p>
                    </div>
                    <div class="col-xs-5">
                        <p class="user-text balance-text">
                            <?php echo $BALANCE ?>&nbspc
                        </p>
                    </div>
                    <div class="col-xs-3">
                        <a href="#/">
                            <p class="person-button" id="add-button">
                                add
                            </p>
                        </a>
                    </div>
                </div>
                <div id="balance-container" class="row">

                </div>

                <div class="row" id="blank"></div>
                <div class="row user-text-container" id="bracelet">
                    <div class="col-xs-3">
                        <p class="user-text bracelet-text">
                            Bracelet:
                        </p>
                    </div>
                    <div class="col-xs-4 col-xs-offset-2">
                    </div>
                    <div class="col-xs-3">
                        <a href="#/">
                            <p class="person-button" id="more-button">
                                show
                            </p>
                        </a>
                    </div>

                </div>
                <div id="bracelet-container" class="row">

                </div>
            </div>
            <!--TIPI BAR  -->
            <div class="col-md-3 col-md-offset-2 info-bar" id="tipi">
                <div class="row">
                    <p class="container-title">
                        YOUR TIPI
                    </p>
                </div>
                <div class="row" id="pic-container">
                    <img id="tipi-picture" class="col-md-8 col-md-offset-2" src="images/tipi.gif" alt="" />
                </div>
                <div class="row">
                    <div class="col-xs-3">
                        <p class="tipi-text">
                            Number:
                        </p>
                    </div>
                    <div class="col-xs-9">
                        <p class="tipi-text">
                            <?php echo $TENTNR ?>
                        </p>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-3 ">
                        <p class="tipi-text">
                            Chief:
                        </p>
                    </div>
                    <div class="col-xs-9">
                        <p class="tipi-text">
                            <?php echo $CHIEFFNAME." ".$CHIEFLNAME ?>
                        </p>
                    </div>
                </div>

            </div>

        </div>
        <div class="row " id="bottom-containers">
            <!--ITEMS BAR  -->
            <div class="col-md-3 col-md-offset-2 info-bar" id="items">

                <div class="row">
                    <p class="container-title">
                        ITEMS
                    </p>
                </div>
                <div id="scroll">

                  <?php
                  for ($i=0; $i < count($items); $i++) {
                  echo ' <div id="object-contrainer">
                        <div class="row">
                            <p class="object-title">
                                '.$items[$i].'
                            </p>
                        </div>
                        <div class="row">
                            <div class="col-xs-6">
                                <p class="object-info">
                                    START DATE:
                                </p>
                            </div>
                            <div class="col-xs-6">
                                <p class="object-text">
                                  '.$items[$i+=1].'
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-6">
                                <p class="object-info">
                                    DUE DATE:
                                </p>
                            </div>
                            <div class="col-xs-6">
                                <p class="object-text">
                                  '.$items[$i+=1].'
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-6">
                                <p class="object-info">
                                    PRICE/DAY:
                                </p>
                            </div>
                            <div class="col-xs-6">
                                <p class="object-text">
                                    '.$items[$i+=1].'
                                </p>
                            </div>
                        </div>
                    </div>';
                    }
               ?>

                </div>
            </div>
            <!-- ACTIVITIES BAR  -->
            <div class="col-md-3 col-md-offset-2 info-bar" id="activities">
                <div class="row">
                    <p class="container-title">
                        ACTIVITIES
                    </p>
                </div>

                <div id="scroll">
                  <?php
                  for ($i=0; $i < count($activities); $i++) {

                  echo ' <div id="object-contrainer">
                            <div class="row">
                              <div class="col-xs-12">
                                <p class="object-title">
                                      '.$activities[$i].'
                                </p>
                              </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-6">
                                    <p class="object-info">
                                        DATE:
                                    </p>
                                </div>
                                <div class="col-xs-6">
                                    <p class="object-text">
                                         '.$activities[$i+=1].'
                                    </p>
                                </div>
                            </div>
                        </div>';
                    }
                    ?>
                </div>
            </div>
        </div>
    </div>

    <div id="footer" class="container-fluid">
        <img id="footerlogo" src="images/LOGOFOOT.png" />
        <ul id="footernav">
            <li><a href="#">NEWS & SOCIAL</a></li>
            <li><a href="#">CONTACT US</a></li>
            <li><a href="#">TERMS AND PRIVACY</a></li>
        </ul>
        <div id="social">
            <img id="footerfacebook" src="images/facebook.png" />
            <img id="footertwitter" src="images/twitter.png" />
            <img id="footergplus" src="images/gplus.png" />
        </div>
        <p id="copyright">COPYRIGHT:2016</p>
    </div>
    <script src="https://code.jquery.com/jquery-2.2.2.min.js" integrity="sha256-36cp2Co+/62rEAAYHLmRCPIych47CvdM+uTBJwSzWjI=" crossorigin="anonymous"></script>
    <script src="js/general-show.js"></script>
    <script src="js/bracelet-more.js"></script>
    <script src="js/balance-add.js"></script>
    <script src="js/add-credits.js"></script>


</body>

</html>
