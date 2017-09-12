<?php
    session_start();
    require "../../default/phpfunc/dbconfig.php";

if(isset($_SESSION['USER_ID']))
{
        $stmt=$db_con->prepare( 'DELETE 
                                FROM activityreservations 
                                WHERE ACTIVITY_ID = :actid 
                                AND USER_ID=:userId;');

        try{
            $result = $stmt->execute([
            ':actid' => $_POST['actid'],
            ':userId' => $_SESSION['USER_ID'], //later to be replaced with $_SESSION['USER_ID']
            ]);

            echo "<script type='text/javascript'> alert('Alright, thank you for canceling your reservation for the activity #".$_POST['actid']." early!'); window.location.replace('../index.php'); </script>";
        } catch (Exception $ex) {
            $mes = $ex->getMessage();
           echo $mes;
        }
}
else
{
    echo $_SESSION['USER_ID'];
    echo 'something went wrong';
}

    
    ?>

