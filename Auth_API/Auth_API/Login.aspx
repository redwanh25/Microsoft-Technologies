<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Auth_API.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="col-md-6 col-md-offset-3">
            <div class="well">
                <!--Table to capture username and password-->
                <table class="table table-bordered">
                    <thead>
                        <tr class="success">
                            <th colspan="2">
                                Existing User Login <a href="Register.aspx" class="btn btn-success pull-right">Register</a>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Usename</td>
                            <td>
                                <input class="form-control" type="text" id="txtUsername" placeholder="Username" />
                            </td>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td>
                                <input class="form-control" type="password" id="txtPassword" placeholder="Password" />
                            </td>
                        </tr>
                        <tr class="success">
                            <td colspan="2">
                                <input id="btnLogin" class="btn btn-success" type="button" value="Login" />
                            </td>
                        </tr>
                    </tbody>
                </table>
                <!--Bootstrap alert to display error message if the login fails-->
                <div id="divError" class="alert alert-danger collapse">
                    <a id="linkClose" href="#" class="close">&times;</a>
                    <div id="divErrorText"></div>
                </div>
            </div>
        </div>
        <script type="text/javascript">
            $(document).ready(function () {

                $('#linkClose').click(function () {
                    $('#divError').hide('fade');
                });

                $('#btnLogin').click(function () {
                    $.ajax({
                        // Post username, password & the grant type to /token
                        url: '/token',
                        method: 'POST',
                        contentType: 'application/json',
                        data: {
                            username: $('#txtUsername').val(),
                            password: $('#txtPassword').val(),
                            grant_type: 'password'
                        },
                        // When the request completes successfully, save the
                        // access token in the browser local storage and
                        // redirect the user to Index.cshtml page. We do not have
                        // this page yet. So please add it to the
                        // EmployeeService project before running it
                        success: function (response) {
                            localStorage.setItem("accessToken", response.access_token);
                            window.location.href = "http://localhost:57557/Home/Index";
                        },
                        // Display errors if any in the Bootstrap alert <div>
                        error: function (jqXHR) {
                            $('#divErrorText').text(jqXHR.responseText);
                            $('#divError').show('fade');
                        }
                    });
                });
            });
        </script>
    </form>
</body>
</html>
