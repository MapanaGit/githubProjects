<?php
// message.php
include 'db.php';
session_start();

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $sender_id = $_SESSION['user_id'];
    $recipient = $_POST['recipient'];
    $message = $_POST['message'];

    // You should handle user validation and check if the recipient exists

    // Insert Message into Database
    $sql = "INSERT INTO messages (sender_id, recipient, message) VALUES ('$sender_id', '$recipient', '$message')";
    if ($conn->query($sql) === TRUE) {
        echo "Message sent successfully";
    } else {
        echo "Error: " . $conn->error;
    }
}
$conn->close();
?>
