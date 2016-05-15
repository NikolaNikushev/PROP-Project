
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
    $stmt=$db_con->prepare($activitiesQuery);
    $stmt->bindParam(":user_id",$user_id);
    if($stmt->execute())
    {
       if($stmt->rowCount() > 0){
         while($row=$stmt->fetch(PDO::FETCH_ASSOC))
          {
              extract($row);
              array_push($activities,$ACTIVITYNAME,$ACTIVITYDATE);
          }
       }
    }
}

 ?>
