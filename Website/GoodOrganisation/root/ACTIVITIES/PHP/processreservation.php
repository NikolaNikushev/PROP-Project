<?php
session_start();
require "../../default/phpfunc/dbconfig.php";

if(isset($_SESSION['USER_ID']))
{
    if($_POST['avplaces'] != 0)
    {
//        $sql = 'UPDATE activities SET reservedplaces=:reservedplaces WHERE activity_id=:actid';
//        $newnr = $_POST['resplaces']+1;
//        //echo "<script type='text/javascript'> alert('Congratulations, ".$newnr." you have registered for the event ".$_POST['actid']."!'); </script>";
//        $stmt = $db_con->prepare($sql);
//        $result = $stmt->execute([
//            ':reservedplaces' => $newnr,
//            ':actid' => $_POST['actid'],
//            ]);

        $sql = 'INSERT INTO activityreservations (ACTIVITY_ID, USER_ID) VALUES (:actid, :userId);';
        $stmt = $db_con->prepare($sql);
        try{
            $result = $stmt->execute([
            ':actid' => $_POST['actid'],
            ':userId' => $_SESSION['USER_ID'], //later to be replaced with $_SESSION['USER_ID']
            ]);

            echo "<script type='text/javascript'> alert('Congratulations, you have registered for the event ".$_POST['actid']."!'); window.location.replace('../index.php'); </script>";
        } catch (Exception $ex) {
           echo "<script type='text/javascript'> alert('You appear to have already been registered'); window.location.replace('../index.php'); </script>";
        }
    }
    else
    {

    echo "<script type='text/javascript'> alert('Unfortunatelly, no places are left!'); window.location.replace('../index.php'); </script>";
    }  
}
else
{

    echo "<script type='text/javascript'> alert('Please, register or login at first'); window.location.replace('../index.php'); </script>";
}  
    
?>