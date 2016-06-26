<?php
if (isset($_SESSION['USER_ID']))
{
  if (!isset($_SESSION['USER_ID'])){
      echo "not logged in + we have to make some fancy error shit, redirect to error page";
    }

        $campQuery = "SELECT IFNULL(c.TENTNR,'No tipi reserved') AS 'TENTNR', IFNULL(t.FNAME,'No') AS 'CHIEFFNAME',IFNULL(t.LNAME,'Chief') AS 'CHIEFLNAME'
                      FROM visitors v left outer join rfids r
                      ON v.BRACELET_ID = r.BRACELET_ID left outer join camps c
                      ON v.CAMPING_ID = c.CAMPING_ID left outer join tentleadersextra_view t
                      ON c.CAMPING_ID = t.CAMPING_ID
                      WHERE v.USER_ID = :user_id";

        $stmt=$db_con->prepare($campQuery);
        $stmt->bindParam(":user_id",$user_id);
          //if the query returns some data on execution
        if($stmt->execute())
        {
           if($stmt->rowCount() > 0){
             while($row=$stmt->fetch(PDO::FETCH_ASSOC))
               {
                 //the 'extract' method give us the possibility to generate a variable corresponding to the name of the row that is fetched
                 //later these variable are used in the html to diplay the retrieved data
                 extract($row);
               }
           }
         }
         //clearing the data from $stmt variable for further use in other queries
       unset($stmt);
}
?>
