<?php
if (isset($_SESSION['USER_ID']))
{
  if (!isset($_SESSION['USER_ID'])){
      echo "not logged in + we have to make some fancy error shit, redirect to error page";
    }
    $user_id = $_SESSION['USER_ID'];
    $loanItemsQuery = "SELECT v.FNAME, v.LNAME, v.DOB, v.ADDRESS, v.BALANCE, IFNULL(r.STATUS,'NOT ACTIVE') AS 'STATUS', IFNULL(r.BRACELET_ID,'NOT SET') AS 'BRACELET_ID',
                       IFNULL(l.STARTDATE,'N/A') AS 'STARTDATE', IFNULL(l.DUEDATE,'N/A') as 'DUEDATE', IFNULL(l.PRICEDAY,'N/A') AS 'PRICEDAY',IFNULL(l.NAME,'NO ITEMS RESERVED') AS 'ITEMNAME'
                       FROM visitors v left outer join rfids r
                       ON v.BRACELET_ID = r.BRACELET_ID left outer join loanitems l
                       ON l.USER_ID = v.USER_ID
                       WHERE v.USER_ID = :user_id;";

    $stmt=$db_con->prepare($loanItemsQuery);
    $stmt->bindParam(":user_id",$user_id);
    if($stmt->execute())
    {
        $items = array();
         if($stmt->rowCount() > 0){
           while($row=$stmt->fetch(PDO::FETCH_ASSOC))
      		    {
                extract($row);
                array_push($items,$ITEMNAME,$STARTDATE,$DUEDATE,$PRICEDAY);
             }
           $address_array = explode(",",$ADDRESS);
         }
       }
       unset($stmt);
 }

?>
