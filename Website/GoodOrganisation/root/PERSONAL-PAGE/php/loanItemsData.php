<?php
if (isset($_SESSION['USER_ID']))
{
  if (!isset($_SESSION['USER_ID'])){
      echo "not logged in , redirect to error page";
    }
    //getting the user id of the current user which is used further in validating the queries to the databases
    $user_id = $_SESSION['USER_ID'];
    $loanItemsQuery = "SELECT v.FNAME, v.LNAME, v.DOB, v.ADDRESS, v.PAID, v.BALANCE, IFNULL(r.STATUS,'NOT ACTIVE') AS 'STATUS', IFNULL(r.BRACELET_ID,'NOT SET') AS 'BRACELET_ID',
                       IFNULL(l.STARTDATE,'N/A') AS 'STARTDATE', IFNULL(l.DUEDATE,'N/A') as 'DUEDATE', IFNULL(l.PRICEDAY,'N/A') AS 'PRICEDAY',IFNULL(l.NAME,'NO ITEMS RESERVED') AS 'ITEMNAME'
                       FROM visitors v left outer join rfids r
                       ON v.BRACELET_ID = r.BRACELET_ID left outer join loanitems l
                       ON l.USER_ID = v.USER_ID
                       WHERE v.USER_ID = :user_id;";

    $stmt=$db_con->prepare($loanItemsQuery);
    $stmt->bindParam(":user_id",$user_id);
    //if the query returns some data on execution
    if($stmt->execute())
    {
        $items = array();
         if($stmt->rowCount() > 0){
           while($row=$stmt->fetch(PDO::FETCH_ASSOC))
      		    {
                //the 'extract' method give us the possibility to generate a variable corresponding to the name of the row that is fetched
                //that variable is assigned with the relevant value and pushed in an array of items, which is going to be used for easier displaying of the data
                extract($row);
                array_push($items,$ITEMNAME,$STARTDATE,$DUEDATE,$PRICEDAY);
             }
             // splits the address string by ',' and pushes it into array which is going to be used for displaying further on
           $address_array = explode(",",$ADDRESS);
         }
       }
       //clearing the data from $stmt variable for further use in other queries
       unset($stmt);
 }

?>
