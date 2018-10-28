<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabs_Plugin.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_40_To_50.Tabs_Plugin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../jquery_Bootstrap_SweetAlert/jQuery/compressed/jquery-3.3.1.min.js"></script>
    <link href="../../jquery_Bootstrap_SweetAlert/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../jquery_Bootstrap_SweetAlert/Bootstrap/js/bootstrap.min.js"></script>
    <script src="../../jquery_Bootstrap_SweetAlert/SweetAlert/sweetalert.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="well">



                        <div class="pre-scrollable">
                            <ul class="nav nav-tabs">
                                <li><a href="#homeTab" data-toggle="tab" class="active">Home</a></li>
                                <li class="dropdown">
                                    <a href="#" data-toggle="dropdown" class="dropdown-toggle">Configure
                                    <span class="caret"></span>
                                    </a>

                                    <ul class="dropdown-menu">
                                        <li><a href="#usersTab" data-toggle="tab">Users </a></li>
                                        <li><a href="#templatesTab" data-toggle="tab">Templates </a></li>
                                        <li><a href="#fundsTab" data-toggle="tab">Funds </a></li>
                                    </ul>
                                </li>
                                <li><a href="#helpTab" data-toggle="tab">Help </a></li>
                                <li><a href="#aboutTab" data-toggle="tab">About </a></li>
                            </ul>
                            <div class="tab-content">
                                <div id="homeTab" class="tab-pane active">
                                    <h3>Home Page </h3>
                                    <p>Home Page Content</p>
                                    <p>Home Page Content</p>
                                    <p>Home Page Content</p>
                                </div>
                                <div id="usersTab" class="tab-pane">
                                    <h3>Users Page </h3>
                                    <p>Users Page Content</p>
                                    <p>Users Page Content</p>
                                    <p>Users Page Content</p>
                                </div>
                                <div id="templatesTab" class="tab-pane">
                                    <h3>Templates Page </h3>
                                    <p>Templates Page Content</p>
                                    <p>Templates Page Content</p>
                                    <p>Templates Page Content</p>
                                </div>
                                <div id="fundsTab" class="tab-pane">
                                    <h3>Home Page </h3>
                                    <p>Funds Page Content</p>
                                    <p>Funds Page Content</p>
                                    <p>Funds Page Content</p>
                                </div>
                                <div id="helpTab" class="tab-pane">
                                    <h3>Help Page </h3>
                                    <p>Help Page Content</p>
                                    <p>Help Page Content</p>
                                    <p>Help Page Content</p>
                                </div>
                                <div id="aboutTab" class="tab-pane">
                                    <h3>About Page </h3>
                                    <div class="row">
                                        <div class="panel panel-default">
                                            <div class="panel-heading">
                                                <%--<asp:Button ID="toggleButton" runat="server" Text="Toggle Button" class="btn btn-primary" />--%>
                                                <input id="toggleButton" type="button" value="Toggle Button" class="btn btn-primary" />
                                                <input id="showButton" type="button" value="Show Button" class="btn btn-success" />
                                                <input id="hideButton" type="button" value="Hide Button" class="btn btn-danger" />
                                            </div>
                                            <div class="panel-body collapse in" id="imageGallery">
                                                <div class="col-xs-4">
                                                    <div class="thumbnail">
                                                        <a href="../../image/next%20upload%20pic.jpg">
                                                            <img src="../../image/next%20upload%20pic.jpg" style="height: 200px" />
                                                        </a>
                                                        <div class="caption">
                                                            <h3>Thumbnail label</h3>
                                                            <p>
                                                                Cras justo odio, dapibus ac facilisis in,
                                    egestas eget quam. Donec id elit non mi porta
                                    gravida at eget metus. Nullam id dolor id nibh
                                    ultricies vehicula ut id elit.
                                                            </p>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-xs-4">
                                                    <div class="thumbnail">
                                                        <a href="../../image/redwan_enan.jpg">
                                                            <img src="../../image/redwan_enan.jpg" style="height: 200px" />
                                                        </a>
                                                        <div class="caption">
                                                            <h3>Thumbnail label</h3>
                                                            <p>
                                                                Cras justo odio, dapibus ac facilisis in,
                                    egestas eget quam. Donec id elit non mi porta
                                    gravida at eget metus. Nullam id dolor id nibh
                                    ultricies vehicula ut id elit.
                                                            </p>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-xs-4">
                                                    <div class="thumbnail">
                                                        <a href="../../image/IMG_20180517_022534-1.jpg">
                                                            <img src="../../image/IMG_20180517_022534-1.jpg" style="height: 200px" />
                                                        </a>
                                                        <div class="caption">
                                                            <h3>Thumbnail label</h3>
                                                            <p>
                                                                Cras justo odio, dapibus ac facilisis in,
                                    egestas eget quam. Donec id elit non mi porta
                                    gravida at eget metus. Nullam id dolor id nibh
                                    ultricies vehicula ut id elit.
                                                            </p>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {

            $('#toggleButton').click(function () {
                $('#imageGallery').collapse('toggle');
            });
            $('#showButton').click(function () {
                $('#imageGallery').collapse('show');
            });
            $('#hideButton').click(function () {
                $('#imageGallery').collapse('hide');
            });

            //$('#imageGallery').on('show.bs.collapse', function () {
            //    alert("show-bs-collapse");
            //});
            //$('#imageGallery').on('shown.bs.collapse', function () {
            //    alert("shown-bs-collapse");
            //});
            //$('#imageGallery').on('hide.bs.collapse', function () {
            //    alert("hide-bs-collapse");
            //});
            //$('#imageGallery').on('hidden.bs.collapse', function () {
            //    alert('hidden-bs-collapse');
            //});
        });
    </script>
</body>
</html>
