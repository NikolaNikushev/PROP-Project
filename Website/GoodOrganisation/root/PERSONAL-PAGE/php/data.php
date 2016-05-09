<?php

// if (isset($_SESSION['username']))
// {
  // echo $_SESSION['username'];
  // if (!isset($_SESSION['username'])){
  //     echo "not logged in + we have to make some fancy error shit, that we can display here";
  //   }
    $stmt=$db_con->prepare( 'SELECT v.FNAME, v.LNAME, v.DOB, v.ADDRESS, v.BALANCE, r.STATUS, l.STARTDATE, l.DUEDATE, l.PRICEDAY,l.NAME
                            FROM visitors v, rfids r,loanitems l
                            WHERE v.USER_ID = "1123"
                            AND v.BRACELET_ID = r.BRACELET_ID
                            AND v.USER_ID IN (SELECT USER_ID
                                              FROM loanitems);');


    $stmt->execute();
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
 // }

?>
