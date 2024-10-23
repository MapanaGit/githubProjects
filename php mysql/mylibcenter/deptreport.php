<?php 

$conn = mysqli_connect("localhost", "root", "", "librarysystem");
// Check connection
if($conn === false){
    die("ERROR: Could not connect. "
        . mysqli_connect_error());
}

?>
<!DOCTYPE html>
<html>
<head>
<title>Books Available | Mylibcenter</title>
 <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
  <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css">
  <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/buttons/1.5.1/css/buttons.dataTables.min.css">
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>

    <div class="mynav">
    <a href="mylibcenter.php"><button type="submit" style="background-color:green; width:140px; height:100px;">Home</button></a>
      <a href="booksavailable.php"><button type="submit" style="background-color:green; width:140px; height:100px;">Books</button></a>
      <a href="deptreport.php"><button type="submit" style="background-color:green; width:140px; height:100px;">Courses</button></a>
      <a href="studentavailable.php"><button type="submit" style="background-color:green; width:140px; height:100px;">Students</button></a>
      <a href="bookout.php"><button type="submit" style="background-color:green; width:140px; height:100px;">Reserved Books</button></a>
      <a href="returnedbooks.php"><button type="submit" style="background-color:green; width:140px; height:100px;">Returned Books</button></a>
    </div>
    <style>
      .mynav{
        background-color:brown;
        width:1260px;
        height: 100px;
        font-size:large;
      }
    </style>
    <!-- Content Header (Page header) -->
    <!-- Main content -->
          <div class="col-md-12">
            <!-- general form elements -->
         <div class="card card-success">
              <div class="card-header">
                
                <h2 class="card-title"> Available Courses </h2>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
                <div class="card-body">
                  <div class="row">
                     <div class="col-md-12">
                <table id="table" class="table table-bordered table-hover">
                    <thead style="background:#A4D8F9;">
          <tr>
                            <td>Course Name</td>  
                        </tr>
                    </thead>
                    <tbody>
                        <?php
 $sql = $conn->query('select * from course');
                            while($data = $sql->fetch_array()) {
                                echo '
                                    <tr>
                                        <td>'.$data['coursename'].'</td>                                  
                                    </tr>
                                ';
                            }
                        ?>
                    </tbody>
                </table>
            </div>
              </div>       
                </div>
              <!-- /.card-body -->
            </div>
    <!-- /.content -->
  </div>
<script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/buttons/1.5.1/js/buttons.print.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.32/pdfmake.min.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/buttons/1.5.1/js/buttons.flash.min.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/buttons/1.5.1/js/dataTables.buttons.min.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/buttons/1.5.1/js/buttons.html5.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            $('#table').DataTable({
               dom: 'Bfrtip',
buttons: [ 'copy', 'csv', 'excel', 'pdf', 'print']

            });
        });
    </script>
</body>
</html> 