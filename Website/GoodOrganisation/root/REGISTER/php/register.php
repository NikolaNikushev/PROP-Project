<?php
session_start();
 require_once 'dbconfig.php';
 // require_once 'login.php';
 if($_POST)
 {
    $first_name = $_POST['first_name'];
    $last_name = $_POST['last_name'];
    $date_of_birth = $_POST['date_of_birth'];
    $user_password = $_POST['password'];
    $user_email = $_POST['user_email'];
    $user_address = $_POST['sba'].','.$_POST['city'].','.$_POST['country'].','.$_POST['zip'];
    $joining_date = date('Y-m-d H:i:s');

    try
    {
       $stmt = $db_con->prepare("SELECT * FROM visitors WHERE EMAIL=:email");
       $stmt->execute(array(":email"=>$user_email));
       $count = $stmt->rowCount();
       if($count==0){

             $stmt = $db_con->prepare("INSERT INTO visitors(FNAME,LNAME,EMAIL,PASSWORD,ADDRESS,DOB,REGDATE) VALUES(:fname,:lname,:email, :pass,:uaddress,:dob,:jdate)");

             $stmt->bindParam(":fname",$first_name);
             $stmt->bindParam(":lname",$last_name);
             $stmt->bindParam(":pass",$password);
             $stmt->bindParam(":dob",$date_of_birth);
             $stmt->bindParam(":jdate",$joining_date);
             $stmt->bindParam(":email",$user_email);
             $stmt->bindParam(":pass",$user_password);
             $stmt->bindParam(":uaddress",$user_address);

              if($stmt->execute())
              {
                  $stmt = $db_con->prepare("SELECT * FROM visitors WHERE EMAIL=:email");

                  $stmt->execute(array(":email"=>$user_email));
                  $row = $stmt->fetch(PDO::FETCH_ASSOC);

                  // $stmt = $db_con->prepare("INSERT INTO rfids(STATUS,BRACELET_ID) VALUES('DEACTIVATED','NULL')");
                  // $stmt = $db_con->prepare("SELECT USER_ID FROM visitors v WHERE USER_ID=:user_id");
                  // $stmt->bindParam(":user_id",$_SESSION['USER_ID']);
                  // $stmt->execute();
                  // $user_row = $stmt->fetch(PDO::FETCH_ASSOC);
                  $_SESSION['USER_ID'] = $row['USER_ID'];
                   echo "Registered successfully".print_r($row).$_SESSION['USER_ID'];

              }
              else{
                 echo "Query could not execute !";
              }

             }
       else{
              echo "Existing email"; //  not available
       }

      }
      catch(PDOException $e){
           echo $e->getMessage();
      }
   }


?>
