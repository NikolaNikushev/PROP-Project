<?php
session_start();
require_once 'dbconfig.php';
$outputmsg = "";
$campdata = [];

if (isset($_POST)) {
    try {
        // retrieves the data about an available camp and puts it into the campdata array
        $outputmsg . FillCampData($db_con, $campdata);
        // retrieved a suitable camp, now can proceed to register leaders and tenants
        // now we need to unset the stmnt and send a new query to insert the data into the tentleaders table        
        unset($stmt);
        $outputmsg . InsertLeaderData($db_con, $campdata);

        // send a response, whatever it may be        
        echo $outputmsg;
    } catch (PDOException $e) {
        echo $e->getMessage();
    }
}

function FillCampData($dbcon, &$campdata) {
    $sqlstmt = "SELECT CAMPING_ID, CAPACITY FROM CAMPS WHERE CAPACITY >= :capacity";
    $stmt = $dbcon->prepare($sqlstmt);
    $stmt->execute([
        // looking for a first tent with suitable capacity 
        ":capacity" => $_POST["tennum"],
    ]);

    // selecting the first suitable camp
    $row = $stmt->fetch(PDO::FETCH_ASSOC);
    $count = $stmt->rowCount();
    $campdata = $row;
    echo print_r($row) . $count;
}

function InsertLeaderData($dbcon, &$campdata) {
    date_default_timezone_set("Europe/Amsterdam");
    $date = date("Y-m-d h:i:sa");
    try {
        $dbcon->beginTransaction();
        
        $sqltlds = "INSERT INTO tentleaders (CAMPING_ID, USER_ID) " .
                "VALUES(:camp_id, :leader_id);";
        $sqlsrts ="INSERT INTO serpayments (USER_ID, DATE, PAYSUM, DESCRIPTION) " .
          "VALUES(:leader_id,:date,:sum,'Tent Reservation Payment. Group of :tennumber .');";
        

        $stmtOne = $dbcon->prepare($sqltlds);
        $stmtTwo = $dbcon->prepare($sqlsrts);
        
        $stmtOne -> execute([
            // looking for a first tent with suitable capacity 
            ":camp_id" => $campdata['CAMPING_ID'],
            ":leader_id" => $_SESSION["USER_ID"],
        ]);
        $stmtTwo -> execute([
            // looking for a first tent with suitable capacity 
            ":leader_id" => $_SESSION["USER_ID"],
            ":date" => $date,
             ":sum" => trim($_POST['finprice']),
            //":tennumber" =>  trim($_POST['tennum']),
        ]);
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












<!--echo "<script type='text/javascript'> alert('Sorry, it is not possible yet, we are working on it though".print_r($_POST)."'); window.location.replace('../index.php'); </script>";


-->