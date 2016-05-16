<?php
    $persact = array();
    if(isset($_SESSION['USER_ID']))
    {
        $stmt=$db_con->prepare( 'SELECT a.activityname, a.date, a.activity_id
                                FROM activities a join activityReservations ar
                                    on a.activity_id = ar.activity_id
                                WHERE ar.user_id=:user_id;');

        $stmt->execute([
            ':user_id' => $_SESSION['USER_ID']
        ]);
        $persact = array();
        if($stmt->rowCount() > 0){
            while($row=$stmt->fetch(PDO::FETCH_ASSOC))
            {
                extract($row);
            
                array_push($persact,$activityname,$date,$activity_id);
            }
        }
    }
?>