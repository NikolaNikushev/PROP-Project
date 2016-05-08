<?php
// require_once 'dbconfig.php';
// if (isset($_SESSION['username']))
// {
// if (!isset($_SESSION['username']))
// {
//   echo "not logged in";
// }
  $stmt=$db_con->prepare( 'SELECT u.firstname, u.lastname, u.date_of_birth, u.address,u.balance,r.status,i.start_date,i.due_date,i.price_day
                          FROM users u, rfids r,items i
                          WHERE u.user_id = (SELECT user_id
                                             FROM rfids )
                          AND u.user_id IN (SELECT user_id
                                            FROM items);');

  $stmt->execute();
  $items = array();
   if($stmt->rowCount() > 0){
     while($row=$stmt->fetch(PDO::FETCH_ASSOC))
		   {
        extract($row);
        array_push($items,$start_date,$due_date,$price_day);
      }
     $address_array = preg_split("/^([0-9]+ )?[a-zA-Z ]+$/",$address);
    //  print_r($address_array);

   }
// }

?>
