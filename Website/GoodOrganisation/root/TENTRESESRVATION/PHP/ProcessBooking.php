<?php
session_start();
require_once 'dbconfig.php';

if (isset($_POST)) {
 
    $password = ($user_password);
    $sqlstmt = "SELECT CAMPING_ID FROM CAMPS WHERE CAPACITY >= :capacity";
    try {

        $stmt = $db_con->prepare($sqlstmt);
        $stmt->execute([
            ":capacity" => $_POST["tennum"],
        ]);
        
        
        $row = $stmt->fetch(PDO::FETCH_ASSOC);
        $count = $stmt->rowCount();

        echo print_r($row);
    } catch (PDOException $e) {
        echo $e->getMessage();
    }
}
?>











<!--echo "<script type='text/javascript'> alert('Sorry, it is not possible yet, we are working on it though".print_r($_POST)."'); window.location.replace('../index.php'); </script>";


-->