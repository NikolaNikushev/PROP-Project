<?php
require_once '../default/phpfunc/dbconfig.php';
require_once 'php/checkCampsAvailable.php';
$count = FillCampData($db_con);
$text = "GROUP DETAILS";
$linkPath = "";
$chckbox = '<input type="checkbox" name="verify" value="yes" id="check" required="required">';
if ($count > 0) {
    $text = "GROUP DETAILS";
    $disbtn = "true";
    $chckbox = '<input type="checkbox" name="verify" value="yes" id="check" required="required">';
} else {
    $text = "WE DEEPLY REGRET, BUT NO PLACES ARE LEFT.";
    $chckbox = '<input type="checkbox" disabled name="verify" value="yes" id="check" required="required">';
}
?>

<!DOCTYPE html>
<html>
    <head>
        <title>RESERVE A TENT</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/integral.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/footer.css">
        <link rel="stylesheet" type="text/css" href="CSS/tentres.css">
        <link rel="stylesheet" type="text/css" href="CSS/banner.css">
        <link rel="stylesheet" type="text/css" href="css/txtareaconsole.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/sweetalert-master/sweetalert-master/dist/sweetalert.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>

        <script type="text/javascript" src="JS/reservation/reserveFStage.js"></script>
        <script type="text/javascript" src="JS/reservation/reserveSStage.js"></script>
        <script type="text/javascript" src="JS/tentres.js"></script>
    </head>
    <body>

        <div class="overlap banner">

            <div class="central">
                <!-- Stuff to be loaded here with ajax -->

            </div>
        </div>

        <div id="header" class="scrolled">
<?php include '../DEFAULT/PAGEPARTS/Header.php'; ?>
        </div>
        <!-- the light blue rectangle in he middle USE AJAX FORM MANIPULATION! -->
        <!--<form action="PHP/ProcessBooking.php" method="post">-->
        <form id = "first-form">
            <div id="tentform" class="content">
                <div id="grtit">
                    <h1><?php echo $text ?></h1>
                </div>
                <div id="controls" class="boxie">
                    <p class="shortline ">Number of tenants: </p>
                    <div class="defcont">
                        <label class="deflabel minus">-</label>
                        <input class="form-control form_numcon" 
                               required="required" type="number" min="1" 
                               value="4" max="6" readonly
                               name="tennum" id="tennum">
                        <label class="deflabel plus">+</label>
                    </div>

                    <!-- do not forget to add an action-->	
                    <p class="shortline dateline">Arrival date: </p>
                    <div class="defcont datecont">
                        <input class="rdbtn" required="required" type="radio" name="datechoice" id="dateeight" value="28">
                        <label class="deflabel" for="dateeight">28 July</label>
                        <input class="rdbtn" required="required" type="radio" name="datechoice" id="datenine" value="29">
                        <label class="deflabel" for="datenine">29 July</label>
                    </div>
                </div>

                <div id="leader" class="boxie">
                    <h2>TENANT 1</h2>
                    <p>Leader email: 
                        <input autofocus="autofocus" class="form-control emimp" required="required" type="email" name="email" id="user_email">
                    </p>
                    <p class="nuwarning">This email was entered more than once!<br>'Continue' button is now deactivated.</p>
                    <p>Leader password:
                        <input class="form-control" required="required" type="password" name="password" id="user_password">
                    </p>
                </div>
                <div class="boxie tenant" id="gu1">
                    <h2>TENANT 2</h2>
                    <p>Email: 
                        <input class="form-control emimp" required="required" type="email" name="guest_em1" id="guest_em1">
                    </p>
                    <p class="nuwarning">This email was entered more than once!<br>'Continue' button is now deactivated.</p>
                </div>
                <div class="boxie tenant" id="gu2">
                    <h2>TENANT 3</h2>
                    <p>Email: 
                        <input class="form-control emimp" required="required" type="email" name="guest_em2" id="guest_em2">
                    </p>
                    <p class="nuwarning">This email was entered more than once!<br>'Continue' button is now deactivated.</p>
                </div>
                <div class="boxie tenant" id="gu3">
                    <h2>TENANT 4</h2>
                    <p>Email: 
                        <input class="form-control emimp" required="required" type="email" name="guest_em3" id="guest_em3">
                    </p>
                    <p class="nuwarning">This email was entered more than once!<br>'Continue' button is now deactivated.</p>
                </div>
                <div class="boxie tenant" id="gu4">
                    <h2>TENANT 5</h2>
                    <p>Email: 
                        <input class="form-control emimp" required="required" type="email" name="guest_em4" id="guest_em4" disabled>
                    </p>
                    <p class="nuwarning">This email was entered more than once!<br>'Continue' button is now deactivated.</p>
                </div>
                <div class="boxie tenant" id="gu5">
                    <h2>TENANT 6</h2>
                    <p>Email: 
                        <input class="form-control emimp" required="required" type="email" name="guest_em5" id="guest_em5" disabled>
                    </p>
                    <p class="nuwarning">This email was entered more than once!<br>'Continue' button is now deactivated.</p>
                </div>
                <div id="price_ver" class="boxie verify">
                    <h2>RESERVATION PRICE:<input class="form-control" 
                                                 required="required" type="number" readonly
                                                 name="finprice" id="finprice"></h2>
                    <div id="ckbx">
<?php echo $chckbox ?>
                        <!--<input type="checkbox" name="verify" value="yes" id="check" required="required">-->
                        <label>
                            I verify the information
                        </label>
                        <div>
                            <input type="submit" value="CONTINUE" class="btn" id="submbtn">
                        </div>
                    </div>
                </div>

            </div>
        </form>
        <!-- FOOTER -->
        <div id="imges">
            <div>
                <img src="IMG/CAMPS.png" alt="CAMPS" id="camps">
            </div>
        </div>

<?php include '../DEFAULT/PAGEPARTS/footer.php'; ?>
        <script src="../DEFAULT/sweetalert-master/sweetalert-master/dist/sweetalert.min.js"></script>
    </body>
</html>