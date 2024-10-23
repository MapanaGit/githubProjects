<?php

include "db.php";

if(isset($_POST['submit'])){
        //sanitise the records
    $student_id = $_REQUEST['student_id'];
    $student_name =  $_REQUEST['student_name'];
    $surname = $_REQUEST['surname'];
    $address = $_REQUEST['address'];
      $gender = $_REQUEST['gender'];
  $phone = $_REQUEST['phone'];
    $age = $_REQUEST['age'];
   $email = $_REQUEST['email'];
   $password = $_REQUEST['password'];
   //insert data
    $sql = "INSERT INTO student VALUES ('$student_id','$student_name','$surname',
    '$address','$gender','$phone','$age','$email','$password')";
     //if the insert statement works, return a success message
    if(mysqli_query($con, $sql)){
        echo "<script>alert('student has registered successfully')</script>";
       
    } 
    //or else return an error message
    else{
        echo "<script>alert('student registration failed')</script>";
            
    }
}
//or else tell the user to restart the process
else{
    echo"<script>alert('Error. Please restart the process')</script>";
}


?>
<!DOCTYPE html>
<!-- Coding by CodingLab || www.codinglabweb.com -->
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Website with Login & Registration Form</title>
    <link rel="stylesheet" href="style.css" />
    <!-- Unicons -->
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css" />
<style>
  body{
    background-color:none;
  }
  /* Full-width input fields */
input[type=text], input[type=password], input[type=email], input[type=number], select[name=phone],
select[name=gender] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}
</style>
  </head>
  <body>
    <!-- Header -->
    <header class="header">
      <nav class="nav">
        <a href="#" class="nav_logo"> </a>

        <ul class="nav_items">
          <li class="nav_item">
            <a href="#" class="nav_link">Home</a>
            <a href="#" class="nav_link">Product</a>
            <a href="#" class="nav_link">Services</a>
            <a href="#" class="nav_link">Contact</a>
          </li>
        </ul>

        <button class="button" id="form-open">Login</button>
      </nav>
    </header>

    <!-- Home -->
    <section class="home">
      <div class="form_container">
        <i class="uil uil-times form_close"></i>
       
        <div class="our-form">
            <form action="register.php" name="register" 
            method="post">
        <p>Create an account below</p>
        <label for="student_id">Student Id</label>
        <input type="number" name="student_id" id="student_id"
         placeholder="enter student Id" max-length="13">
         <br>
         <label for="student_name">Name</label>
         <input type="text" name="student_name" id="student_name" placeholder
         ="enter your name" max-length="50"><br>

         <label for="surname">Surname</label>
         <input type="text" name="surname" id="surname"
         placeholder="enter your surname" max-length="50">
         <br>

         <label for="address">Address</label>
         <input type="text" name="address" id="address"
          placeholder="enter your address" max-length="255">
          <br>
		  
		   <label for="gender"><b>--select gender--</b></label><br>
    <select name="gender" id="gender">
      <option value="female">Female</option>
      <option value="male">Male</option>
    </select>
	
	<label for="phone">Phone</label>
    <input type="number" name="phone" id="phone" placeholder=
    "enter your phone" max-length="15">
	
	<label for="age">Age</label>
    <input type="number" name="age" id="age" placeholder=
    "enter your age" max-length="3">
	
	<label for="email">Email</label>
    <input type="email" name="email" id="email" placeholder=
    "enter your email address" max-length="100">
	
	<label for="password">Password</label>
    <input type="password" name="password" id="password" placeholder=
    "enter your password" max-length="20">

    <input type="submit" name="submit" value="save">

        </form>
        </div>



        <!-- Signup From -->
        <div class="form signup_form">
          <form action="#">
            <h2>Signup</h2>

            <div class="input_box">
              <input type="email" placeholder="Enter your email" required />
              <i class="uil uil-envelope-alt email"></i>
            </div>
            <div class="input_box">
              <input type="password" placeholder="Create password" required />
              <i class="uil uil-lock password"></i>
              <i class="uil uil-eye-slash pw_hide"></i>
            </div>
            <div class="input_box">
              <input type="password" placeholder="Confirm password" required />
              <i class="uil uil-lock password"></i>
              <i class="uil uil-eye-slash pw_hide"></i>
            </div>

            <button class="button">Signup Now</button>

            <div class="login_signup">Already have an account? <a href="#" id="login">Login</a></div>
          </form>
        </div>
      </div>
    </section>

    <script src="script.js"></script>
  </body>
</html>
