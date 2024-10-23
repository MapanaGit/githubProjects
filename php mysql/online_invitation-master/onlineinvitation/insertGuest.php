<?php

include'connection.php';
$data=json_decode(file_get_contents("php://input"));
$name=($data->Name);
$surname=($data->Surname);
$status=($data->Status);

$sql="INSERT INTO `guests`(`Id`, `Name`, `Surname`,`Status`) VALUES ('sizweNxele20100','".$name."','".$surname."','".$status."')";

if($conn->query($sql)===true){

}else{
echo "failed";
}
?>