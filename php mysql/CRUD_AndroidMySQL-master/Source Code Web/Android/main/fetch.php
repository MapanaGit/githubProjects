<?php

	//get user Id
	$id = $_GET['id'];

	//Importing database
	require_once('connection.php');

	//select a member by ID
	$sql = "SELECT * FROM users WHERE id=$id";

	//read sql query
	$r = mysqli_query($con,$sql);

	//fetch row
	$result = array();
	$row = mysqli_fetch_array($r);
	array_push($result,array(
			"id"=>$row['id'],
			"name"=>$row['name'],
			"location"=>$row['location'],
			"email"=>$row['email'],
			"phone"=>$row['phone']
		));

	
	echo json_encode(array('result'=>$result));

	mysqli_close($con);
?>
