<?php
//declare database variables
$dbhost = '127.0.0.1';
$dbuser = 'root';
$pass = '';
$dbname = 'student_registration';
//initialise connection
$con = mysqli_connect($dbhost,$dbuser,$pass,$dbname);
//test db connection
// if else
if($con!=$con){
	die("<script>alert('Database not connected')</script>");
}else{
	echo"<script>alert('Database connected successfully')</script>";
}
?>