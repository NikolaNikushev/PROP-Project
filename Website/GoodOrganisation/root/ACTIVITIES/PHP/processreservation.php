<?php
require "../../default/phpfunc/dbconfig.php";

if($_POST['avplaces'] != 0)
{
    $sql = 'UPDATE activities SET reservedplaces=:reservedplaces WHERE activity_id=:actid';
    $newnr = $_POST['resplaces']+1;
    //echo "<script type='text/javascript'> alert('Congratulations, ".$newnr." you have registered for the event ".$_POST['actid']."!'); </script>";
    $stmt = $db_con->prepare($sql);
$result = $stmt->execute([
        ':reservedplaces' => $newnr,
        ':actid' => $_POST['actid'],
        ]);
echo "<script type='text/javascript'> alert('Congratulations, you have registered for the event ".$_POST['actid']."!'); window.location.replace('../index.php'); </script>";
}
else
{
    
echo "<script type='text/javascript'> alert('Unfortunatelly, no places are left!'); window.location.replace('../index.php'); </script>";
}
?>