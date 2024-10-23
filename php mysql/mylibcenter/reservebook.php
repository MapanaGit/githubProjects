<?php

session_start();
 
        $conn = mysqli_connect("localhost", "root", "", "librarysystem");
        // Check connection
        if($conn === false){
            die("ERROR: Could not connect. "
                . mysqli_connect_error());
        }
     if(isset($_POST['submit'])){
       
        $name = $_REQUEST['name'];
        $isbn =  $_REQUEST['isbn'];
        $dateout = $_REQUEST['dateout'];
        $duration = $_REQUEST['duration'];

       $studentid = $_REQUEST['studentid'];
       
        // Performing insert query execution
        
        $sql = "INSERT INTO borrow(name,isbn,dateout,duration,studentid) VALUES ('$name','$isbn','$dateout','$duration','$studentid')";
       
        if(mysqli_query($conn, $sql)){
            echo "<script>alert('Successful. Please collect your textbook')</script>";
           
        } else{
            echo "<script>alert('Failed. please try again!')</script>";
                
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
  <title>Borrow book modal | Mylibcenter</title>

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
        <a class="navbar-brand" href="reservebook.php"><img src="images/mylogocenter.png" alt="logo"></a>
        <button class="navbar-toggler rounded-0" type="button" data-toggle="collapse" data-target="#navigation"
          aria-controls="navigation" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navigation">
          <ul class="navbar-nav ml-auto text-center">
          <li class="nav-item active">
              <a class="nav-link" href="index.php">Logout</a>
            </li>
          </ul>
        </div>
      </nav>
    </div>
  </div>
</header>
<!-- /header -->
<!-- Modal -->
<br /><br />
<!-- page title -->
<section class="page-title-section overlay" data-background="images/backgrounds/page-title.jpg">
  <div class="container">
    <div class="row">
      <div class="col-md-8">
        <ul class="list-inline custom-breadcrumb mb-2">
          <li class="list-inline-item"><a class="h2 text-primary font-secondary" href="index.html">Home</a></li>
          <li class="list-inline-item text-white h3 font-secondary nasted">Reserve a book</li>
        </ul>
        <p class="text-lighten mb-0"></p>
      </div>
    </div>
  </div>
</section>
<!-- /page title -->

<!-- about us -->
<section class="section">
  <div class="container">
    <div class="row align-items-center">
      <div class="col-md-6 order-2 order-md-1">
        <h2 class="section-title">Reserve a book</h2>
        <form action="reservebook.php" method="post" class="row" name="login" onsubmit="return(validate());">
                       
                        <div class="col-12">
                              
                              <select class="form-control" name="name" id="name">
                              <option Disabled selected>--select book--</option>
                              <?php
                               $conn = mysqli_connect("localhost", "root", "", "librarysystem");
                 // Check connection
                 if($conn === false){
                     die("ERROR: Could not connect. "
                         . mysqli_connect_error());
                 }
                              $records = mysqli_query($conn,"select * from book");
                              while($data=mysqli_fetch_array($records)){
                                  echo"<option value='".$data[0]."'>".$data[0]."</option>";
                              }
                              ?>
                              </select>
                           </div>
                           <div class="col-12">
                              
                              <select class="form-control" name="isbn" id="isbn">
                              <option Disabled selected>--select ISBN--</option>
                              <?php
                               $conn = mysqli_connect("localhost", "root", "", "librarysystem");
                 // Check connection
                 if($conn === false){
                     die("ERROR: Could not connect. "
                         . mysqli_connect_error());
                 }
                              $records = mysqli_query($conn,"select * from book");
                              while($data=mysqli_fetch_array($records)){
                                  echo"<option value='".$data[8]."'>".$data[8]."</option>";
                              }
                              ?>
                              </select>
                           </div>
                        
                        <div class="col-12">
                            <input type="date" class="form-control mb-3" id="dateout" name="dateout" placeholder="date out">
                        </div>
                        <div class="col-12">
                            <input type="text" class="form-control mb-3" id="duration" name="duration" placeholder="for how long?">
                        </div>
                      
                        <div class="col-12">
                            <input type="number" class="form-control mb-3" id="studentid" name="studentid" placeholder="Student Id">
                        </div>
                        
<br />
                        <div class="col-12">
                            <button type="submit" name="submit" id="submit" value="submit" class="btn btn-primary">Reserve Book</button>
                        </div>
                    </form>
        
      </div>
      <div class="col-md-6 order-1 order-md-2 mb-4 mb-md-0">
        <img class="img-fluid w-100" src="images/about/about-us.jpg" alt="about image">
      </div>
    </div>
  </div>
</section>
<!-- /about us -->



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

<!--validation-->
<script type="text/javascript">

function validate(){
	if(document.login.userid.value==""){
		alert('userid id is required');
		document.login.userid.focus();
		return false;
	}
	if(document.login.name.value==""){
		alert('name is required');
		document.login.name.focus();
		return false;
	}
	if(document.login.isbn.value==""){
		alert('ISBN is required');
		document.login.isbn.focus();
		return false;
	}
	if(document.login.dateout.value==""){
		alert('book date out is required');
		document.login.dateout.focus();
		return false;
	}
  if(document.login.dueon.value==""){
		alert('book return date is required');
		document.login.dueon.focus();
		return false;
	}
  if(document.login.studentid.value==""){
		alert('student Id is required');
		document.login.studentid.focus();
		return false;
	}
	
	return(true);
}

</script>