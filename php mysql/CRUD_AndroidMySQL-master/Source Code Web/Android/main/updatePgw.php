<?php

	if($_SERVER['REQUEST_METHOD']=='POST'){
		
		$id = $_POST['id'];
		$name = $_POST['name'];
		$location = $_POST['location'];
		$email = $_POST['email'];
		$phone = $_POST['phone'];

		//import file connection.php
		require_once('connection.php');

		//update record
		$sql = "UPDATE users SET name = '$name', location = '$location', email = '$email', 
phone = '$phone' WHERE id = $id;";

		//Meng-update Database
		if(mysqli_query($con,$sql)){
			echo 'Record updated';
		}else{
			echo 'Record not updated';
		}

		mysqli_close($con);
	}
?>
