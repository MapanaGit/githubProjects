<?php

session_start();
 
        $conn = mysqli_connect("localhost", "root", "", "doctordb");
        // Check connection
        if($conn === false){
            die("ERROR: Could not connect. "
                . mysqli_connect_error());
        }
     if(isset($_POST['submit'])){
        $client_id =  $_REQUEST['client_id'];
        $name = $_REQUEST['name'];
        $surname =  $_REQUEST['surname'];
        $gender =  $_REQUEST['gender'];
        $phone =  $_REQUEST['phone'];
        $email =  $_REQUEST['email'];
        $password =  $_REQUEST['password'];
               
        // Performing insert query execution
        
        $sql = "INSERT INTO client VALUES ('$client_id','$name','$surname','$gender','$phone',
        '$email','$password')";
         
        if(mysqli_query($conn, $sql)){
            echo "<script>alert('1 record affected')</script>";
           
        } else{
            echo "<script>alert('could not add course. please try again!')</script>";
                
        }
     }
         
        // Close connection
        mysqli_close($conn);
    session_destroy();
 ?>
<html>
    <form action="register.php" method="post">
        <label for="client_id">Client Id</label>
        <input type="number" name="client_id" 
        id="client_id" placeholder="client Id"><br>

        <label for="name">Name</label>
        <input type="text" name="name" id="name"
        placeholder="your name"><br>

        <label for="surname">Surname</label>
        <input type="text" name="surname" id="surname"
        placeholder="surname"><br>

        <div class="col-12"> 
        <select name="gender" id="gender" 
        class="form-control">
          <option Disabled selected>
            --select your gender--</option>
          <option value="male">Male</option>
          <option value="female">
            Female</option>
        </select><br>
        </div>

        <label for="phone">Phone</label>
        <input type="number" name="phone" id="phone"
        placeholder="your cell number"><br>

        <label for="email">Email<label>
        <input type="email" name="email" id="email"
        placeholder="your email"><br>

        <label for="password">Password</label>
        <input type="password" id="password" 
        name="password" placeholder="your password"><br>

        <input type="submit" name="submit" value="save">

    </form>
</html>