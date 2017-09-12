<?php
session_start();
require_once 'dbconfig.php';
if (isset($_SESSION['USER_ID']))
{
  if (!isset($_SESSION['USER_ID'])){
      echo "not logged in + we have to make some fancy error shit, redirect to error page";
    }
    $user_id = $_SESSION['USER_ID'];
   if(isset($_POST))
   {
      $amount = $_POST['amount'];
      $stmt = $db_con->prepare("UPDATE visitors
                                SET BALANCE = BALANCE + :amount
                                WHERE USER_ID = :user_id;");

      $stmt->bindParam(":user_id", $user_id);
      $stmt->bindParam(":amount", $amount);
      if($stmt->execute())
      {
       echo "Successfully updated";
      }
      else{
       echo "Query Problem";
      }
    }
   unset($stmt);
 }
 else echo "error no session varriable user_id ";
?>
