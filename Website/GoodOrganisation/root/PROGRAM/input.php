<?php
session_start();
require_once 'dbconfig.php';
if($_POST) {
    $job_title = $_POST['job_title'];
    $category = $_POST['category'];
    $area = $_POST['area'];
    $skills = $_POST['skills'];
    $lang = $_POST['lang'];
    $reward = $_POST['reward'];
    $exp = $_POST['exp'];
    $edu = $_POST['edu'];
    
    
    
    
    
    try{
    
    $stmt = $db_con->prepare("INSERT INTO joboffer(job_title,category,area,skills,language,reward,experience,education) VALUES(:jtitle,:cat,:area,:skills,:lang,:reward,:exp,:edu)")
        
         $stmt->bindParam(":jtitle",$job_title);
             $stmt->bindParam(":cat",$category);
             $stmt->bindParam(":area",$area);
             $stmt->bindParam(":skills",$skills);
             $stmt->bindParam(":lang",$lang);
             $stmt->bindParam(":reward",$reward);
             $stmt->bindParam(":exp",$exp);
             $stmt->bindParam(":edu",$edu);
    if($stmt->execute()) {
        echo "Successfully added a new job"
    }
    else{
        echo "Query could not execute";
    }
    }
    catch(PDOException $e){
           echo $e->getMessage();
      }

}