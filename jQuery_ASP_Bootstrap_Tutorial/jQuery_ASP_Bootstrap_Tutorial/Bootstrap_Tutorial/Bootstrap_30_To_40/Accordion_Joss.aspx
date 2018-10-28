<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accordion_Joss.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_30_To_40.Accordion_Joss" %>

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
        <div class="container">
            <div class="row">
                <div class="col-lg-4">

                    <div class="well">
                        <input id="btnExpand" type="button" value="Expand All" class="btn btn-primary" />
                        <input id="btnCollapse" type="button" value="Collapse All" class="btn btn-primary" />
                    </div>

                    <div id="accordion" class="panel-group">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <a href="#panelBodyOne" data-toggle="collapse" data-parent="#accordion">
                                        <span class="glyphicon glyphicon-menu-up"></span>
                                        Asia
                                    </a>
                                </div>
                            </div>
                            <%--"in" mane oi ta expand thakbe. r "in" na mane oi ta collapse thakbe.
                            but, jokhon amra expand kori tokhon oi ta automatic in hoye jay.
                            abr jokhon amra collapse kori tokhon oi ta automatic in gayeb hoye jay.
                            please check inspect element--%>
                            <div id="panelBodyOne" class="collapse panel-collapse in">
                                <div class="panel-body">
                                    <ul>
                                        <li>India</li>
                                        <li>China</li>
                                        <li>Japan</li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <a href="#panelBodyTwo" data-toggle="collapse" data-parent="#accordion">
                                        <span class="glyphicon glyphicon-menu-down"></span>
                                        North America
                                    </a>
                                </div>
                            </div>
                            <div id="panelBodyTwo" class="collapse panel-collapse">
                                <div class="panel-body">
                                    <ul>
                                        <li>USA</li>
                                        <li>Canada</li>
                                        <li>Maxico</li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <a href="#panelBodyThree" data-toggle="collapse" data-parent="#accordion">
                                        <span class="glyphicon glyphicon-menu-down"></span>
                                        Europe
                                    </a>
                                </div>
                            </div>
                            <div id="panelBodyThree" class="collapse panel-collapse">
                                <div class="panel-body">
                                    <ul>
                                        <li>UK</li>
                                        <li>France</li>
                                        <li>Genrmany</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-lg-8">
                    <div id="accordion_pic" class="panel-group">

                        <div class="panel panel-success">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <input id="Button1" type="button" value="Redwan Hossain Varsity" data-target="#panelBodyOne1" data-toggle="collapse" data-parent="#accordion_pic" class="btn btn-success"/>
                                    <%--<a href="#panelBodyOne1" data-toggle="collapse" data-parent="#accordion_pic"> Redwan Hossain Varsity
                                    </a>--%>
                                </div>
                            </div>
                            <div id="panelBodyOne1" class="collapse panel-collapse">
                                <div class="panel-body">
                                    <img src="../../image/IMG_20180517_022534-1.jpg" class="img-responsive" />
                                </div>
                            </div>
                        </div>

                        <div class="panel panel-info">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <input id="Button2" type="button" value="Redwan Hossain Biye" data-target="#panelBodyTwo2" data-toggle="collapse" data-parent="#accordion_pic" class="btn btn-info"/>
                                    <%--<a href="#panelBodyTwo2" data-toggle="collapse" data-parent="#accordion_pic"> Redwan Hossain Biye
                                    </a>--%>
                                </div>
                            </div>
                            <div id="panelBodyTwo2" class="collapse panel-collapse">
                                <div class="panel-body">
                                    <img src="../../image/HIM_1338.jpg" class="img-responsive"/>
                                </div>
                            </div>
                        </div>

                        <div class="panel panel-danger">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <input id="Button3" type="button" value="Redwan Hossain Bogra" data-target="#panelBodyThree3" data-toggle="collapse" data-parent="#accordion_pic" class="btn btn-danger"/>
                                    <%--<a href="#panelBodyThree3" data-toggle="collapse" data-parent="#accordion_pic"> Redwan Hossain Bogra
                                    </a>--%>
                                </div>
                            </div>
                            <div id="panelBodyThree3" class="collapse panel-collapse">
                                <div class="panel-body">
                                    <img src="../../image/redwan_enan.jpg" class="img-responsive" />
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
            $('.collapse').on('shown.bs.collapse', function () {
                $(this).parent().find('.glyphicon-menu-down').removeClass('glyphicon-menu-down').addClass('glyphicon-menu-up');
            }).on('hidden.bs.collapse', function () {
                $(this).parent().find('.glyphicon-menu-up').removeClass('glyphicon-menu-up').addClass('glyphicon-menu-down');
            });

            //shob gula
            //$('#btnExpand').click(function () {
            //    $('.collapse.panel-collapse').collapse('show');
            //});
            //$('#btnCollapse').click(function () {
            //    $('.collapse.panel-collapse.in').collapse('hide');
            //});

            //shob gula na... shudhu right side er ta. ei jonno id niye kaj kora hoise.
            $('#btnExpand').click(function () {
                $('#panelBodyOne').collapse('show');
            }).click(function () {
                $('#panelBodyTwo').collapse('show');
            }).click(function () {
                $('#panelBodyThree').collapse('show');
            });

            $('#btnCollapse').click(function () {
                $('#panelBodyOne').collapse('hide');
            }).click(function () {
                $('#panelBodyTwo').collapse('hide');
            }).click(function () {
                $('#panelBodyThree').collapse('hide');
            });
        });
    </script>
</body>
</html>
