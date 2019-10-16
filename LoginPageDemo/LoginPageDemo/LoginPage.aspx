<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginPageDemo.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="~/CSS_And_Script_File/jQuery/uncompressed/jquery-3.3.1.js"></script>
    <script src="~/CSS_And_Script_File/SweetAlert/sweetalert.min.js"></script>
    <script src="~/CSS_And_Script_File/Bootstrap/Bootstrap-3.3.7/js/bootstrap.js"></script>
    <link href="~/CSS_And_Script_File/Bootstrap/Bootstrap-3.3.7/css/bootstrap.css" rel="stylesheet" />

    <style>
        body {
            background-image: url('Image/5-best.jpeg');
        }
        .custom-well {
            background: rgba(242, 242, 242, 0.90);
        }
        .shadow_B {
            box-shadow: -2px 4px 22px #000
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container" style="margin-top: 100px">
            <div class="row" style="margin-bottom: 50px">
                <div class="col-lg-6 col-md-6 col-lg-offset-3 col-md-offset-3">
                    <div class="well custom-well shadow_B">
                        <div class="text-center">
                            <img src="Image/732220-copy.jpg" style="border-radius: 10px;" class="img-responsive" />
                            <br />
                            <h2 style="font-family: Impact; color:brown">Login Page</h2>
                        </div>
                        <br />

                        <div class="form-horizontal table">
                            <div class="form-group h4 has-error">
                                <span class="control-label col-lg-3 col-md-3 col-sm-4">UserName</span>
                                <div class="col-lg-8 col-md-9 col-sm-6">
                                    <div class="input-group">
                                        <span class="input-group-addon" style="height: 10px">
                                            <span class="glyphicon glyphicon-user"></span>
                                        </span>
                                        <input id="Textbox1" placeholder="Enter Your UserName" class="form-control" type="text" required="required" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-horizontal table">
                            <div class="form-group h4 has-error">
                                <span class="control-label col-lg-3 col-md-3 col-sm-4">Password</span>
                                <div class="col-lg-8 col-md-9 col-sm-6">
                                    <div class="input-group">
                                        <span class="input-group-addon" style="height: 10px">
                                            <span class="glyphicon glyphicon-lock"></span>
                                        </span>
                                        <input id="Textbox2" placeholder="Enter Your Password" class="form-control" type="password" required="required" />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="text-center">
                            <label class="checkbox-inline">
                                <input type="checkbox" value="remember"/><b>Remeber me</b>
                            </label>
                        </div>

                        <br />

                        <div class="text-center">
                            <input id="loginBtn" type="submit" class="btn btn-danger" style="border-radius: 20px; width: 250px; outline: none" value="Login" />
                        </div>
                        <div class="text-center" style="margin-top: 70px">
                            <label>Not a member? <a href="#" style="text-decoration: none">Sign up now</a></label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
