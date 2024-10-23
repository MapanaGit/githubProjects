<?php
include'connection.php';

 $sql="SELECT * FROM guests";
$results=$conn->query($sql);

while($row=$results->fetch_assoc()){
	$data[]=$row;
}
print json_encode($data);
  /**echo"<table><tr><th>Username</th><th>Password</th></tr>";
	while($row=$results->fetch_assoc())
	{
		echo"<tr><td>".$row["Name"] ."</td><td>".$row["Surname"]."</td><td>".$row["Status"]."</td></tr>";
	}
 echo"</table>";	
}
else	
	echo "no results found";*/
$conn->close();	
?>