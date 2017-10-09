<?php
 session_start();
 require_once 'dbconfig.php';

 if(isset($_POST))
 {
  $user_email = ($_POST['user_email']);
  $user_password = ($_POST['password']);

  $password = ($user_password);

  try
  {

   $stmt = $db_con->prepare("SELECT * FROM visitors WHERE EMAIL='$user_email' AND PASSWORD='$user_password'");
   $stmt->execute();
   $row = $stmt->fetch(PDO::FETCH_ASSOC);
   $count = $stmt->rowCount();

   if($count >= 1){

    echo "ok-you logged in".print_r ($row);
	   if ( (session_id() == ''))  session_start();

	   $_SESSION["USER_ID"] = $row['USER_ID'];
   }
   else{

    echo "email or password does not exist.";
   }

  }
  catch(PDOException $e){
   echo $e->getMessage();
  }
 }

?>
