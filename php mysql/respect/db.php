<?php

//declare db variables
$server = 'localhost';
$user = 'root';
$pass = '';
$db = 'doorstep';

//conn
$connecn = mysqli_connect($server,$user,$pass,$db);

//test
if($connecn){
	die("connected");
}else{
	echo "no connection";
}
?>