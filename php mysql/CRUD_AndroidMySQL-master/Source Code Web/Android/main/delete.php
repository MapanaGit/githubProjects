<?php

 

 //get user ID
 $id = $_GET['id'];

 //Import File connection database
 require_once('connection.php');

 //delete SQL Query
 $sql = "DELETE FROM users WHERE id=$id;";


 //if query successful, delete record
 if(mysqli_query($con,$sql)){
 echo 'Record deleted';
 }else{
 echo 'Record not deleted';
 }

 mysqli_close($con);
 ?>
