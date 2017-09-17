<?php

session_start();
require_once 'dbconfig.php';
if ($_POST) {
    $first_name = ucwords(strtolower($_POST['first_name']));
    $last_name = ucwords(strtolower($_POST['last_name']));
    $date_of_birth = $_POST['date_of_birth'];
    $user_password = $_POST['password'];
    $c_user_password = $_POST['cpassword'];
    $user_email = strtolower($_POST['user_email']);
    $c_user_email = strtolower($_POST['c_user_email']);
    $user_address = ucwords(strtolower($_POST['sba'])) . ',' . ucwords(strtolower($_POST['city'])) . ',' . strtoupper($_POST['country']) . ',' . strtoupper($_POST['zip']);
    $joining_date = date('Y-m-d H:i:s');

    try {
        if ($user_password == $c_user_password && $user_email == $c_user_email) {
            $stmt = $db_con->prepare("SELECT * FROM visitors WHERE EMAIL=:email");
            $stmt->execute(array(":email" => $user_email));
            $count = $stmt->rowCount();
            if ($count == 0) {

                $stmt = $db_con->prepare("INSERT INTO visitors(FNAME,LNAME,EMAIL,PASSWORD,DOB,REGDATE,ADDRESS) VALUES(:fname,:lname,:email, :pass,:dob,:jdate,:addr)");

                $stmt->bindParam(":fname", $first_name);
                $stmt->bindParam(":lname", $last_name);
                $stmt->bindParam(":pass", $password);
                $stmt->bindParam(":dob", $date_of_birth);
                $stmt->bindParam(":jdate", $joining_date);
                $stmt->bindParam(":email", $user_email);
                $stmt->bindParam(":pass", $user_password);
                $stmt->bindParam(":addr", $user_address);

                if ($stmt->execute()) {
                    $stmt = $db_con->prepare("SELECT * FROM visitors WHERE EMAIL=:email");
                    $stmt->execute(array(":email" => strtolower($user_email)));
                    $row = $stmt->fetch(PDO::FETCH_ASSOC);
                    $_SESSION['USER_ID'] = $row['USER_ID'];
                    echo "Registered successfully" . print_r($row) . $_SESSION['USER_ID'];
                } else {
                    echo "Query could not execute !";
                }
            } else {
                echo "Existing email";
            }
        } else {
            echo "Emails or passwords do not match!";
        }
    } catch (PDOException $e) {
        echo $e->getMessage();
    }
}
?>
