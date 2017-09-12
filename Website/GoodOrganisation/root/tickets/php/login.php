<?php

session_start();
require_once 'dbconfig.php';

if (isset($_POST)) {
    $user_email = trim($_POST['user_email']);
    $user_password = trim($_POST['password']);

    $password = ($user_password);

    try {

        $stmt = $db_con->prepare("SELECT USER_ID, PASSWORD, PAID, EMAIL, FNAME, LNAME, BALANCE "
                . "FROM visitors "
                . "WHERE LOWER(EMAIL)=LOWER(:email)");
        $stmt->execute(array(":email" => $user_email));
        $row = $stmt->fetch(PDO::FETCH_ASSOC);
        $count = $stmt->rowCount();

        if ($row['PASSWORD'] == $password && $password != "") {
            // you pay only once
            if ($row['PAID'] == 0) {
                echo "ok-you logged in" . print_r($row);
                $_SESSION["USER_ID"] = $row['USER_ID'];
                $_SESSION["BALANCE"] = $row['BALANCE'];
            } else {
                echo "You already have purchased a ticket once. Thank you for your determination, but it's enough.&#13;&#10However, If you really need to buy one, contact us in person.";
            }
        } else {

            echo "Email or password are not correct.&#13;&#10Try again, s'il vous plait.";
        }
    } catch (PDOException $e) {
        echo $e->getMessage();
    }
}
?>
