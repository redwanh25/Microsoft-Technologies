<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterAndLogin.aspx.cs" Inherits="Software_Company_WebApplication.RegistrationAndLoginPage.RegisterAndLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../JavaScriptFile/Register.js"></script>
    <script src="../JavaScriptFile/Login.js"></script>
    <script src="../jquery_Bootstrap_SweetAlert_IHover/SweetAlert/sweetalert.min.js"></script>
    <link href="../jquery_Bootstrap_SweetAlert_IHover/Animate.css" rel="stylesheet" />

    <script src="../HTML/AngularJS/angular.js"></script>
    <script src="../HTML/AngularJS/forgot-password.js"></script>

    <style>
        .sidenav {
            height: 200px; /*30%*/
            width: 0;
            position: fixed;
            z-index: 1;
            top: 200px;
            /*left: 0;*/
            right: 0;
            background-color: #EDEDED;
            overflow-x: hidden;
            transition: 0.5s;
            border-radius: 10px;
        }

            .sidenav .closebtn {
                position: absolute;
                top: 0;
                right: 25px;
                font-size: 36px;
                margin-left: 50px;
            }
    </style>

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
    <style>
        /*for specific width navbar toggle button show*/
        @media (max-width: 1000px) {
            .navbar-header {
                float: none;
            }

            .navbar-left, .navbar-right {
                float: none !important;
            }

            .navbar-toggle {
                display: block;
            }

            .navbar-collapse {
                border-top: 1px solid transparent;
                box-shadow: inset 0 1px 0 rgba(255,255,255,0.1);
            }

            .navbar-fixed-top {
                top: 0;
                border-width: 0 0 1px;
            }

            .navbar-collapse.collapse {
                display: none !important;
            }

            .navbar-nav {
                float: none !important;
                margin-top: 7.5px;
            }

                .navbar-nav > li {
                    float: none;
                }

                    .navbar-nav > li > a {
                        padding-top: 10px;
                        padding-bottom: 10px;
                    }

            .collapse.in {
                display: block !important;
            }
        }
    </style>
</head>
<body style="padding-top: 50px; font-family: 'Comic Sans MS'">
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
                    <div class="navbar-form navbar-right animated bounceInDown">
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
                                <a id="btnLogin" class="btn btn-sm btn-default" style="width: 80px; font-size: 12px">Login</a>
                                <button type="button" class="btn btn-sm dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                    <span class="caret"></span>
                                    <span class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Action</a></li>
                                    <li><a href="#">Another action</a></li>
                                    <li><a href="#">Settings</a></li>
                                    <li role="separator" class="divider"></li>
                                    <li><a href="#" onclick="openNav()">Forget Password</a></li>
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
                        <div class="well h3 animated fadeInLeft">
                            <marquee behavior="alternate">Application</marquee>
                        </div>
                        <div id="accordion_pic" class="panel-group">

                            <div class="panel panel-success animated bounceInLeft">
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

                            <div class="panel panel-info animated fadeInLeft">
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

                            <div class="panel panel-danger animated bounceInLeft">
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

                            <div class="panel panel-warning animated fadeInLeft">
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
                        <div class="h2 animated fadeInRight">
                            <p>Create a new account</p>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success animated bounceInRight">
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
                                <div class="form-group has-success animated fadeInRight">
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
                                <div class="form-group has-success animated bounceInRight">
                                    <label>EmployeeCode</label>
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-globe"></span>
                                        </span>
                                        <asp:TextBox ID="textEmployeeCode" runat="server" placeholder="Enter your EmployeeCode" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-group has-success animated fadeInRight">
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
                                <div class="form-group has-success animated bounceInRight">
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
                                <div class="form-group has-success animated fadeInRight">
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
                        <div class="row animated fadeInRight">
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
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6 animated fadeInUp">
                            <h3>Website Name</h3>
                            <hr style="border: 1px solid; color: black">
                            <p>
                                Use this document as a way to quickly start any new project.
                                All you get is this text and a mostly barebones HTML document.
                            </p>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6 animated fadeInUp">
                            <h3>Usefull link</h3>
                            <hr style="border: 1px solid; color: black">
                            <table class="table" style="margin-top: 20px">
                                <tr class="animated fadeInUp">
                                    <td><a style="color: orange" href="#">IT solutions</a> </td>
                                </tr>
                                <tr class="animated fadeInUp">
                                    <td><a style="color: orange" href="#">E-commerce solutions</a> </td>
                                </tr>
                                <tr class="animated fadeInUp">
                                    <td><a style="color: orange" href="#">Mobile development</a> </td>
                                </tr>
                            </table>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6 animated fadeInUp">
                            <h3>Follow Us</h3>
                            <hr style="border: 1px solid; color: black">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/facebook.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Image/twitter.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Image/instagram.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Image/google.png" Style="width: 40px; height: 40px" />
                            <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Image/linkedin.png" Style="width: 40px; height: 40px" />
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6 animated fadeInUp">
                            <h3>Address</h3>
                            <hr style="border: 1px solid; color: black">
                            <div style="color: orange">
                                <p>46/1 Shukrabad, Dhanmondi.</p>
                                <p>Dhaka, Bangladesh</p>
                            </div>
                        </div>
                    </div>
                    <hr style="border: 1px solid; color: black" class="animated fadeInUp">
                    <p class="pull-right animated fadeInUp">&copy; <%: DateTime.Now.Year %> - Developed by <a style="color: red" target="_blank" href="https://www.facebook.com/profile.php?id=100004911679186">Redwan Hossain</a></p>
                </div>
            </div>
        </footer>
    </form>

    <div id="mySidenav" class="sidenav shadow_B" ng-app="forgotPasswordApp" ng-controller="forgotPasswordController">
        <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
        <div class="row">
            <div style="padding-left: 35px">
                <h3 style="color: orange">Forget Password</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-11">
                <div class="form-group has-error animated fadeInLeft" style="padding-left: 20px; padding-top: 10px;">
                    <label>Email</label>
                    <div class="input-group">
                        <span class="input-group-addon">
                            <span class="glyphicon glyphicon-envelope"></span>
                        </span>
                        <input type="text" ng-model="forgotPassword.Email" class="form-control" placeholder="Your Email Address" />

                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div style="padding-right: 46px;">
                <input id="sentForgotEmail" type="submit" ng-click="ForgotPassword()" style="float: right;" value="Retrive My Password" class="btn btn-sm btn-danger" />
            </div>
        </div>
    </div>
</body>
</html>

<script>
    function openNav() {
        document.getElementById("mySidenav").style.width = "350px";
    }

    function closeNav() {
        document.getElementById("mySidenav").style.width = "0";
    }
</script>
