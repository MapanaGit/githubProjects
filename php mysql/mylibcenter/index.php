<?php

session_start();
 
        $conn = mysqli_connect("localhost", "root", "", "librarysystem");
        // Check connection
        if($conn === false){
            die("ERROR: Could not connect. "
                . mysqli_connect_error());
        }
     if(isset($_POST['submit'])){
        $email =  $_REQUEST['email'];
             
        // Performing insert query execution
        
        $sql = "INSERT INTO newsletter VALUES (null,'$email')";
         
        if(mysqli_query($conn, $sql)){
            echo "<script>alert('You have subscribed to our newsletter')</script>";
           
        } else{
            echo "<script>alert('Please enter your email')</script>";
                
        }
     }
         
        // Close connection
        mysqli_close($conn);
    session_destroy();
 
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
  <title>Home | Mylibcenter</title>

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
            <li class="list-inline-item"><a class="text-uppercase text-color p-sm-2 py-2 px-0 d-inline-block" href="login.php">Admin Login</a></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- navbar -->
  <div class="navigation w-100">
    <div class="container">
      <nav class="navbar navbar-expand-lg navbar-dark p-0">
        <a class="navbar-brand" href="index.php"><img src="images/mylogocenter.png" alt="logo"></a>
        <button class="navbar-toggler rounded-0" type="button" data-toggle="collapse" data-target="#navigation"
          aria-controls="navigation" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navigation">
        <ul class="navbar-nav ml-auto text-center">
            <li class="nav-item active">
              <a class="nav-link" href="login.php">Admin Login</a>
            </li>
            <li class="nav-item @@about">
              <a class="nav-link" href="userlogin.php">Student Login</a>
            </li>
            </ul>
        </div>
      </nav>
    </div>
  </div>
</header>
<!-- /header -->
<!-- hero slider -->
<section class="hero-section overlay bg-cover" data-background="images/banner/banner-1.jpg">
  <div class="container">
    <div class="hero-slider">
      <!-- slider item -->
      <div class="hero-slider-item">
        <div class="row">
          <div class="col-md-8">
            <h1 class="text-white" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".1">Your bright future is our mission</h1>
            <p class="text-muted mb-4" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".4">This system enable admin / librarian to add new books in the system
              , update book data and delete books in the database.
              </p>
            <a href="contact.html" class="btn btn-primary" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".7">Apply now</a>
          </div>
        </div>
      </div>
      <!-- slider item -->
      <div class="hero-slider-item">
        <div class="row">
        <div class="col-md-8">
            <h1 class="text-white" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".1">Your bright future is our mission</h1>
            <p class="text-muted mb-4" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".4">To access NSFAS and other South African institutions which are currently
              open for admissions scroll down to the link sections.
              </p>
            <a href="contact.html" class="btn btn-primary" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".7">Apply now</a>
          </div>
        </div>
      </div>
      <!-- slider item -->
      <div class="hero-slider-item">
        <div class="row">
        <div class="col-md-8">
            <h1 class="text-white" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".1">Your bright future is our mission</h1>
            <p class="text-muted mb-4" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".4">In order for student to reserve book from Mylibcenter system they should be
              registered with Ehlanzeni TVET College Mthimba Campus and their records exist in our database system.
              </p>
            <a href="contact.html" class="btn btn-primary" data-animation-out="fadeOutRight" data-delay-out="5" data-duration-in=".3" data-animation-in="fadeInLeft" data-delay-in=".7">Apply now</a>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
<!-- /hero slider -->

<!-- books -->
<section class="section-sm">
  <div class="container">
    <div class="row">
      <div class="col-12">
        <div class="d-flex align-items-center section-title justify-content-between">
          <h2 class="mb-0 text-nowrap mr-3">Our Books</h2>
          <div class="border-top w-100 border-primary d-none d-sm-block"></div>
          
        </div>
      </div>
    </div>
    <!-- course list -->
<div class="row justify-content-center">
  <!-- book 1 -->
  <div class="col-lg-4 col-sm-6 mb-5">
    <div class="card p-0 border-primary rounded-0 hover-shadow">
      <img class="card-img-top rounded-0" src="images/courses/im1.jpeg" alt="course thumb" style="height:400px;">
      <div class="card-body">
        <ul class="list-inline mb-2">
          <li class="list-inline-item"><i class="ti-calendar mr-1 text-color"></i>16-12-2022</li>
          <li class="list-inline-item"><a class="text-color" href="userlogin.php">Agriculture</a></li>
        </ul>
        <a href="userlogin.php">
          <h4 class="card-title">Farming Management</h4>
        </a>
        <p class="card-text mb-4"> N4 N series C Codler</p>
        <a href="userlogin.php" class="btn btn-primary btn-sm">Reserve Me</a>
      </div>
    </div>
  </div>
  <!-- book 2 -->
  <div class="col-lg-4 col-sm-6 mb-5">
    <div class="card p-0 border-primary rounded-0 hover-shadow">
      <img class="card-img-top rounded-0" src="images/courses/im2.jpeg" alt="course thumb" style="height:400px;">
      <div class="card-body">
        <ul class="list-inline mb-2">
          <li class="list-inline-item"><i class="ti-calendar mr-1 text-color"></i>16-12-2022</li>
          <li class="list-inline-item"><a class="text-color" href="userlogin.php">Agriculture</a></li>
        </ul>
        <a href="userlogin.php">
          <h4 class="card-title">Grass-Fed Cattle</h4>
        </a>
        <p class="card-text mb-4"> Julius Reuchel</p>
        <a href="userlogin.php" class="btn btn-primary btn-sm">Reserve Me</a>
      </div>
    </div>
  </div>
  <!-- book 3 -->
  <div class="col-lg-4 col-sm-6 mb-5">
    <div class="card p-0 border-primary rounded-0 hover-shadow">
      <img class="card-img-top rounded-0" src="images/courses/im3.jpeg" alt="course thumb" style="height:400px;">
      <div class="card-body">
        <ul class="list-inline mb-2">
          <li class="list-inline-item"><i class="ti-calendar mr-1 text-color"></i>12-18-2022</li>
          <li class="list-inline-item"><a class="text-color" href="userlogin.php">Agriculture</a></li>
        </ul>
        <a href="userlogin.php">
          <h4 class="card-title">Agricultural Management Practices</h4>
        </a>
        <p class="card-text mb-4"> Brian Callaghan Ep Nel</p>
        <a href="userlogin.php" class="btn btn-primary btn-sm">Reserve Me</a>
      </div>
    </div>
  </div>  
</div>
<!-- /course list -->
    
</section>
<!-- /courses -->

<!-- footer -->
<footer>
  <!-- newsletter -->
  <div class="newsletter">
    <div class="container">
      <div class="row">
        <div class="col-md-9 ml-auto bg-primary py-5 newsletter-block">
          <h3 class="text-white">Subscribe Now</h3>
          <form action="index.php" method="post" name="login" onsubmit="return(validate());">
            <div class="input-wrapper">
              <input type="email" class="form-control border-0" id="email" name="email" placeholder="Enter Your Email...">
              <button type="submit" name="submit" value="submit" class="btn btn-primary">Join</button>
            </div>
          </form>
        </div>
      </div>
    </div>
  </div>
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
<!--validation-->
<script type="text/javascript">

function validate(){
	  if(document.login.email.value==""){
		alert('email is required');
		document.login.email.focus();
		return false;
	}
	
	return(true);
}

</script>