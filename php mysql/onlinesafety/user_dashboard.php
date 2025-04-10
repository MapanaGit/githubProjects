<?php
session_start();
if (!isset($_SESSION['user_id'])) {
    header("Location: login.php");
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User Dashboard</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .dashboard {
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            width: 300px;
        }
        h2 {
            margin-bottom: 20px;
        }
        .menu {
            display: flex;
            flex-direction: column;
            gap: 10px;
        }
        .menu a {
            text-decoration: none;
            padding: 10px;
            border-radius: 5px;
            font-size: 16px;
            text-align: center;
            color: white;
            display: block;
        }
        .report {
            background-color: #007bff;
        }
        .profile {
            background-color: #28a745;
        }
        .logout {
            background-color: #dc3545;
        }
        .report:hover {
            background-color: #0056b3;
        }
        .profile:hover {
            background-color: #218838;
        }
        .logout:hover {
            background-color: #c82333;
        }
    </style>
</head>
<body>
    <div class="dashboard">
        <h2>User Dashboard</h2>
        <div class="menu">
            <a href="submit_report.php" class="report">Report an Incident</a>
			<a href="emergency_sos.php" class="report">Emergency SOS</a>
            <a href="login.php" class="logout">Logout</a>
        </div>
    </div>
</body>
</html>
