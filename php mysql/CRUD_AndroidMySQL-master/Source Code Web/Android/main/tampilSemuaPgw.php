<?php


	//Import File connection.php
	require_once('connection.php');

	//select data
	$sql = "SELECT * FROM users";

	//read data
	$r = mysqli_query($con,$sql);

	$result = array();

	while($row = mysqli_fetch_array($r)){

		//read Id and name using array
		array_push($result,array(
			"id"=>$row['id'],
			"name"=>$row['name']
		));
	}

	echo json_encode(array('result'=>$result));

	mysqli_close($con);
?>
