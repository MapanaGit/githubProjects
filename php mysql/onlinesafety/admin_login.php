<?php
session_start();

// Database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "abuse_reporting_system";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Process form submission
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Get username and password from form
    $input_username = $_POST['username'];
    $input_password = $_POST['password'];

    // Prevent SQL Injection by using prepared statements
    $stmt = $conn->prepare("SELECT * FROM admin WHERE username = ?");
    $stmt->bind_param("s", $input_username);
    $stmt->execute();
    $result = $stmt->get_result();

    if ($result->num_rows > 0) {
        // If user exists, fetch the user data
        $admin = $result->fetch_assoc();

        // Verify password (assuming the password is stored hashed in the database)
        if ($input_password === $admin['password']) { // You can improve this with password_hash() and password_verify() for security
            $_SESSION['username'] = $admin['username'];
            $_SESSION['role'] = $admin['role']; // Store role in session (if needed)

            // Redirect to admin dashboard or another protected page
            header("Location: admin_dashboard.php");
            exit();
        } else {
            // If password is incorrect
            echo "<p style='color:red;'>Invalid username or password.</p>";
        }
    } else {
        // If username does not exist
        echo "<p style='color:red;'>Invalid username or password.</p>";
    }

    // Close the prepared statement and connection
    $stmt->close();
}

// Close the connection
$conn->close();
?>

<div class="try-again-container">
    <a href="login.html" class="try-again-link">Try again</a>
</div>

<style>
    .try-again-container {
        text-align: center;
        margin-top: 20px;
    }

    .try-again-link {
        font-size: 16px;
        color: #007bff; /* Blue color */
        text-decoration: none;
        padding: 10px 15px;
        border: 1px solid #007bff;
        border-radius: 5px;
        background-color: #f8f9fa; /* Light background */
        transition: all 0.3s ease; /* Smooth transition on hover */
    }

    .try-again-link:hover {
        background-color: #007bff; /* Blue background on hover */
        color: white; /* White text on hover */
        border-color: #007bff;
    }

    .try-again-link:focus {
        outline: none;
    }
</style>
