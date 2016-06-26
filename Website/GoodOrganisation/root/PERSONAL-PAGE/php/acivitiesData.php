<?php
if (isset($_SESSION['USER_ID']))
{
  if (!isset($_SESSION['USER_ID'])){
      echo "not logged in + we have to make some fancy error shit, redirect to error page";
    }
    $activitiesQuery = "SELECT IFNULL(a.ACTIVITYNAME,'NO ACTIVITIES RESERVED') AS 'ACTIVITYNAME', IFNULL(a.DATE,'N/A') AS 'ACTIVITYDATE'
                        FROM visitors v left outer join rfids r
                        ON v.BRACELET_ID = r.BRACELET_ID left outer join activityreservations ar
                        ON v.USER_ID = ar.USER_ID left outer join activities a
                        ON ar.ACTIVITY_ID = a.ACTIVITY_ID
                        WHERE v.USER_ID = :user_id;";

    $activities = array();
    //preparing the query for executing
    $stmt=$db_con->prepare($activitiesQuery);
    $stmt->bindParam(":user_id",$user_id);
      //if the query returns some data on execution
    if($stmt->execute())
    {
       if($stmt->rowCount() > 0){
         // fetch every row that the query returns
         while($row=$stmt->fetch(PDO::FETCH_ASSOC))
          {
            //the 'extract' method give us the possibility to generate a variable corresponding to the name of the row that is fetched
            //that variable is assigned with the relevant value and pushed in an array of activities, which is going to be used for easier displaying of the data
              extract($row);
              array_push($activities,$ACTIVITYNAME,$ACTIVITYDATE);
          }
       }
    }
    //clearing the data from $stmt variable for further use in other queries
    unset($stmt);
}

 ?>
