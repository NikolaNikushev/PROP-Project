<?php
 session_start();
 require_once 'dbconfig.php';

 if(isset($_POST))
 {
  $user_email = trim($_POST['user_email']);
  $user_password = trim($_POST['password']);

  $password = ($user_password);

  try
  {
    //making query to the databese the check if there is such email
   $stmt = $db_con->prepare("SELECT * FROM visitors WHERE EMAIL=:email");
   $stmt->execute(array(":email"=>$user_email));
   $row = $stmt->fetch(PDO::FETCH_ASSOC);
  //  $count = $stmt->rowCount();

   if($row['PASSWORD']==$password && $password !="" ){

    echo "ok-you logged in".print_r ($row);
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
