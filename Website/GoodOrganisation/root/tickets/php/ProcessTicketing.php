<?php
session_start();
require_once 'dbconfig.php';
$outputmsg = "";
$campdata = [];
$count = 0;

if (isset($_POST)) {
    try {

        RecordPayment($db_con, $campdata);
        // send a response, whatever it may be        
        //echo $outputmsg;
    } catch (PDOException $e) {
        echo $e->getMessage();
    }
}

function RecordPayment($dbcon, &$campdata) {
    date_default_timezone_set("Europe/Amsterdam");
    $date = date("Y-m-d h:i:s");
    try {
        $user_id = $_SESSION['USER_ID'];
        
        // to execute a lot of queries at once
        $dbcon->beginTransaction();
        $newBal = trim($_POST['ybal']) - trim($_POST['price']);
        $sqlsrts = "INSERT INTO serpayments (USER_ID, DATE, TYPE, PAYSUM, DESCRIPTION) " .
                "VALUES(:user_id,:date, '-',:sum,'Ticket Payment');";

        $sqlgVisUpd = "UPDATE visitors "
                . "SET visitors.BALANCE = :reducedBalance, "
                . "visitors.PAID = 1 "
                . "WHERE visitors.USER_ID = :user_id ;";
 
        // creates the entry in the payments
        $stmtOne = $dbcon->prepare($sqlsrts);
        // updates the user data
        $stmtTwo = $dbcon->prepare($sqlgVisUpd);

        $stmtOne->execute([
            // looking for a first tent with suitable capacity 
            ":user_id" => $_SESSION["USER_ID"],
            ":date" => $date,
            ":sum" => trim($_POST['price']),
        ]);
        
        $stmtTwo->execute([
            ":reducedBalance" => $newBal,
            ":user_id" => $_SESSION["USER_ID"],
        ]);
        
        $dbcon->commit();
        echo "sucessful transaction".$newBal;
    } catch (Exception $ex) {
        $dbcon->rollBack();
        echo $ex->getMessage();
    }
}

//
//            "INSERT INTO serpayments (USER_ID, DATE, PAYSUM, DESCRIPTION) " .
//            "VALUES(:leader_id,:date,:sum,'Tent Reservation Payment. Group of :tennumber .');"
//            ":leader_id" => $_SESSION["USER_ID"],
//            ":date" => $date,
//            ":sum" => trim($_POST['finprice']),
//            ":tennumber" =>  trim($_POST['tennum']),
?>