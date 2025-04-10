<?php
include 'db.php';
session_start();

if (!isset($_SESSION['user_id'])) {
    header("Location: login.php");
    exit();
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $user_id = $_SESSION['user_id'];
    $report_text = $_POST['report_text'];
    $status = "Pending";
    $created_at = date("Y-m-d H:i:s");

    // Handle file upload
    $target_dir = "uploads/";
    $target_file = $target_dir . basename($_FILES["report_image"]["name"]);
    move_uploaded_file($_FILES["report_image"]["tmp_name"], $target_file);

    $sql = "INSERT INTO reports (user_id, report_text, report_image, status, created_at) VALUES ('$user_id', '$report_text', '$target_file', '$status', '$created_at')";
    if ($conn->query($sql) === TRUE) {
        echo "Report submitted successfully. Your case reference is " . $conn->insert_id;
    } else {
        echo "Error: " . $conn->error;
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Submit Report</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
            text-align: center;
        }
        .navbar {
            background-color: #007bff;
            padding: 15px;
        }
        .navbar a {
            color: white;
            text-decoration: none;
            font-size: 18px;
            padding: 10px;
        }
        .container {
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
            margin: 50px auto;
            text-align: center;
        }
        textarea, input, button {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        button {
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
        }
        button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>

    <div class="navbar">
        <a href="user_dashboard.php">Home</a>
    </div>

    <div class="container">
        <h2>Submit Report</h2>
        <form method="POST" enctype="multipart/form-data" action="">
            <input type="text" name="report_id" placeholder="Report ID (Auto-Generated)" disabled>
            <input type="text" name="user_id" value="<?php echo $_SESSION['user_id']; ?>" disabled>
            <textarea name="report_text" placeholder="Describe the incident" required></textarea>
            <input type="file" name="report_image">
            <input type="text" name="status" value="Pending" disabled>
            <input type="text" name="created_at" value="<?php echo date('Y-m-d H:i:s'); ?>" disabled>
            <button type="submit">Submit Report</button>
        </form>
    </div>

</body>
</html>
