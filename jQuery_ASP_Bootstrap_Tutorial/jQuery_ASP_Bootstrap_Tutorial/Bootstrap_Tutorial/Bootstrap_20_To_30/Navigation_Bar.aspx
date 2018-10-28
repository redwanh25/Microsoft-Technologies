<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation_Bar.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_20_To_30.Navigation_Bar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--    be careful "bootstrap.min.js" er age "jquery-3.3.1.min.js" thakte hobe. noile onek kissu support korbe na.--%>
    <script src="../../jquery_Bootstrap_SweetAlert/jQuery/compressed/jquery-3.3.1.min.js"></script>
    <link href="../../jquery_Bootstrap_SweetAlert/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../jquery_Bootstrap_SweetAlert/Bootstrap/js/bootstrap.min.js"></script>
    <script src="../../jquery_Bootstrap_SweetAlert/SweetAlert/sweetalert.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <ul class="nav nav-tabs">
                        <li><a href="#">Home </a></li>
                        <li><a href="#">Donations </a></li>
                        <li><a href="#">Expenses </a></li>
                        <li><a href="#">Reports </a></li>
                        <li><a href="#">Configure </a></li>
                        <li><a href="#">Help </a></li>
                        <li><a href="#">About </a></li>
                    </ul>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-12">
                    <ul class="nav nav-pills">
                        <li><a href="#">Home </a></li>
                        <li><a href="#">Donations </a></li>
                        <li><a href="#">Expenses </a></li>
                        <li><a href="#">Reports </a></li>
                        <li><a href="#">Configure </a></li>
                        <li><a href="#">Help </a></li>
                        <li><a href="#">About </a></li>
                    </ul>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-12">
                    <ul class="nav nav-tabs">
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Home </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-earphone"></span>Donations </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Expenses </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Reports </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-earphone"></span>Configure </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Help </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>About </a></li>
                    </ul>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-12">
                    <ul class="nav nav-tabs nav-stacked">
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Home </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-earphone"></span>Donations </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Expenses </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Reports </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-earphone"></span>Configure </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Help </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>About </a></li>
                    </ul>
                </div>
            </div>

            <br />
            <br />

            <div class="row">
                <div class="col-lg-12">
                    <ul class="nav nav-tabs nav-justified">
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Home </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-earphone"></span>Donations </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Expenses </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Reports </a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-earphone"></span>Configure
                                <span class="caret"></span>
                            </a>
                            <ul class="dropdown-menu" style="width: 100%">
                                <li><a href="#"><span class="glyphicon glyphicon-home"></span>Users </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-earphone"></span>Templates </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Funds </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-home"></span>User Roles </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-home"></span>Expense Categories </a></li>
                            </ul>
                        </li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Help </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>About </a></li>
                    </ul>
                </div>
            </div>
            <br />
            <br />
            <div class="btn-group">
                <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                    Action <span class="caret"></span>
                </button>
                <ul class="dropdown-menu">
                    <li><a href="#">Action</a></li>
                    <li><a href="#">Another action</a></li>
                    <li><a href="#">Something else here</a></li>
                    <li role="separator" class="divider"></li>
                    <li><a href="#">Separated link</a></li>
                </ul>
            </div>

            <br />
            <br />
            <br />
            <br />

            <ul class="breadcrumb" style="background-color: silver">
                <li><a href="#">Action</a></li>
                <li><a href="#">Another action</a></li>
                <li><a href="#">Something else here</a></li>
                <li><a href="#">Separated link</a></li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-earphone"></span>Configure
                                <span class="caret"></span>
                    </a>
                    <ul class="dropdown-menu" style="width: 100%">
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Users </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-earphone"></span>Templates </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span>Funds </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>User Roles </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Expense Categories </a></li>
                    </ul>
                </li>
                <li><a href="#">Another action</a></li>
                <li><a href="#">Something else here</a></li>
            </ul>
        </div>
    </form>

</body>
</html>
