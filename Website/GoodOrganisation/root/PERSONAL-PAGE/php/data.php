<?php
// session_start();
if (isset($_SESSION['USER_ID']))
{
  if (!isset($_SESSION['USER_ID'])){
      echo "not logged in + we have to make some fancy error shit, redirect to error page";
    }
    $user_id = $_SESSION['USER_ID'];
    $query = "SELECT v.FNAME, v.LNAME, v.DOB, v.ADDRESS, v.BALANCE, IFNULL(r.STATUS,'N/A') AS 'STATUS', IFNULL(l.STARTDATE,'N/A') AS 'STARTDATE', IFNULL(l.DUEDATE,'N/A') as 'DUEDATE', IFNULL(l.PRICEDAY,'N/A') AS 'PRICEDAY',IFNULL(l.NAME,'N/A') AS 'NAME'
                            FROM visitors v left outer join rfids r
                            ON v.BRACELET_ID = r.BRACELET_ID left outer join loanitems l
                            ON (l.USER_ID = v.USER_ID)
                            WHERE
                            v.USER_ID = :user_id ;";

    $siteRegisterQuery = "SELECT v.FNAME, v.LNAME, v.DOB, v.ADDRESS
                            FROM visitors v
                            WHERE v.USER_ID = :user_id;";





// if some of the variables is not assigned make a new query
    $stmt=$db_con->prepare($query);
    $stmt->bindParam(":user_id",$user_id);
    if($stmt->execute())
    {

        $items = array();
         if($stmt->rowCount() > 0){
           while($row=$stmt->fetch(PDO::FETCH_ASSOC))
      		   {

              extract($row);

              array_push($items,$NAME,$STARTDATE,$DUEDATE,$PRICEDAY);
            }

           $address_array = explode(",",$ADDRESS);
          // print_r($address_array);

         }
        //  else {
         //
        //    $stmt=$db_con->prepare($siteRegisterQuery);
        //    $stmt->bindParam(":user_id",$user_id);
        //    $stmt->execute();
        //    $row=$stmt->fetch(PDO::FETCH_ASSOC);
        //    extract($row);
        //    $NAME ='NO ITEMS ARE BORROWED';
        //    $STARTDATE ='N/A';
        //    $DUEDATE= 'N/A';
        //    $PRICEDAY ='N/A';
        //    $STATUS  ='DEACTIVATED';
        //    $BALANCE = 0;
        //    array_push($items,$NAME,$STARTDATE,$DUEDATE,$PRICEDAY);
        //    $address_array = explode(",",$ADDRESS);
        //  }
     }

 }

?>
