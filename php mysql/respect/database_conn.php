<?php

$servername = "localhost";
$username = "root";
$password = "";
$database = "doorstep";
 
/* Attempt to connect to MySQL database */
$conn = mysqli_connect($servername,$username,$password,$database);
 
if(!$conn){
    echo("Database connection failed");
}
?>