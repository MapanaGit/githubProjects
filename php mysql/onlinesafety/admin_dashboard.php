<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin Dashboard</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 80%;
            margin: 20px auto;
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 20px;
        }
        .header h2 {
            margin: 0;
        }
        .header button {
            padding: 10px;
            border: none;
            background-color: #007bff;
            color: white;
            cursor: pointer;
            border-radius: 5px;
        }
        .header button:hover {
            background-color: #0056b3;
        }
        .button-container {
            display: flex;
            justify-content: space-around;
            margin-top: 50px;
        }
        .button-container a {
            background-color: #4CAF50;
            color: white;
            text-decoration: none;
            padding: 20px 30px;
            border-radius: 5px;
            font-size: 18px;
            transition: background-color 0.3s;
            text-align: center;
        }
        .button-container a:hover {
            background-color: #45a049;
        }
        .button-container a:active {
            background-color: #3e8e41;
        }
    </style>
</head>
<body>

    <div class="container">
        <!-- Header -->
        <div class="header">
            <h2>Admin Dashboard</h2>
            <button onclick="window.location.href='logout.php'">Logout</button>
        </div>

        <!-- Buttons to navigate to different sections -->
        <div class="button-container">
            <a href="reports.php">View Reports</a>
            <a href="users.php">View Users</a>
            <a href="emergency.php">Emergency Contacts</a>
        </div>
    </div>

</body>
</html>
