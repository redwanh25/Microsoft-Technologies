<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterAndLogin.aspx.cs" Inherits="DIU_CPC_BlueDivision.RegistrationAndLoginPage.RegisterAndLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />

    <%--<link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />--%>
    <link rel="icon" type="image/png" href="~/Image/cpc_logo_xxl.png" />
    <title>Login Page</title>
    <script src="../jquery_Bootstrap_SweetAlert_IHover_Animation/jQuery/uncompressed/jquery-3.3.1.js"></script>
    <script src="../jquery_Bootstrap_SweetAlert_IHover_Animation/SweetAlert/sweetalert.min.js"></script>
    <link href="../jquery_Bootstrap_SweetAlert_IHover_Animation/Animate.css" rel="stylesheet" />
    <script src="../jquery_Bootstrap_SweetAlert_IHover_Animation/Bootstrap/js/bootstrap.min.js"></script>
    <link href="../jquery_Bootstrap_SweetAlert_IHover_Animation/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <%--<script src="../JavaScriptFile/Register.js"></script>--%>
    <%--<script src="../JavaScriptFile/Login.js"></script>--%>

    <script src="../ForgetPasswordHTML/AngularJS/angular.js"></script>
    <script src="../ForgetPasswordHTML/AngularJS/forgot-password.js"></script>


    <style>
        .sidenav {
            height: 200px; /*30%*/
            width: 0;
            position: fixed;
            z-index: 1;
            top: 70px;
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
            /*cursor: url('http://csscursor.info/source/santahand.png'), default;*/
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

    <%--for progressbar--%>
    <style type="text/css">
        .modal1 {
            position: fixed;
            z-index: 999;
            height: 100%;
            width: 100%;
            top: 0;
            background-color: Black;
            filter: alpha(opacity=60);
            opacity: 0.6;
            -moz-opacity: 0.8;
        }

        .center {
            z-index: 1000;
            margin: 300px auto;
            padding: 10px;
            width: 110px;
            height: 110px;
            background-color: White;
            border-radius: 10px;
            filter: alpha(opacity=100);
            opacity: 1;
            -moz-opacity: 1;
        }

            .center img {
                height: 90px;
                width: 90px;
            }
    </style>

</head>
<body style="padding-top: 50px; font-family: Lora" oncontextmenu="return false;">
    <form id="form1" runat="server">
        <nav class="navbar navbar-default navbar-fixed-top shadow_B">
            <div class="container">
                <div class="navbar-header">
                    <button id="Button1" type="button" value="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand zoom-effect" style="font-size: 30px" href="#">
                        <img height="30" class="animated bounceInLeft" id="imgnav" src="../Image/cpc_logo_xxl.png" />
                    </a>
                    <a class="navbar-brand zoom-effect" style="padding-left: 30px; font-size: 15px;" href="http://daffodilvarsity.edu.bd/">Visit Our WebSite </a>
                </div>
                <div class="navbar-collapse collapse">

                    <div class="navbar-form navbar-right animated bounceInDown">
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon" style="height: 10px">
                                    <span class="glyphicon glyphicon-user"></span>
                                </span>
                                <asp:TextBox ID="txtUserNameLogin" runat="server" placeholder="Enter your UserName" CssClass="form-control" Height="31"></asp:TextBox>
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
                                <asp:TextBox ID="txtPasswordLogin" runat="server" placeholder="Enter your Password" CssClass="form-control" TextMode="Password" Height="31"></asp:TextBox>
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

        <div style="display: none;" class="modal1" id="loaderDiv">
            <div class="center">
                <img src="../Image/loader4.gif" />
                <%--<asp:Image ID="Image1" ImageUrl="../Image/loader.gif" AlternateText="Processing" runat="server" />--%>
            </div>
        </div>

        <div style="background-color: #E8EAED">
            <br />
            <br />
            <div class="container">
                <div class="row">
                    <div class="col-lg-4 col-md-5 col-sm-12 col-xs-12">
                        <div class="well h3 animated fadeInLeft" align="center">
                            <marquee behavior="alternate">Application</marquee>
                        </div>
                        <div id="accordion_pic" class="panel-group">
                            <div class="panel panel-success animated bounceInLeft">
                                <div class="panel-heading">
                                    <div class="panel-title">
                                        <a href="#panelBodyOne1" data-toggle="collapse" data-parent="#accordion_pic"><b>Who Can Use This Application</b>
                                            <span class="glyphicon glyphicon-menu-up pull-right"></span>
                                        </a>
                                    </div>
                                </div>
                                <div id="panelBodyOne1" class="collapse in panel-collapse">
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
                                            <span class="glyphicon glyphicon-menu-down pull-right"></span>
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
                                            <span class="glyphicon glyphicon-menu-down pull-right"></span>
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
                                            <span class="glyphicon glyphicon-menu-down pull-right"></span>
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
                    <%
                        string showReg = ConfigurationManager.AppSettings["ShowSupAdminRegForm"].ToString();
                        bool show = Convert.ToBoolean(showReg);          // false dile super admin er registration ta hide hobe login page a
                        if (show)                   // ture dile super admin er registration ta open hobe login page a
                        {
                    %>
                    <%--============================================================--%>

                    <div class="col-lg-7 col-md-7 col-sm-12 col-xs-12 col-lg-offset-1">
                        <div class="h2 animated fadeInRight">
                            <p>
                                Create A New Super Admin Account
                                <input id="buttonLock" type="button" value="Lock" class="btn btn-default" style="display: none" />
                            </p>
                        </div>
                        <br />
                        <div class="row" id="unlockCode">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 animated bounceInRight">
                                <div class="form-group has-error">
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-lock"></span>
                                        </span>
                                        <input id="textSecureCodeSubmit" type="password" class="form-control" placeholder="Enter Unlock Code" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12  animated fadeInRight">
                                <div class="form-group">
                                    <input id="buttonSecureCodeSubmit" type="button" value="Unlock Registration Form" class="btn btn-default" />
                                </div>
                            </div>
                        </div>
                        <div class="row" id="unlockCode1">
                            <div class=" col-lg-offset-2 col-lg-6 col-md-offset-2 col-md-6 col-sm-offset-2 col-sm-6 col-xs-offset-2 col-xs-8 animated bounceInRight">
                                <img width="300" src="../Image/Lock3.gif" class="img-responsive" />
                            </div>
                        </div>

                        <div style="display: none" id="registrationId">
                            <div class="row">
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <div class="form-group has-success animated bounceInRight">
                                        <label>User Name</label>
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <span class="glyphicon glyphicon-user"></span>
                                            </span>
                                            <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter UserName" CssClass="form-control"></asp:TextBox>
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
                                <%--<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <div class="form-group has-success animated bounceInRight">
                                        <label>SecureCode</label>
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <span class="glyphicon glyphicon-globe"></span>
                                            </span>
                                            <asp:TextBox ID="textSecureCode" runat="server" placeholder="Enter your SecureCode" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>--%>
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

                    <%--============================================================--%>
                    <%  
                        }
                        else
                        {
                    %>

                    <div class="col-lg-7 col-md-7 col-sm-12 col-xs-12 col-lg-offset-1">
                        <br /><br /><br />
                        <h1>Computer Programming Club (CPC)</h1>
                        <div class="row" id="unlockCode2">
                            <div class=" col-lg-offset-2 col-lg-6 col-md-offset-2 col-md-6 col-sm-offset-2 col-sm-6 col-xs-offset-2 col-xs-8 animated bounceInRight">
                                <img width="300" src="../Image/Lock3.gif" class="img-responsive" />
                            </div>
                        </div>
                        <br />
                    </div>

                    <%
                        }
                    %>
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
                            <h4>Website Name</h4>
                            <hr style="border: .5px solid; color: black">
                            <p>
                                Use this document as a way to quickly start any new project.
                                All you get is this text and a mostly barebones HTML document.
                            </p>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6 animated fadeInUp">
                            <h4>Usefull link</h4>
                            <hr style="border: .5px solid; color: black">
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
                            <h4>Follow Us</h4>
                            <hr style="border: .5px solid; color: black">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/facebook.png" Style="width: 25px; height: 25px" />
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Image/twitter.png" Style="width: 25px; height: 25px" />
                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Image/instagram.png" Style="width: 25px; height: 25px" />
                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Image/google.png" Style="width: 25px; height: 25px" />
                            <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Image/linkedin.png" Style="width: 25px; height: 25px" />
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6 animated fadeInUp">
                            <h4>Address</h4>
                            <hr style="border: .5px solid; color: black">
                            <div style="color: orange">
                                <p>46/1 Shukrabad, Dhanmondi.</p>
                                <p>Dhaka, Bangladesh</p>
                            </div>
                        </div>
                    </div>
                    <hr style="border: .5px solid; color: black" class="animated fadeInUp">
                    <p class="pull-right" style="font-size: 17px">&copy; <%: DateTime.Now.Year %> - Developed by <a style="color: orange" target="_blank" href="https://www.facebook.com/profile.php?id=100004911679186">Redwan Hossain</a>, <a style="color: orange" target="_blank" href="https://www.facebook.com/fhwasi">Fuad Wasi </a>, <a style="color: orange" target="_blank" href="https://www.facebook.com/profile.php?id=100004191497770">Sharar Khan</a></p>
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

<script type="text/javascript">
    $(document).ready(function () {
        $('#buttonSecureCodeSubmit').click(function () {
            $.ajax({
                url: '/Controllers/UnlockRegistrationForm/Unlock',
                method: 'POST',
                data: {
                    secureCode: $('#textSecureCodeSubmit').val()
                },
                success: function (data) {
                    if (data.status == "Success") {
                        $('#registrationId').show();
                        $('#unlockCode').hide();
                        $('#unlockCode1').hide();
                        //$('#buttonLock').show();
                    }
                    else {
                        swal("Unlock Failed!", "May Be Your SecureCode Is Incorrect!", "error");
                    }
                },
                error: function (jqXHR) {
                    swal("Error!", "Something Went Wrong!", "error");
                }
            });
        });
    });
    //$(document).ready(function () {
    //    $('#buttonLock').click(function () {
    //        $('#registrationId').hide();
    //        $('#unlockCode').show(); 
    //        $('#unlockCode1').show();
    //        $('#buttonLock').hide();
    //    });
    //});
</script>

<script>
    function openNav() {
        document.getElementById("mySidenav").style.width = "350px";
    }

    function closeNav() {
        document.getElementById("mySidenav").style.width = "0";
    }
</script>

<script>
    window.addEventListener("keydown", checkKeyPress, false);
    function checkKeyPress(key) {
        if (key.keyCode == "13" && $('#txtUserNameLogin').val() != '' && $('#txtPasswordLogin').val() != '') {
            $('#btnLogin').trigger('click');
            event.preventDefault();         // aita dile page refresh nibe na Enter press korle.
        }
        else if (key.keyCode == "13" && $('#txtPassword').val() != '' && $('#txtConfirmPassword').val() != '') {
            $('#btnRegister').trigger('click');
            event.preventDefault();         // aita dile page refresh nibe na Enter press korle.
        }
        else if (key.keyCode == "13" && $('#textSecureCodeSubmit').val() != '') {
            $('#buttonSecureCodeSubmit').trigger('click');
            event.preventDefault();         // aita dile page refresh nibe na Enter press korle.
        }
    }
</script>

<%--login.js file er code ai khane ase. aita aikhane na dile gif ta kaj kore na.. i don't khow why..--%>
<script>
    $(document).ready(function () {
        $('#btnLogin').click(function () {
            $('#loaderDiv').show();
            $.ajax({
                // Post username, password & the grant type to /token
                url: '/token',
                method: 'POST',
                contentType: 'application/json',
                data: {
                    userName: $('#txtUserNameLogin').val(),
                    password: $('#txtPasswordLogin').val(),
                    grant_type: 'password'
                },

                success: function (response) {
                    localStorage.setItem("accessTokenForDIU_CPC_BlueDivision", response.access_token);
                    localStorage.setItem("userName1", response.userName);
                    var root = location.protocol + '//' + location.host;
                    window.location.href = root + "/Home/Index";
                    $('#loaderDiv').hide();
                    //window.location.href = "http://localhost:64491/Home/Index";
                },
                // Display errors if any in the Bootstrap alert <div>
                error: function (jqXHR) {
                    swal("Login Failed!", "May Be Your Username Or Password Is Incorrect!", "error");
                    $('#loaderDiv').hide();
                }
            });
        });
    });
</script>

<%--<script>
    $(document).ready(function () {
        $(document).keydown(function (objEvent) {
            (objEvent) ? keycode = objEvent.keyCode : keycode = event.keyCode;
            if (keycode == 13) {
                //alert('redwan');
            }
        });
    });
</script>--%>

<%--register.js file er code ai khane ase. aita aikhane na dile gif ta kaj kore na.. i don't khow why..--%>
<%--<script>
    $(document).ready(function () {
        //Close the bootstrap alert
        $('#linkCloseRegister').click(function () {
            $('#divErrorRegister').hide('fade');
        });

        // Save the new user details
        $('#btnRegister').click(function () {
            $.ajax({
                url: '/Controllers/UnlockRegistrationForm/UnlockReg',
                method: 'POST',
                data: {
                    secureCode: $('#textSecureCode').val()
                },
                success: function (data) {
                    if (data.status == "Success") {
                        $('#loaderDiv').show();
                        $.ajax({
                            url: '/api/Account/SuperAdminRegister',
                            method: 'POST',
                            data: {
                                userName: $('#txtUserName').val(),
                                phoneNumber: $('#txtPhoneNumber').val(),
                                secureCode: $('#textSecureCode').val(),
                                email: $('#txtEmail').val(),
                                password: $('#txtPassword').val(),
                                confirmPassword: $('#txtConfirmPassword').val(),
                            },
                            success: function () {
                                swal("Registration Successful!", "Thank You For Registration. Now You Can Login.", "success");
                                $('#divErrorRegister').hide();
                                $('#loaderDiv').hide();
                            },
                            error: function (jqXHR) {
                                $('#divErrorTextRegister').text(jqXHR.responseText);
                                $('#divErrorRegister').show('fade');
                                $('#loaderDiv').hide();
                            }
                        });
                    }
                    else {
                        $('#divErrorTextRegister').text("Please Enter A Valid SecureCode");
                        $('#divErrorRegister').show('fade');
                    }
                },
                error: function (jqXHR) {
                    swal("Error!", "Something Went Wrong!", "error");
                }
            });
        });
    });
</script>--%>

<script>
    $(document).ready(function () {
        //Close the bootstrap alert
        $('#linkCloseRegister').click(function () {
            $('#divErrorRegister').hide('fade');
        });

        // Save the new user details
        $('#btnRegister').click(function () {
            $('#loaderDiv').show();
            $.ajax({
                url: '/api/Account/SuperAdminRegister',
                method: 'POST',
                data: {
                    userName: $('#txtUserName').val(),
                    phoneNumber: $('#txtPhoneNumber').val(),
                    //secureCode: $('#textSecureCode').val(),
                    email: $('#txtEmail').val(),
                    password: $('#txtPassword').val(),
                    confirmPassword: $('#txtConfirmPassword').val(),
                },
                success: function () {
                    swal("Registration Successful!", "Thank You For Registration. Now You Can Login.", "success");
                    $('#divErrorRegister').hide();
                    $('#loaderDiv').hide();
                },
                error: function (jqXHR) {
                    $('#divErrorTextRegister').text(jqXHR.responseText);
                    $('#divErrorRegister').show('fade');
                    $('#loaderDiv').hide();
                }
            });
        });
    });
</script>

<script>
    $(document).ready(function () {
        $('.collapse').on('shown.bs.collapse', function () {
            $(this).parent().find('.glyphicon-menu-down').removeClass('glyphicon-menu-down').addClass('glyphicon-menu-up');
        }).on('hidden.bs.collapse', function () {
            $(this).parent().find('.glyphicon-menu-up').removeClass('glyphicon-menu-up').addClass('glyphicon-menu-down');
        });
    });
</script>

