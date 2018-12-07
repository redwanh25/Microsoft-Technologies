<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterAndLogin.aspx.cs" Inherits="Software_Company_WebApplication.RegistrationAndLoginPage.RegisterAndLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../JavaScriptFile/Register.js"></script>
    <script src="../JavaScriptFile/Login.js"></script>
    <script src="../jquery_Bootstrap_SweetAlert_IHover/SweetAlert/sweetalert.min.js"></script>
    <style>
        /*navigation bar er upor er effect ta aikhane kora ase.*/
        .zoom-effect {
            transition: transform .1s;
            cursor: url('http://csscursor.info/source/santahand.png'), default;
        }

            .zoom-effect:hover {
                /*transform: translateY(-20px) scale(2) rotate(10deg);*/
                transform: translateY(-4px) scale(1.03);
            }

        .design {
            text-align: center;
            background-color: #DEEFD7;
            border-radius: 10px;
        }

        .designButton {
            text-align: right;
        }

        .shadow_B {
            box-shadow: -2px 4px 22px #000
        }

        a, a:hover, a:active, a:visited, a:focus {
            text-decoration: none;
        }
    </style>
</head>
<body style="padding-top: 50px;">
    <form id="form1" runat="server">
        <nav class="navbar navbar-default navbar-inverse navbar-fixed-top shadow_B">
            <div class="container">
                <div class="navbar-header">
                    <button id="Button1" type="button" value="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand zoom-effect" style="font-size: 30px" href="#">Logo</a>
                </div>
                <div class="navbar-collapse collapse">
                    <div class="navbar-form navbar-right">
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon" style="height: 10px">
                                    <span class="glyphicon glyphicon-user"></span>
                                </span>
                                <asp:TextBox ID="txtUserNameLogin" runat="server" placeholder="Enter your UserName" CssClass="form-control" Height="30"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div>
                                <p></p>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon" style="height: 10px">
                                    <span class="glyphicon glyphicon-lock"></span>
                                </span>
                                <asp:TextBox ID="txtPasswordLogin" runat="server" placeholder="Enter your Password" CssClass="form-control" TextMode="Password" Height="30"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div style="padding-left: 20px">

                            </div>
                        </div>
                        <div class="form-group navbar-right">
                            <div class="btn-group">
                                <input id="btnLogin" value="login" class="btn btn-sm btn-default" style="width: 80px; font-size: 12px" />
                                <button type="button" class="btn btn-sm dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                    <span class="caret"></span>
                                    <span class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Action</a></li>
                                    <li><a href="#">Another action</a></li>
                                    <li><a href="#">Settings</a></li>
                                    <li role="separator" class="divider"></li>
                                    <li><a href="#">Forget Password</a></li>
                                </ul>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </nav>
        <div style="background-color: #E8EAED">
            <br />
            <br />
            <div class="container">
                <div class="row">
                    <div class="col-lg-4 col-md-5 col-sm-5 col-xs-12">
                        <div class="well h3">
                            <marquee behavior="alternate">Application</marquee>
                        </div>
                        <div id="accordion_pic" class="panel-group">

                            <div class="panel panel-success">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a href="#panelBodyOne1" data-toggle="collapse" data-parent="#accordion_pic"><b>Who Can Use This Application</b>
                                            <span class="glyphicon glyphicon-eye-open pull-right"></span>
                                        </a>
                                    </div>
                                </div>
                                <div id="panelBodyOne1" class="collapse panel-collapse">
                                    <div class="panel-body">
                                        <p>
                                            Only this company emplyee can use this application. because you
                                            have to EmplyeeCode. if you do not have EmplyeeCode, you can't
                                            login...
                                        </p>
                                    </div>
                                </div>
                            </div>

                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a href="#panelBodyTwo2" data-toggle="collapse" data-parent="#accordion_pic"><b>Help Line </b>(+880123456789)
                                            <span class="glyphicon glyphicon-eye-open pull-right"></span>
                                        </a>
                                    </div>
                                </div>
                                <div id="panelBodyTwo2" class="collapse panel-collapse">
                                    <div class="panel-body">
                                        <p>
                                            Only this company emplyee can use this application. because you
                                            have to EmplyeeCode. if you do not have EmplyeeCode, you can't
                                            login...
                                            <br />
                                            Only this company emplyee can use this application. because you
                                            have to EmplyeeCode. if you do not have EmplyeeCode, you can't
                                            login...
                                        </p>
                                    </div>
                                </div>
                            </div>

                            <div class="panel panel-danger">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a href="#panelBodyThree3" data-toggle="collapse" data-parent="#accordion_pic"><b>Forget Your Password</b>
                                            <span class="glyphicon glyphicon-eye-open pull-right"></span>
                                        </a>
                                    </div>
                                </div>
                                <div id="panelBodyThree3" class="collapse panel-collapse">
                                    <div class="panel-body">
                                        <p>
                                            Only this company emplyee can use this application. because you
                                            have to EmplyeeCode. if you do not have EmplyeeCode, you can't
                                            login...
                                        </p>
                                    </div>
                                </div>
                            </div>

                            <div class="panel panel-warning">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a href="#panelBodyOne4" data-toggle="collapse" data-parent="#accordion_pic"><b>How To Use </b>(get details)
                                            <span class="glyphicon glyphicon-eye-open pull-right"></span>
                                        </a>
                                    </div>
                                </div>
                                <div id="panelBodyOne4" class="collapse panel-collapse">
                                    <div class="panel-body">
                                        <p>
                                            Only this company emplyee can use this application. because you
                                            have to EmplyeeCode. if you do not have EmplyeeCode, you can't
                                            login...
                                            <br />
                                            Only this company emplyee can use this application. because you
                                            have to EmplyeeCode. if you do not have EmplyeeCode, you can't
                                            login...
                                            <br />
                                            Only this company emplyee can use this application. because you
                                            have to EmplyeeCode. if you do not have EmplyeeCode, you can't
                                            login...
                                        </p>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-lg-7 col-md-7 col-sm-7 col-xs-12 col-lg-offset-1">
                        <div class="h2">
                            <p>Create a new account</p>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success">
                                    <label>UserName</label>
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-user"></span>
                                        </span>
                                        <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter your User Name" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success">
                                    <label>Phone Number</label>
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-phone-alt"></span>
                                        </span>
                                        <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="Enter your Phone Number" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success">
                                    <label>EmployeeCode</label>
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-globe"></span>
                                        </span>
                                        <asp:TextBox ID="textEmployeeCode" runat="server" placeholder="Enter your EmployeeCode" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success">
                                    <label>Email ID</label>
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-envelope"></span>
                                        </span>
                                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your Email ID" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success">
                                    <label>Password</label>
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-lock"></span>
                                        </span>
                                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter your Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success">
                                    <label>Confirm Password</label>
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-lock"></span>
                                        </span>
                                        <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="Enter your Confirm Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <!--Bootstrap alert to display any validation errors-->
                                <div id="divErrorRegister" class="alert alert-danger collapse">
                                    <a id="linkCloseRegister" href="#" class="close">&times;</a>
                                    <div id="divErrorTextRegister"></div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <input id="btnRegister" class="btn btn-block" type="button" style="border: 1px solid; border-radius: 30px; outline: none; background-color: #DEEFD7; font-size: 18px" value="Register" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
        </div>
        <br />
        <footer id="footer">
            <div class="footer-bottom">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                            <h3>Website Name</h3>
                            <hr style="border: 1px solid; color: black">
                            <p>
                                Use this document as a way to quickly start any new project.
                                All you get is this text and a mostly barebones HTML document.
                            </p>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                            <h3>Usefull link</h3>
                            <hr style="border: 1px solid; color: black">
                            <table class="table" style="margin-top: 20px">
                                <tr>
                                    <td><a style="color: orange" href="#">IT solutions</a> </td>
                                </tr>
                                <tr>
                                    <td><a style="color: orange" href="#">E-commerce solutions</a> </td>
                                </tr>
                                <tr>
                                    <td><a style="color: orange" href="#">Mobile development</a> </td>
                                </tr>
                            </table>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                            <h3>Follow Us</h3>
                            <hr style="border: 1px solid; color: black">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/facebook.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Image/twitter.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Image/instagram.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Image/google.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Image/linkedin.png" Style="width: 40px; height: 40px" />
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                            <h3>Address</h3>
                            <hr style="border: 1px solid; color: black">
                            <div style="color: orange">
                                <p>46/1 Shukrabad, Dhanmondi.</p>
                                <p>Dhaka, Bangladesh</p>
                            </div>
                        </div>
                    </div>
                    <hr style="border: 1px solid; color: black">
                    <p class="pull-right">&copy; <%: DateTime.Now.Year %> - Developed by <a style="color: red" target="_blank" href="https://www.facebook.com/profile.php?id=100004911679186">Redwan Hossain</a></p>
                </div>
            </div>
        </footer>
    </form>
</body>
</html>
