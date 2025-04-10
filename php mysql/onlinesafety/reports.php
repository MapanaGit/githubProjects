<?php
session_start();

// Redirect to login page if user is not logged in
if (!isset($_SESSION['username'])) {
    header("Location: login.html");
    exit();
}

// Database connection
$servername = "localhost"; // Replace with your DB host
$username = "root"; // Replace with your DB username
$password = ""; // Replace with your DB password
$dbname = "abuse_reporting_system"; // Replace with your database name

$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Fetch reports from the database
$sql = "SELECT * FROM reports"; // Assuming you have a 'reports' table in your database
$result = $conn->query($sql);

// Close connection after fetching data
$conn->close();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Reports Dashboard</title>
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
        .search-box {
            padding: 10px;
            width: 100%;
            margin-bottom: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
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
        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        table, th, td {
            border: 1px solid #ddd;
        }
        th, td {
            padding: 10px;
            text-align: left;
        }
        th {
            background-color: #007bff;
            color: white;
        }
        button {
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        button:hover {
            background-color: #45a049;
        }
    </style>
    <script>
        function searchReports() {
            let input = document.getElementById("search").value.toLowerCase();
            let rows = document.querySelectorAll("table tbody tr");
            rows.forEach(row => {
                let text = row.innerText.toLowerCase();
                row.style.display = text.includes(input) ? "" : "none";
            });
        }

        function printTable() {
            window.print();
        }
    </script>
</head>
<body>

    <div class="container">
        <!-- Header -->
        <div class="header">
            <h2>Reports Dashboard</h2>
            <button onclick="window.location.href='admin_dashboard.php'">Back</button>
        </div>

        <!-- Search Box -->
        <input type="text" id="search" class="search-box" onkeyup="searchReports()" placeholder="Search reports...">
        <button onclick="printTable()">Print</button>

        <!-- Reports Table -->
        <table>
            <thead>
                <tr>
                    <th>Report ID</th>
                    <th>User ID</th>
                    <th>Report Text</th>
                    <th>Report Image</th>
                    <th>Status</th>
                    <th>Created At</th>
                </tr>
            </thead>
            <tbody>
                <?php if ($result->num_rows > 0) { ?>
                    <?php while ($report = $result->fetch_assoc()) { ?>
                        <tr>
                            <td><?php echo $report['report_id']; ?></td>
                            <td><?php echo $report['user_id']; ?></td>
                            <td><?php echo $report['report_text']; ?></td>
                            <td><img src="<?php echo $report['report_image']; ?>" alt="Image" width="100"></td>
                            <td><?php echo $report['status']; ?></td>
                            <td><?php echo $report['created_at']; ?></td>
                        </tr>
                    <?php } ?>
                <?php } else { ?>
                    <tr>
                        <td colspan="6">No reports found.</td>
                    </tr>
                <?php } ?>
            </tbody>
        </table>
    </div>

</body>
</html>
