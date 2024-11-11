<%-- 
    Document   : index
    Created on : Nov 11, 2024, 5:31:05 PM
    Author     : Dev
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login</title>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
        <style>
            td{
                padding: 10px;
            }
            div{
                width: 50%;
                border: 1px solid black;
                border-radius: 5px;
                background-color: lightslategrey;
            }
        </style>
    </head>
    <body>
        <h1><center><u>Login here</u></center></h1>
        <center>
            <div>
              <form action="login" method="POST">
                <table>
                    <tr>
                        <td>Username</td>
                        <td><input type="text" class="form-control" name="username" placeholder="enter username"></td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td><input type="password" class="form-control" name="password" placeholder="Enterpassword"></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center"><input type="submit" class="form-control" value="Submit"></td>
                    </tr>
                </table>
              </form>
            </div>
        </center>
    </body>
</html>
