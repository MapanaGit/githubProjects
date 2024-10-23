<?php
//declare database variables
$dbhost='127.0.0.1';
$dbuser = 'root';
$dbpass = '';
$dbname = 'briandb';

$con=mysqli_connect($dbhost,$dbuser,$dbpass) or die(mysqli_error());
mysqli_select_db($dbname);

?>