<?php
//    require_once '../../default/phpfunc/dbconfig.php';

function FillCampData($dbcon) {
    $sqlstmt = "SELECT CAMPING_ID FROM CAMPS WHERE STATUS = 1";
    $stmt = $dbcon->prepare($sqlstmt);
    $stmt->execute();

    return $count = $stmt->rowCount();
}
?>