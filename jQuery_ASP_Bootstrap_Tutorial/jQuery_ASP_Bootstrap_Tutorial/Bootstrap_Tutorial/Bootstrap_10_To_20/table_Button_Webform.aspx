<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="table_Button_Webform.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_10_To_20.table_Webform" %>

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
                <div class="col-xs-12">
                    <table class="table table-striped table-bordered table-hover table-responsive">
                        <%--table-condensed--%>
                        <thead>
                            <tr class="success">
                                <td>ID</td>
                                <td>Name</td>
                                <td>Gender</td>
                                <td>Email</td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>john Major john Major</td>
                                <td>Male</td>
                                <td>john@gmail.com</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>john Major</td>
                                <td>Male</td>
                                <td>john@gmail.com</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>john Major john Major</td>
                                <td>Male</td>
                                <td>john@gmail.com</td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>john Major</td>
                                <td>Male</td>
                                <td>john@gmail.com</td>
                            </tr>
                            <tr>
                                <td>5</td>
                                <td>john Major</td>
                                <td>Male</td>
                                <td>john@gmail.com</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

        <hr />

        <asp:Button ID="Button1" runat="server" Text="Button" Class="btn btn-primary" />

        <hr />

        <asp:Button ID="Button2" runat="server" Text="Button" class="btn btn-danger btn-block" />

        <hr />

        <div class="row">
            <div class="col-lg-3">
                <asp:Button ID="Button3" runat="server" Text="Button" Class="btn btn-success" />
            </div>
            <div class="col-lg-3">
                <asp:Button ID="Button4" runat="server" Text="Button" Class="btn btn-default" />
            </div>
            <div class="col-lg-3">
                <asp:Button ID="Button5" runat="server" Text="Button" Class="btn btn-info" />
            </div>
            <div class="col-lg-3">
                <asp:Button ID="Button6" runat="server" Text="Button" Class="btn btn-warning" />
            </div>
        </div>

        <hr />

        <div class="row">
            <div class="col-lg-3">
                <asp:Button ID="Button7" runat="server" Text="Button" Class="btn btn-success btn-block" />
            </div>
            <div class="col-lg-3">
                <asp:Button ID="Button8" runat="server" Text="Button" Class="btn btn-default btn-block" />
            </div>
            <div class="col-lg-3">
                <asp:Button ID="Button9" runat="server" Text="Button" Class="btn btn-info btn-block" />
            </div>
            <div class="col-lg-3">
                <asp:Button ID="Button10" runat="server" Text="Button" CssClass="btn btn-warning btn-block" />
            </div>
        </div>
        <hr />
        <a href="#" class="btn btn-primary">Anchor button</a>
        <hr />
        <%--glyphicon use korte hole asp.net er button a linkbutton use korte hobe.. noile hobe na..--%>
        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-primary">
        <span class="glyphicon glyphicon-heart"></span> heart </asp:LinkButton>
        <hr />
        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-primary btn-lg">
        <span class="glyphicon glyphicon-search"></span> search</asp:LinkButton>
        <hr />
        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-primary">
        search <span class="glyphicon glyphicon-search"></span></asp:LinkButton>
    </form>
</body>
</html>
