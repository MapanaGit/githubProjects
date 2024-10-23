<html>
<title>Home | Integrated System</title>
<style>
/* Full-width input fields */
input[type=text], input[type=password], input[type=submit],
select[name=gender] {
  width: 50%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}
</style>
<div class="containe1" style="width:150px; height:500px; float:left; 
background-color:none;">
cont 1
</div>
<div class="container2" style="width:763px; height:500px; float:left; 
background-color:wheat;">
<h1 style="text-align:center;">INTEGRATED SYSTEM<h1><br />
<form action="index.php" method="post" style="text-align:center">
<label for="username">Username</label><br>
<input type="text" name="username" id="username" placeholder="username" required><br>

<label for="password">Password</label><br>
<input type="password" name="password" id="password" placeholder="password" required><br>
<input type="submit" name="submit" value="Login"><br>
<p>Login as <a href="index1.php">admin</a> or <a href="index.php">staff</a></p>
</form>
</div>
<div class="container3" style="width:150px; height:500px; float:right; 
background-color:none;">
cont 3
</div>
</html>