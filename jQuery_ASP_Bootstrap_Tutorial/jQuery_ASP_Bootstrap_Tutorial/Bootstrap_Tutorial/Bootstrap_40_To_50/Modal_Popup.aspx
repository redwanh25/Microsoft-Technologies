<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modal_Popup.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_40_To_50.Modal_Popup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="../../jquery_Bootstrap_SweetAlert/jQuery/compressed/jquery-3.3.1.min.js"></script>
    <link href="../../jquery_Bootstrap_SweetAlert/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../jquery_Bootstrap_SweetAlert/Bootstrap/js/bootstrap.min.js"></script>

    <%--<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>--%>
    <script src="../../jquery_Bootstrap_SweetAlert/SweetAlert/sweetalert.min.js"></script>
    <style>
        .close {
            color: white;       /*&times; er color change korte hobe bootstrap er .close class k override korte hobe*/
            opacity: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div class="container">
            <div class="row">
                <div class="col-xs-12">

                    <%--aita jquery diye kora data-target="#loginModal" data-toggle="modal" use kora hoyni--%>
                    <input id="btnShowModal" type="button" value="button" class="btn btn-primary pull-left" />

                    <%--<input id="Button1" type="button" value="button" class="btn btn-primary pull-right" data-target="#loginModal" data-toggle="modal"/>--%>
                    <div class="modal fade" id="loginModal" tabindex="-1" data-backdrop="static" data-keyboard="false">
                        <div class="modal-dialog" style="width: 400px">
                            <%--class="modal-sm"--%>
                            <div class="modal-content" style="background-color: transparent; color: white">
                                <div class="modal-header">
                                    <button class="close" data-dismiss="modal">&times;</button>
                                    <h4 class="modal-title">Login </h4>
                                </div>
                                <div class="modal-body">

                                    <div class="form-group">
                                        <label>User Name </label>
                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Password </label>
                                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="modal-footer">
                                    <input id="login" type="button" value="Login" class="btn btn-primary btn-sm" />
                                    <%--<asp:Button ID="login" runat="server" Text="Login" class="btn btn-primary btn-sm" />--%>
                                    <%-- bal asp button dile sweet alert kaj kore na. %>
                                     <%--data-dismiss="modal" ta bad dioya hoise--%>
                                    <asp:Button ID="btnHideModal" runat="server" Text="Close" class="btn btn-primary btn-sm" />
                                </div>
                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>

        <br />
        <br />

        <div class="container">
            <div class="row">
                <div class="col-xs-12">

                    <input id="Button4" type="button" value="button" class="btn btn-primary pull-right" data-target="#loginModal1" data-toggle="modal" />
                    <div class="modal fade" id="loginModal1" tabindex="-1">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button class="close" data-dismiss="moda">&times;</button>
                                    <h4 class="modal-title">Login </h4>
                                </div>
                                <div class="modal-body">
                                    <div class="form-horizontal">
                                        <div class="form-group">
                                            <label class="control-label col-lg-2">Email </label>
                                            <div class=" col-lg-8">
                                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="control-label col-lg-2">Password </label>
                                            <div class=" col-lg-8">
                                                <asp:TextBox ID="TextBox6" runat="server" placeholder="Password" CssClass="form-control"></asp:TextBox>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button5" runat="server" Text="Login" class="btn btn-primary" />
                                    <asp:Button ID="Button6" runat="server" Text="Close" class="btn btn-primary" data-dismiss="modal" />
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
            $('#btnShowModal').click(function () {
                $('#loginModal').modal('show');
            });
            $('#btnHideModal').click(function () {
                $('#loginModal').modal('hide');
            });
            $('#login').click(function () {
                swal("Good job!", "You clicked the button!", "success");
                $('#loginModal').modal('hide');
            });
        });
    </script>
</body>
</html>
