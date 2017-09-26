<?php
 $db_name = "dbi339282";
 $db_user = "dbi339282";
 $db_pass = "unicornpony"; $db_host="studmysql01.fhict.local";
 try{

 $db_con = new PDO("mysql:host={$db_host};dbname={$db_name}",$db_user,$db_pass);
 $db_con->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
catch(PDOException $e){
 echo $e->getMessage();
}
?>

