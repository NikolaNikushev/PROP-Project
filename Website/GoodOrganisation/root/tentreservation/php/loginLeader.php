<?php

//session_start();
require_once 'dbconfig.php';

if (isset($_POST)) {
    $user_email = strtolower(trim($_POST['email']));
    $user_password = strtolower(trim($_POST['password']));
    $_SESSION["totalprice"] = trim($_POST['finprice']);
    $tprice = trim($_POST['finprice']);
    $_SESSION["tennum"] = trim($_POST['tennum']);
    // number of tenants expected
    $tennbr = trim($_POST['tennum']);
    $password = ($user_password);

    $chckGuest = "guest_em"; // + a number 1-5
    /* Execute a prepared statement using an array of values for an IN clause */
    $params = array($user_email);
    for ($i = 1; $i < 6; $i++) {
        $chckGuest = "guest_em" . (string) $i;
        // if this is asked for, go query the db
        if (isset($_POST[$chckGuest])) {
            array_push($params, strtolower($_POST[$chckGuest]));
        }
    }

    /* Create a string for the parameter placeholders filled to the number of params */
    $place_holders = implode(',', array_fill(0, count($params), '?'));
    // stmnt to retrieve user data
    $sqlForLead = "SELECT USER_ID, PASSWORD, EMAIL, PAID, FNAME, LNAME, BALANCE, IFNULL(CAMPING_ID,'nan') as CAMP FROM "
            . "visitors WHERE "
            . "LOWER(EMAIL) = LOWER( :email )";
    // stmnt to count
    $sqlForCount = "SELECT COUNT(*) as NMBR "
            . "FROM visitors "
            . "WHERE "
            . "LOWER(visitors.EMAIL) IN ($place_holders) "
            . ";";
    //. "AND visitors.CAMPING_ID is NULL;";
    $sqlForPrevResCheck = "SELECT COUNT(*) as NMBR "
            . "FROM visitors "
            . "WHERE "
            . "LOWER(visitors.EMAIL) IN ($place_holders) "
            . "AND visitors.CAMPING_ID is NULL;";
    try {
        $db_con->beginTransaction();

        $stmtLD = $db_con->prepare($sqlForLead);
        $stmtNBR = $db_con->prepare($sqlForCount);
        $stmtCH = $db_con->prepare($sqlForPrevResCheck);

        $stmtLD->execute([
            ":email" => $_POST['email'],
        ]);
        $stmtNBR->execute($params);
        $stmtCH->execute($params);

        $row = $stmtLD->fetch(PDO::FETCH_ASSOC);
        $countres = $stmtNBR->fetch(PDO::FETCH_ASSOC);
        $checkres = $stmtCH->fetch(PDO::FETCH_ASSOC);

        $count = $countres["NMBR"];
        $checksum = $checkres["NMBR"];
        // checking if returned the same amount as expected
        if ($count == $tennbr) {
            // only if returned as many rows as emails were input
            if ($checksum == $tennbr) {
                if (strtolower($row['PASSWORD']) == $password && $password != "") {
                    if ($row['PAID'] == 1) {
                        if ($row['CAMP'] == 'nan') {
                            echo "Congrats, you have logged in";
                            //echo "ok-you logged in" . print_r($row) . print_r($params) . " for this number of tenants:" . $tennbr . " searchguest " . $chckGuest . " :ANDSEARCHQUERYWAS:" . print_r($params);
                            $_SESSION["USER_ID"] = $row['USER_ID'];
                            $_SESSION["LEADERDATA"] = $row;
                        } else {
                            echo "Sorry, but a tent can not be purchased without a confirmed ticket payment. Visit the page 'TICKETS' for more relevant information.";
                        }
                    } else {
                        echo "Sorry, but a tent can not be purchased without a confirmed ticket payment. Visit the page 'TICKETS' for more relevant information.";
                    }
                } else {
                    echo "This combination of an email and a password is unknown. Please make sure you have entered it correctly";
                    //echo "This combination of an email and a password is unkknown" . print_r($params) . " for this number of tenants:" . $tennbr . " searchguest " . $chckGuest . ":ANDSEARCHQUERYWAS:" . print_r($params);                ;
                }
            } else {
                echo "At least one of the future tenants has already reserved a tent. Unfortunately, it is not possible to rewrite the previous reservation.";
            }
        } else {
            echo "At least one of the email is not registered in out system. Make sure that you have entered correct emails";
        }
        unset($stmt);
    } catch (PDOException $e) {
        unset($stmt);
        $info = print_r($_POST);
        echo $info . $e->getMessage();
    }
    // uncompetible with language version? srsly? 
//    finally {
//        unset($stmt);
//    }
}
?>
