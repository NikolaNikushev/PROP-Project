<?php
require_once '../default/phpfunc/dbconfig.php';
session_start();
?>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <link rel="stylesheet" type="text/css" href="css/tickets.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/footer.css">
        <link rel="stylesheet" type="text/css" href="css/banner.css">
        <link rel="stylesheet" type="text/css" href="css/txtareaconsole.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/sweetalert-master/sweetalert-master/dist/sweetalert.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">
        <link rel="shortcut icon" type="image/x-icon" href="../default/IMAGES/favicon.ico" />
        <link rel="stylesheet" type="text/css" href="../DEFAULT/alertifyjs/css/alertify.min.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/alertifyjs/css/themes/default.min.css">
    </head>
    <body>
        <div class="overlap banner">

            <div class="central">

            </div>
        </div>
        <div id="header" class="nav scrolled">
            <?php include '../DEFAULT/PAGEPARTS/Header.php'; ?>
        </div>
        <div id="contents">
            <div class="TICKETS">
                <img src="images/TICKETS.png" alt="TICKETS">
            </div>
            <div id="tickinfo">
                <div class="desccontainer" id="left">
                    <div class="titles">
                        <h1>TICKETS REPLACED BY:</h1>
                    </div>
                    <div class="main">
                        <!-- For the first type -->
                        <div class="tickoffer">
                            <div class="descr">
                                <p class="mline">
                                    BEST WRISTBAND:
                                </p>
                                <p class="smallline">
                                    BEST WRISTBAND, ISSUED AT THE ENTRANCE
                                </p>
                            </div>
                            <?php
                            //if (isset($_SESSION["BALANCE"])) {
                            //echo '<img id="best" class="pricelink logged" src="images/BTNBEST.png">';
                            //echo $_SESSION["BALANCE"];
//                            } else {
                            echo
                            '<img class="pricelink notlogged" src="images/BTNBEST.png"></a>';
//                            }
                            ?>
                        </div>
                        <!-- For the second type -->
                        <div class="tickoffer">
                            <div class="descr">
                                <p class="mline">
                                    EVEN BETTER WRISTBAND:
                                </p>
                                <p class="smallline">
                                    EVEN BETTER WRISTBAND, SENT BY MAIL.
                                </p>	
                                <p class="smallline">
                                    INCLUDES A T-SHIRT AT THE EVENT STORE.
                                </p>
                            </div>
                            <?php
                            //if (isset($_SESSION["BALANCE"])) {
                            //echo '<img id="best" class="pricelink logged" src="images/BTNBETR.png">';
                            //} else {
                            echo
                            '<img class="pricelink notlogged" src="images/BTNBETR.png"></a>';
                            //}
                            ?>
                        </div>
                        <!-- For the third type -->
                        <div class="tickoffer">
                            <div class="descr">
                                <p class="mline">
                                    PERFECT WRISTBAND:
                                </p>
                                <p class="smallline">
                                    PEFECT WRISTBAND, SENT BY MAIL.
                                </p>	
                                <p class="smallline">
                                    INCLUDES 75 EVENT STICKERS AND A
                                </p>	
                                <p class="smallline">	
                                    HAT AT THE EVENT STORE.
                                </p>
                            </div>
                            <?php
                            //if (isset($_SESSION["BALANCE"])) {
                            //    echo '<img id="best" class="pricelink logged" src="images/BTNPER.png">';
//                            } else {
                            echo
                            '<img class="pricelink notlogged" src="images/BTNPER.png"></a>';
//                            }
                            ?>
                        </div>
                        <!--
                        <div id="largebuttwrap">	
                                <img class="largebutt" src="tickets/images/BTNFAQ.png" class="FAQ">	
                        </div>
                        -->
                    </div>
                </div>
                <div class="desccontainer right" >
                    <div class="titles">
                        <h1>INFO:</h1>
                    </div>
                    <div class="main">
                        <div class="textie catchy">
                            <p>
                                Universe of Sound uses a very non-mainstream
                            </p>
                            <p>
                                ticketing method.
                            </p>
                            <p>
                                Instead of old boring tickets, we use colorful
                            </p>
                            <p>
                                WRITSBANDs!
                            </p>
                        </div>
                        <div class="textie infotips">
                            <p>
                                The wristbands are personalized and in order
                            </p>
                            <p>
                                to buy one, SoundAccound is needed.
                            </p>
                            <p>
                                Plus, you can order it in your FAVORITE COLOR!
                            </p>
                            <p>
                                Please follow the registration instructions ,
                            </p>
                            <p>
                                more information in the RULES.
                            </p>
                        </div>
                        <!--
                        <img class="largebutt" src="tickets/images/BTNSIGN.png" class="signin">	
                        -->
                    </div>
                </div>
                <div id="largebtns">
                    <div class="lrgbutt">
                        <a href="mailto:jobsdoneuniversal@gmail.com?subject=Oh Jeez, Help Me Pleeze&body=I am having troubles with: ">
                            <div class="largebutt FAQ"><p>QUESTIONS?</p></div>
                        </a>
                    </div>
                    <div class="lrgbutt">
                        <a href="../register/index.php">
                            <div class="largebutt lbr"><p>SIGN IN/REGISTER</p></div>
                        </a>
                    </div>
                </div>
            </div>



            <!-- I can not fix this, this is crap, sorry
        <div class="headers">
            <h1>TICKETS REPLACED BY:</h1>
        </div> 
        <div class="par"> 
            <div class="left">
                                    <p> BEST WRISTBAND:  
                                    <br> BEST WRISTBAND. ISSUED AT THE ENTRANCE. 
                                    <img class="images" src="tickets/BTNBEST.png">  
                                    </p> 
                <p> EVEN BETTER WRISTBAND: 
                                    <br> EVEN BETTER WRISTBAND. SENT BY MAIL. 
                                    <br> INCLUDES A T-SHIRT AT THE EVENT STORE. 
                                    <img src="tickets/BTNBETR.png" class="images"></p>
                <p> PERFECT WRISTBAND: 
                                    <br> PERFECT WRISTBAND. SENT BY MAIL. 
                                    <br> INCLUDES 75 EVENT STICKERS AND 
                                    <br> A HAT AT THE EVENT STORE. 
                                    <img src="tickets/BTNPER.png" class="perf">
                </p>
                <img src="tickets/BTNFAQ.png" class="FAQ">
                <img src="tickets/BTNSIGN.png" class="signin">
            </div>                
        </div>
                    <div class = "right">
                            <div class="headers">
                                    <h1>INFO:</h1>
                            </div> 
                                    <p id="p1"> Universe of Sound uses a very non-mainstream <br> ticketing method. <br> Instead of old boring tickets, we use colorful <br> WRISTBAND! <br> <br>The wristbands are personalized and in order <br> to buy one SoundAccound is needed. <br> Plus, you can order it in your favorite color! <br> Please follow the registration instructions. <br> more info in the rules. </p1>
                    </div>	
            -->
        </div> 

        <?php include '../DEFAULT/PAGEPARTS/footer.php'; ?>
        <script src="../DEFAULT/sweetalert-master/sweetalert-master/dist/sweetalert.min.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>
        <script type="text/javascript" src="JS/pricelinkclick.js"></script>
        <script type="text/javascript" src="JS/login-control.js"></script>
        <script type="text/javascript" src="JS/checkout-controls.js"></script>
        <script src="../DEFAULT/alertifyjs/alertify.js"></script>
    </body>

</html>
