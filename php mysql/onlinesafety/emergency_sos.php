<?php
include 'db.php';

// Handle storing emergency contacts
if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['add_contact'])) {
    $name = $_POST['name'];
    $phone_number = $_POST['phone_number'];
    $type = $_POST['type'];

    $sql = "INSERT INTO emergency_contacts (name, phone_number, type) VALUES ('$name', '$phone_number', '$type')";
    
    if ($conn->query($sql) === TRUE) {
        echo "<p class='success-msg'> Submitted successfully!</p>";
    } else {
        echo "<p class='error-msg'>❌ Error: " . $conn->error . "</p>";
    }
}

// Handle sending emergency alerts
if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['send_alert'])) {
    $message = "Emergency Alert: User needs urgent assistance!";
    $sql = "SELECT * FROM emergency_contacts WHERE type = 'Police'";
    $result = $conn->query($sql);

    while ($contact = $result->fetch_assoc()) {
        echo "<p class='alert-msg'>🚨 Sending alert to <strong>" . $contact['name'] . "</strong> at <strong>" . $contact['phone_number'] . "</strong></p>";
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Emergency SOS</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f8d7da;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            flex-direction: column;
        }
        /* Navigation Bar Styles */
        .nav-bar {
            width: 100%;
            background-color: #dc3545;
            padding: 15px 0;
            text-align: center;
        }
        .nav-bar a {
            color: white;
            font-size: 18px;
            text-decoration: none;
            padding: 10px 20px;
            margin: 0 10px;
            border-radius: 5px;
        }
        .nav-bar a:hover {
            background-color: #c82333;
        }
        .sos-container, .contact-container {
            background: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            width: 350px;
            margin-bottom: 20px;
        }
        h2 {
            color: #721c24;
            margin-bottom: 20px;
        }
        .sos-btn, .add-btn {
            background-color: #dc3545;
            color: white;
            border: none;
            padding: 15px;
            font-size: 18px;
            cursor: pointer;
            border-radius: 5px;
            width: 100%;
        }
        .sos-btn:hover {
            background-color: #c82333;
        }
        .add-btn {
            background-color: #28a745;
        }
        .add-btn:hover {
            background-color: #218838;
        }
        .alert-msg, .success-msg, .error-msg {
            padding: 10px;
            border-radius: 5px;
            margin-top: 15px;
            font-weight: bold;
        }
        .alert-msg {
            background-color: #f8d7da;
            color: #721c24;
        }
        .success-msg {
            background-color: #d4edda;
            color: #155724;
        }
        .error-msg {
            background-color: #f8d7da;
            color: #721c24;
        }
        input, select {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <!-- Navigation Bar -->
    <div class="nav-bar">
        <a href="user_dashboard.php">Home</a>  <!-- Link to the Home page -->
    </div>

    <!-- Add Emergency Contact Section -->
    <div class="contact-container">
        <h2>🚨 Emergency SOS Alert</h2>
        <form method="POST" action="">
            <input type="text" name="name" placeholder="Contact Name" required>
            <input type="text" name="phone_number" placeholder="Phone Number" required>
            <select name="type">
                <option selected="">--select a type--</option>
                <option value="Police Officer">Police Officer</option>
                <option value="Social Worker">Social Worker</option>
                <option value="Community Warden">Community Warden</option>
            </select>
            <button type="submit" class="add-btn" name="add_contact">Submit</button>
        </form>
    </div>
</body>
</html>
