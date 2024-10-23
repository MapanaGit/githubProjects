<?php

//insert records

	if($_SERVER['REQUEST_METHOD']=='POST'){

		$name = $_POST['name'];
		$location = $_POST['location'];
		$email = $_POST['email'];
		$phone = $_POST['phone'];

		//insert data
		$sql = "INSERT INTO users (name,location,email,phone) VALUES ('$name','$location'
		,'$email','$phone')";

		//import connection.php file
		require_once('connection.php');

		//print success or error message
		if(mysqli_query($con,$sql)){
			echo 'Record saved';
		}else{
			echo 'Record not saved';
		}

		mysqli_close($con);
	}
?>
