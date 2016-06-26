<?php
//require_once '../../default/phpfunc/dbconfig.php';
$stmt=$db_con->prepare( 'SELECT LPAD(a.activity_id,6,\'0\') as actcode,a.activity_id, a.activityname, 
                                a.description, a.date, 
                                cast((a.totalplaces/2 - IFNULL(av.reservedplaces,0))as UNSIGNED) as availableplaces, 
                                IFNULL(av.reservedplaces,0) as reservedplaces
                          FROM activities a left outer join activityplaces_view av
                                on a.activity_id = av.activity_id;');

    $stmt->execute();
    $activities = array();
    if($stmt->rowCount() > 0){
        while($row=$stmt->fetch(PDO::FETCH_ASSOC))
        {
            extract($row);
            
            array_push($activities,$activityname,$description,$actcode,$activity_id,$availableplaces,$reservedplaces,$date);
        }
    }
   
?>

