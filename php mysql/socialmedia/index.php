<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Social Media Platform</title>
    <link rel="stylesheet" href="styles.css">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            text-align: center;
            padding: 20px;
        }
        .container {
            width: 50%;
            margin: auto;
            background: white;
            padding: 20px;
            box-shadow: 0px 0px 10px gray;
            border-radius: 10px;
        }
        input, textarea {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 15px;
            cursor: pointer;
            border-radius: 5px;
        }
        button:hover {
            background-color: #0056b3;
        }
        #posts p {
            background: #ddd;
            padding: 10px;
            border-radius: 5px;
            margin-top: 5px;
        }
        #posts img {
            width: 100%;
            height: auto;
        }
        .hidden {
            display: none;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Welcome to Social Media Platform</h1>
        <div id="auth">
            <form id="registerForm" method="POST">
                <input type="text" name="name" placeholder="Name" required>
                <input type="email" name="email" placeholder="Email" required>
                <input type="password" name="password" placeholder="Password" required>
                <button type="submit">Register</button>
            </form>
            <form id="loginForm" method="POST">
                <input type="email" name="email" placeholder="Email" required>
                <input type="password" name="password" placeholder="Password" required>
                <button type="submit">Login</button>
            </form>
        </div>
        <div id="timeline" class="hidden">
            <div id="profile">
                <h2>Your Profile</h2>
                <p>Name: <span id="profile-name"></span></p>
                <p>Email: <span id="profile-email"></span></p>
            </div>
            <textarea id="postContent" placeholder="Share something..."></textarea>
            <input type="file" id="imageUpload" accept="image/*">
            <button id="postBtn">Post</button>
            <button id="logoutBtn">Logout</button> <!-- Logout Button -->
            <div id="posts"></div>
            <div id="messaging">
                <h2>Send a Message</h2>
                <form id="messageForm">
                    <input type="text" id="recipient" placeholder="Recipient" required>
                    <textarea id="messageContent" placeholder="Message" required></textarea>
                    <button type="submit">Send</button>
                </form>
            </div>
        </div>
    </div>

    <script>
        $(document).ready(function() {
            // Register Form Submission
            $('#registerForm').submit(function(e) {
                e.preventDefault();
                $.post('register.php', $(this).serialize(), function(data) {
                    alert(data);
                });
            });

            // Login Form Submission
            $('#loginForm').submit(function(e) {
                e.preventDefault();
                $.post('login.php', $(this).serialize(), function(data) {
                    if (data === 'Login successful') {
                        $('#auth').hide();
                        $('#timeline').removeClass('hidden');
                        // Display username and other details
                        $.post('get_user.php', function(user) {
                            $('#profile-name').text(user.name);
                            $('#profile-email').text(user.email);
                        });
                    } else {
                        alert(data);
                    }
                });
            });

            // Post Button Click
            $('#postBtn').click(function() {
                let content = $('#postContent').val();
                let image = $('#imageUpload')[0].files[0];
                let formData = new FormData();
                formData.append('content', content);
                formData.append('image', image);

                $.ajax({
                    url: 'post.php',
                    type: 'POST',
                    data: formData,
                    processData: false,
                    contentType: false,
                    success: function(data) {
                        $('#posts').prepend('<p>' + content + '</p>');
                        if (data.imagePath) {
                            $('#posts').prepend('<img src="' + data.imagePath + '" alt="Post Image">');
                        }
                    }
                });
            });

            // Logout Button Click
            $('#logoutBtn').click(function() {
                $.post('logout.php', function(data) {
                    if (data === 'Logout successful') {
                        $('#timeline').addClass('hidden');
                        $('#auth').show();
                    } else {
                        alert('Error logging out');
                    }
                });
            });

            // Message Form Submission
            $('#messageForm').submit(function(e) {
                e.preventDefault();
                let recipient = $('#recipient').val();
                let messageContent = $('#messageContent').val();
                $.post('message.php', {
                    recipient: recipient,
                    message: messageContent
                }, function(data) {
                    alert(data);
                });
            });
			
			$(document).ready(function() {
    // Existing login form submission logic
    $('#loginForm').submit(function(e) {
        e.preventDefault();
        $.post('login.php', $(this).serialize(), function(data) {
            if (data === 'Login successful') {
                $('#auth').hide();
                $('#timeline').removeClass('hidden');
                
                // Fetch and display user profile details
                $.post('get_user.php', function(response) {
                    const user = JSON.parse(response);
                    $('#profile-name').text(user.name);
                    $('#profile-email').text(user.email);
                });
            } else {
                alert(data);
            }
        });
    });
});

        });
    </script>
</body>
</html>
