<?php

session_start();
require_once 'dbconfig.php';
$outputmsg = "";
$campdata = [];
$count = 0;

if (isset($_POST)) {
    try {
        // retrieves the data about an available camp and puts it into the campdata array
        $outputmsg . FillCampData($db_con, $campdata, $count);
        // retrieved a suitable camp, now can proceed to register leaders and tenants
        // now we need to unset the stmnt and send a new query to insert the data into the tentleaders table        
        unset($stmt);
        if ($count !== 0) {
            InsertLeaderData($db_con, $campdata);
        }
        // send a response, whatever it may be        
        //echo $outputmsg;
    } catch (PDOException $e) {
        echo $e->getMessage();
    }
}

function FillCampData($dbcon, &$campdata, &$count) {
    $sqlstmt = "SELECT CAMPING_ID FROM CAMPS WHERE AVAILABLE = 1";
    $stmt = $dbcon->prepare($sqlstmt);
    $stmt->execute();

    // selecting the first suitable camp
    $row = $stmt->fetch(PDO::FETCH_ASSOC);
    $count = $stmt->rowCount();
    $campdata = $row;
    echo print_r($row) . $count;
}

function InsertLeaderData($dbcon, &$campdata) {
    date_default_timezone_set("Europe/Amsterdam");
    $date = date("Y-m-d h:i:s");
    try {
       echo $_SESSION["USER_ID"];
                echo $date.' ';
                echo trim($_POST['finprice']);
        $user_email = trim($_POST['email']);
        $chckGuest = "guest_em"; // + a number 1-5
        /* Execute a prepared statement using an array of values for an IN clause */
        $params = array($user_email);
        for ($i = 1; $i < 6; $i++) {
            $chckGuest = "guest_em" . (string) $i;
            // if this is asked for, go query the db
            if (isset($_POST[$chckGuest])) {
                array_push($params, $_POST[$chckGuest]);
            }
        }
        $place_holders = implode(',', array_fill(0, count($params), '?'));


        $dbcon->beginTransaction();
        $campid = $campdata['CAMPING_ID'];
        //echo "----" . $campid . "----";
        $sqltlds = "INSERT INTO tentleaders (CAMPING_ID, USER_ID, ARRIVALDATE, LEAVEDATE) " .
                "VALUES(:camp_id, :leader_id, :datearr, :datel);";

        $sqlsrts = "INSERT INTO serpayments (USER_ID, DATE, TYPE, PAYSUM, DESCRIPTION) " .
                "VALUES(:leader_id,:date,'TENT',:sum,'Tent Reservation Payment. Group of " . $_POST['tennum'] . " .');";
                // maybe better it would be better to replace the '-' with a type of payment - like camping
        $sqlgrres = "UPDATE visitors SET visitors.BALANCE = :reducedBalance where visitors.USER_ID = :leader_id";

        $sqlvis = "UPDATE visitors "
                . "SET visitors.CAMPING_ID = ".$campid." "
                . "WHERE visitors.email in ( $place_holders );";

        $sqlcamps = "UPDATE camps "
                . "SET camps.AVAILABLE = '0' "
                . "WHERE camps.CAMPING_ID = '". $campid ."' ;";

        // asks for an array... 
        // populates the tent leader table
        $stmtTL = $dbcon->prepare($sqltlds);
        // creates the entry in the payments
        $stmtSERPAYMENTS = $dbcon->prepare($sqlsrts);
        $stmtREDBAL = $dbcon->prepare($sqlgrres);
        // assigns the camping id to all the tenants in a group 
        $stmtVISUPD = $dbcon->prepare($sqlvis);
        // makes a camp unavailable
        $stmtCAMPUPD = $dbcon->prepare($sqlcamps);

        $stmtTL->execute([
            // looking for a first tent with suitable capacity 
            ":camp_id" => $campdata['CAMPING_ID'],
            ":leader_id" => $_SESSION["USER_ID"],
            ":datearr" => $_POST['datearr'],
            ":datel" => $_POST['datel'],
        ]);
        $stmtSERPAYMENTS->execute([
            // looking for a first tent with suitable capacity 
            ":leader_id" => $_SESSION["USER_ID"],
            ":date" => $date,
            ":sum" => trim($_POST['finprice']),
                //":tennumber" =>  trim($_POST['tennum']),
        ]);
        //new balance for the leader: 
        $newBal = $_POST['ybal'] - $_POST['finprice'];
        $stmtREDBAL->execute([
            ":reducedBalance" => $newBal,
            ":leader_id" => $_SESSION["USER_ID"],
        ]);

        $stmtVISUPD->execute($params);
        $stmtCAMPUPD->execute();

        // selecting the first suitable camp
        $dbcon->commit();
        echo "sucessful transaction";
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