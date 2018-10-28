<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Auth_API.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="padding-top: 20px">
    <form id="form1" runat="server">
        <div class="col-md-6 col-md-offset-3">
            <div class="well">
                <!--This table contains the fields that we want to capture to register a new user-->
                <table class="table table-bordered">
                    <thead>
                        <tr class="success">
                            <th colspan="2">New User Registration
                                <a class="btn btn-success pull-right" href="Login.aspx"> Login </a>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Email</td>
                            <td>
                                <input class="form-control" type="text" id="txtEmail" placeholder="Email" />
                            </td>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td>
                                <input class="form-control" type="password" id="txtPassword"
                                    placeholder="Password" />
                            </td>
                        </tr>
                        <tr>
                            <td>Confirm Password</td>
                            <td>
                                <input class="form-control" type="password" id="txtConfirmPassword"
                                    placeholder="Confirm Password" />
                            </td>
                        </tr>
                        <tr>
                            <td>UserId</td>
                            <td>
                                <input class="form-control" type="text" id="txtUserId"
                                    placeholder="User Id" />
                            </td>
                        </tr>
                        <tr class="success">
                            <td colspan="2">
                                <input id="btnRegister" class="btn btn-success"
                                    type="button" value="Register" />
                            </td>
                        </tr>
                    </tbody>
                </table>

                <!--Bootstrap modal dialog that shows up when regsitration is successful-->
                <div class="modal fade" tabindex="-1" id="successModal" data-keyboard="false" data-backdrop="static">
                    <div class="modal-dialog modal-md">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal"> &times; </button>
                                <h4 class="modal-title">Success</h4>
                            </div>
                            <div class="modal-body">
                                <h3 class="modal-title">Registration Successful!</h3>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-success" data-dismiss="modal"> Close </button>
                            </div>
                        </div>
                    </div>
                </div>

                <!--Bootstrap alert to display any validation errors-->
                <div id="divError" class="alert alert-danger collapse">
                    <a id="linkClose" href="#" class="close">&times;</a>
                    <div id="divErrorText"></div>
                </div>

            </div>
        </div>
        <script type="text/javascript">
            $(document).ready(function () {

                //Close the bootstrap alert
                $('#linkClose').click(function () {
                    $('#divError').hide('fade');
                });

                // Save the new user details
                $('#btnRegister').click(function () {
                    $.ajax({
                        url: '/api/account/register',
                        method: 'POST',
                        data: {
                            email: $('#txtEmail').val(),
                            password: $('#txtPassword').val(),
                            confirmPassword: $('#txtConfirmPassword').val(),
                            userId: $('#txtUserId').val()
                        },
                        success: function () {
                            $('#successModal').modal('show');
                        },
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
