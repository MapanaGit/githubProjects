<?php
  
   session_start();
     $conn = mysqli_connect("localhost", "root", "", "librarysystem");
         
        // Check connection
        if($conn === false){
            die("ERROR: Could not connect. "
                . mysqli_connect_error());
        }
         
   if($_SERVER["REQUEST_METHOD"] == "POST") {
      // username and password sent from form 
      
      $email = mysqli_real_escape_string($conn,$_POST['email']);
      $password = mysqli_real_escape_string($conn,$_POST['password']); 
      
      $sql = "SELECT * FROM student WHERE email = '$email' and password = '$password'";
      $result = mysqli_query($conn,$sql);
      $row = mysqli_fetch_array($result,MYSQLI_ASSOC);
      
      
      $count = mysqli_num_rows($result);
      
      // If result matched $myusername and $mypassword, table row must be 1 row
		
      if($count == 1) {
         
         $_SESSION['email'] = $email;
         header("location: studentmodal.php");
         
      }else {
         echo"<script>alert('You have entered wrong username/password. Please try again!')</script>";
      }
   }
?>
<!DOCTYPE html>

<!--
 // WEBSITE: https://themefisher.com
 // TWITTER: https://twitter.com/themefisher
 // FACEBOOK: https://www.facebook.com/themefisher
 // GITHUB: https://github.com/themefisher/
-->

<html lang="en">
<head>

  <!-- Basic Page Needs
	================================================== -->
  <meta charset="utf-8">
  <title>User Login Modal | Mylibcenter</title>

  <!-- Mobile Specific Metas
	================================================== -->
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="description" content="Construction Html5 Template">
  <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=5.0">
  <meta name="author" content="Themefisher">
  <meta name="generator" content="Themefisher Educenter HTML Template v1.0">
  
  <!-- theme meta -->
  <meta name="theme-name" content="educenter" />

  <!-- ** Plugins Needed for the Project ** -->
  <!-- Bootstrap -->
  <link rel="stylesheet" href="plugins/bootstrap/bootstrap.min.css">
  <!-- slick slider -->
  <link rel="stylesheet" href="plugins/slick/slick.css">
  <!-- themefy-icon -->
  <link rel="stylesheet" href="plugins/themify-icons/themify-icons.css">
  <!-- animation css -->
  <link rel="stylesheet" href="plugins/animate/animate.css">
  <!-- aos -->
  <link rel="stylesheet" href="plugins/aos/aos.css">
  <!-- venobox popup -->
  <link rel="stylesheet" href="plugins/venobox/venobox.css">

  <!-- Main Stylesheet -->
  <link href="css/style.css" rel="stylesheet">

  <!--Favicon-->
  <link rel="shortcut icon" href="images/mylogocenter.png" type="image/x-icon">
  <link rel="icon" href="images/mylogocenter.png" type="image/x-icon">

</head>

<body>
  <!-- preloader start -->
  <div class="preloader">
    <img src="images/preloader.gif" alt="preloader">
  </div>
  <!-- preloader end -->

<!-- header -->
<header class="fixed-top header">
  <!-- top header -->
  <div class="top-header py-2 bg-white">
    <div class="container">
      <div class="row no-gutters">
        <div class="col-lg-4 text-center text-lg-left">
          <a class="text-color mr-3" href="tel:+443003030266"><strong>CALL</strong> 0795988633</a>
          <ul class="list-inline d-inline">
            <li class="list-inline-item mx-0"><a class="d-inline-block p-2 text-color" href="https://facebook.com/themefisher/"><i class="ti-facebook"></i></a></li>
            <li class="list-inline-item mx-0"><a class="d-inline-block p-2 text-color" href="https://twitter.com/themefisher"><i class="ti-twitter-alt"></i></a></li>
            <li class="list-inline-item mx-0"><a class="d-inline-block p-2 text-color" href="https://github.com/themefisher"><i class="ti-github"></i></a></li>
            <li class="list-inline-item mx-0"><a class="d-inline-block p-2 text-color" href="https://instagram.com/themefisher/"><i class="ti-instagram"></i></a></li>
          </ul>
        </div>
        <div class="col-lg-8 text-center text-lg-right">
        <ul class="list-inline">
            
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- navbar -->
  <div class="navigation w-100">
    <div class="container">
      <nav class="navbar navbar-expand-lg navbar-dark p-0">
        <a class="navbar-brand" href="userlogin.php"><img src="images/mylogocenter.png" alt="logo"></a>
        <button class="navbar-toggler rounded-0" type="button" data-toggle="collapse" data-target="#navigation"
          aria-controls="navigation" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navigation">
         
          <ul class="navbar-nav ml-auto text-center">
            <li class="nav-item active">
              <a class="nav-link" href="index.php">Home</a>
            </li>
            </ul>
          
        </div>
      </nav>
    </div>
  </div>
</header>
<!-- /header -->
<!-- page title -->
<section class="page-title-section overlay" data-background="images/backgrounds/page-title.jpg">
  <div class="container">
    <div class="row">
      <div class="col-md-8">
        <ul class="list-inline custom-breadcrumb mb-2">
          <li class="list-inline-item"><a class="h2 text-primary font-secondary" href="index.php">Home</a></li>
          <li class="list-inline-item text-white h3 font-secondary nasted">Login</li>
        </ul>
        <p class="text-lighten mb-0">Please supply valid login credentials to gain access to Mylibcenter</p>
      </div>
    </div>
  </div>
</section>
<!-- /page title -->
<!-- success story -->
<section class="section bg-cover" data-background="images/backgrounds/success-story.jpg">
  <div class="container">
    <div class="row">
      <div class="col-lg-6 col-sm-4 position-relative success-video">
        
      </div>
      <div class="col-lg-6 col-sm-8">
        <div class="bg-white p-5">
          <h2 class="section-title">User login</h2>
        <form action="userlogin.php" method="post" class="row" name="login" onsubmit="return(validate());">
                       
                        <div class="col-12">
                            <input type="email" class="form-control mb-3" id="email" name="email" placeholder="enter your email">
                        </div>
                        <div class="col-12">
                            <input type="password" class="form-control mb-3" id="password" name="password" placeholder="enter your password">
                        </div>
                       
                        <div class="col-12">
                            <button type="submit" name="submit" id="submit" value="submit" class="btn btn-primary">Login</button><br /><br />
                            Don't have an account? click <a href="student.php">here</a> to register
                        </div>
                    </form>
        </div>
      </div>
    </div>
  </div>
</section>
<!-- /success story -->

<!-- footer -->
<footer>
  
    <!-- footer content -->
    <div class="footer bg-footer section border-bottom">
    <div class="container">
      <div class="row">
        <div class="col-lg-4 col-sm-8 mb-5 mb-lg-0">
          <!-- logo -->
          <a class="logo-footer" href="index.html"><img class="img-fluid mb-4" src="images/mylogocenter.png" alt="logo"></a>
          <ul class="list-unstyled">
            <li class="mb-2">Numbi Road, Ehlanzeni TVET College, Mthimba Campus</li>
            <li class="mb-2">0795988633</li>
            <li class="mb-2">015 962 5587</li>
            <li class="mb-2">info@mylibcenter.co.za</li>
          </ul>
        </div>
        <!-- company -->
        <div class="col-lg-2 col-md-3 col-sm-4 col-6 mb-5 mb-md-0">
          <h4 class="text-white mb-5">COMPANY</h4>
          <ul class="list-unstyled">
            <li class="mb-3"><a class="text-color" href="#">About Us</a></li>
            <li class="mb-3"><a class="text-color" href="#">Our Books</a></li>
            <li class="mb-3"><a class="text-color" href="contact.php">Contact</a></li>
            <li class="mb-3"><a class="text-color" href="#">Blog</a></li>
          </ul>
        </div>
        <!-- links -->
        <div class="col-lg-2 col-md-3 col-sm-4 col-6 mb-5 mb-md-0">
          <h4 class="text-white mb-5">LINKS</h4>
          <ul class="list-unstyled">
            <li class="mb-3"><a class="text-color" href="unisa.ac.za">UNISA</a></li>
            <li class="mb-3"><a class="text-color" href="univen.ac.za">University of Venda</a></li>
            <li class="mb-3"><a class="text-color" href="nsfas.ac.za">NSFAS</a></li>
            <li class="mb-3"><a class="text-color" href="ump.ac.za">University of Mpumalanga</a></li>
          </ul>
        </div>
        <!-- support -->
        <div class="col-lg-2 col-md-3 col-sm-4 col-6 mb-5 mb-md-0">
          <h4 class="text-white mb-5">VACANCIES</h4>
          <ul class="list-unstyled">
            <li class="mb-3"><a class="text-color" href="#">Learnership</a></li>
            <li class="mb-3"><a class="text-color" href="#">Internship</a></li>
            <li class="mb-3"><a class="text-color" href="#">Inservice Training</a></li>
            <li class="mb-3"><a class="text-color" href="#">Vacancy</a></li>
          </ul>
        </div>
        <!-- support -->
        <div class="col-lg-2 col-md-3 col-sm-4 col-6 mb-5 mb-md-0">
          <h4 class="text-white mb-5">DEVELOPER INFO</h4>
          <ul class="list-unstyled">
            <li class="mb-3"><a class="text-color" href="#">(+27)79 598 8633</a></li>
            <li class="mb-3"><a class="text-color" href="mailto:minabrian12@gmail.com">minabrian12@gmail.com</a></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- copyright -->
  <div class="copyright py-4 bg-footer">
    <div class="container">
      <div class="row">
        <div class="col-sm-7 text-sm-left text-center">
          <p class="mb-0">Copyright &copy;
            <script>
              var CurrentYear = new Date().getFullYear()
              document.write(CurrentYear)
            </script> 
            , designed & developed by <a href="mailto:minabrian12@gmail.com">Mkasi MB</a>
          </p>
        </div>
        <div class="col-sm-5 text-sm-right text-center">
          <ul class="list-inline">
            <li class="list-inline-item"><a class="d-inline-block p-2" href="https://facebook.com/themefisher/"><i class="ti-facebook text-primary"></i></a></li>
            <li class="list-inline-item"><a class="d-inline-block p-2" href="https://twitter.com/themefisher"><i class="ti-twitter-alt text-primary"></i></a></li>
            <li class="list-inline-item"><a class="d-inline-block p-2" href="https://github.com/themefisher"><i class="ti-github text-primary"></i></a></li>
            <li class="list-inline-item"><a class="d-inline-block p-2" href="https://instagram.com/themefisher/"><i class="ti-instagram text-primary"></i></a></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</footer>
<!-- /footer -->

<!-- jQuery -->
<script src="plugins/jQuery/jquery.min.js"></script>
<!-- Bootstrap JS -->
<script src="plugins/bootstrap/bootstrap.min.js"></script>
<!-- slick slider -->
<script src="plugins/slick/slick.min.js"></script>
<!-- aos -->
<script src="plugins/aos/aos.js"></script>
<!-- venobox popup -->
<script src="plugins/venobox/venobox.min.js"></script>
<!-- filter -->
<script src="plugins/filterizr/jquery.filterizr.min.js"></script>
<!-- google map -->
<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCcABaamniA6OL5YvYSpB3pFMNrXwXnLwU"></script>
<script src="plugins/google-map/gmap.js"></script>

<!-- Main Script -->
<script src="js/script.js"></script>

</body>
</html>
