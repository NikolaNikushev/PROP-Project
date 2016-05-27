<?php
require_once '../default/phpfunc/dbconfig.php';
require_once 'php/getallactivities.php';

session_start();
require_once 'php/getPersonalActivities.php';
?>


<!DOCTYPE html>
<html>
    <head>
        <title>ACTIVITIES</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />


        <!-- main stuff -->
        <link rel="stylesheet" type="text/css" href="CSS/activities.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/INTEGRAL.css">
        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/FOOTER.css">

        <link rel="stylesheet" type="text/css" href="../DEFAULT/CSS/fixedmenu.css">

    </head>
    <body>
        <div id="header" class="scrolled">
            <?php include '../DEFAULT/PAGEPARTS/Header.php'; ?>
        </div>

        <div id="contents">

            <!-- for a table of activities on the left-->
            <div id="actpad">
                <div id="padinnercontainer">
                    <div id="desctextbox">
                        <h1 id="actcap">EXPLORE THE VAST CHOICE OF ACTIVITIES</h1>
                        <h2 id="rescap">RESERVE IN ADVANCE FOR THE BEST EXPERIENCE</h2>
                    </div>
                    <div id="allactivities">
                        <ul class="act_container">
                            <?php
                            for ($i = 0; $i < count($activities); $i++) {
                                       /// agressive part! attention! take a look closer! 
                                echo
                                '
                            <li class="act_item">
                                <div class="activity">
                                    <div class="activity_img" style=\'background-image: url("images/deficon.gif")\'>

                                    </div>
                                    
                                    <form action="php/processreservation.php" method="post">
                                    
                                    <div class="activity_info">
                                        <p class="text actname">' . $activities[$i] . /* the name 0 7 */'</p>
                                        <div class="description">
                                            <p class="text desc">
                                                ' . $activities[$i+=1] . /* description 1 */' 
                                            </p>
                                            <p class="text tinyline numbplaces">
                                                Activity Code: ' . $activities[$i+=1] . /* ID 2 .. */'
                                            </p>
                                            <input class="secret" type="text" name="actid" value="' . $activities[$i+=1] . /* ID 3 .. */'">
                                            <p class="text tinyline numbplaces">
                                                Places available: ' . $activities[$i+=1] . /* places 4 */'
                                                <input class="secret" type="text" name="avplaces" value="' . $activities[$i] . /* nr of available places 4 .. */'">
                                            </p>
                                            <input class="secret" type="text" name="resplaces" value="' . $activities[$i+=1] . /* nr of res places 5 .. */'">
                                            <input type="checkbox" class="chkbox" required name="reserve" checked="true" value="yes"><label class="chkbox"> I want to reserve </label>
                                        </div>
                                        <p class="text actdate">' . $activities[$i+=1] . /* date 6 */'</p>
                                    </div>
                                    
                                    <div class="reservebtn">
                                        <!-- <h3 class="text resbtntext">RESERVE</h3> -->
                                        <button type="submit" class="btn text resbtntext">RESERVE</button>
                                    
                                    </div>
                                    
                                    </form>
                                </div>
                            
                            </li>';
                            }
                            ?>


                        </ul>

                    </div>
                </div>
            </div>


            <!-- for personal stats, login required -->
            <div id="personstat">
                <div id="localheader">
                    <div id="popupdes">
                        <p id="bord" class="tocloseoropen">Reservations</p>
                    </div>
                    <div id="managingbtn">
                        <p id="clickbtntext">Your<br>Info</p>
                    </div>
                </div>
                <div id="reservedactconts" class="tocloseoropen">
                    <div id="perscont">
                        <!--
                        <p>Name:</p>
                        <p>
                            Date:
                           </p>
                         <p id="CANCELBTN">CANCEL</p>
                        -->
<?php
if (isset($_SESSION['USER_ID'])) {
    if (count($persact) != 0) {
        for ($i = 0; $i < count($persact); $i++) {

            echo
            '
                        <ul>
                            <li class="res_item">
                            <form action="php/cancelReservation.php" method="post">
                                <div class="actnameanddate">

                                        <p>Name:
                                            <span class="diftxt">' . $persact[$i] . /* the name 0 */' </span>
                                        </p>
                                        <p>Date:
                                            <span class=".diftxt">' . $persact[$i+=1] . /* date 6 */'</span>
                                        </p> 
                                        <input class="secret" type="text" name="actid" value="' . $persact[$i+=1] . /* ID 3 .. */'">
                                        
                                </div>
                                <button type="submit" class="CANCELBTN text resbtntext">Cancel</button>
                            </form>    
                            </li>
                        </ul>';
        }
    } else {
        echo
        '<p>
                            You have no reserved activities :(
                            <br>
                            Start adding them right now!
                        </p>'
        ;
    }
} else {
    echo
    '<p>
                            This option is only for authorized users!
                            <br>
                            Log in at the RESERVE page &#8593
                        </p>'
    ;
}
?>
                    </div>
                </div>
            </div>
        </div>
                        <?php include '../DEFAULT/PAGEPARTS/footer.php'; ?>
            <!-- TRYING TO CONNECT GOOGLE PROVIDED JQUERY -->
            <script type="text/javascript" src="../DEFAULT/JS/jquery-2.2.3.min.js"></script>
            <script type="text/javascript" src="JS\activities.js"></script>
            <script type="text/javascript" src="../DEFAULT/JS/velocity.min.js"></script>
    </body>
</html>