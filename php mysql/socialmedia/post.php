<?php
// post.php
include 'db.php';
session_start();
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $user_id = $_SESSION['user_id'];
    $content = $_POST['content'];
    $sql = "INSERT INTO posts (user_id, content) VALUES ('$user_id', '$content')";
    if ($conn->query($sql) === TRUE) {
        echo "Post created";
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}
$conn->close();
?>

<?php
include 'db.php';
session_start();

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $user_id = $_SESSION['user_id'];
    $content = $_POST['content'];

    // Handle Image Upload
    $imagePath = '';
    if (isset($_FILES['image']) && $_FILES['image']['error'] == 0) {
        $imageName = $_FILES['image']['name'];
        $imageTmpName = $_FILES['image']['tmp_name'];
        $imagePath = 'uploads/' . basename($imageName);

        // Move the uploaded file to the "uploads" directory
        if (move_uploaded_file($imageTmpName, $imagePath)) {
            // Image uploaded successfully
        }
    }

    // Insert Post Content into Database
    $sql = "INSERT INTO posts (user_id, content, image_path) VALUES ('$user_id', '$content', '$imagePath')";
    if ($conn->query($sql) === TRUE) {
        echo json_encode(['status' => 'Post created', 'imagePath' => $imagePath]);
    } else {
        echo "Error: " . $conn->error;
    }
}
$echo "xxxxxxxx";
$conn->close();
?>

