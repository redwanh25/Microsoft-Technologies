<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormValidation.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_20_To_30.FormValidation" %>

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
            <div class="row" style="margin-top: 10px">
                <div class="col-lg-12">
                    <div class="form-horizontal table">
                        <div class="form-group h4 has-success has-feedback">
                            <asp:Label ID="Label1" runat="server" Text="Eamil ID" CssClass="control-label col-lg-2"></asp:Label>
                            <div class="col-lg-5">
                                <asp:TextBox ID="EmailID" runat="server" placeholder="Enter your Email ID" CssClass="form-control"></asp:TextBox>
                                <span class="glyphicon glyphicon-ok form-control-feedback" style="font-size: 14px"></span>
                                <span class="help-block h6">Valid Email</span>
                            </div>
                        </div>
                        <div class="form-group h4 has-error has-feedback">
                            <asp:Label ID="Label2" runat="server" Text="Password" CssClass="control-label col-lg-2"></asp:Label>
                            <div class="col-lg-5">
                                <asp:TextBox ID="Password" runat="server" placeholder="Enter your Password" CssClass="form-control"></asp:TextBox>
                                <span class='glyphicon glyphicon-remove form-control-feedback' style='font-size: 14px'></span>
                                <span class='help-block h6'>Wrong Password</span>
                            </div>
                        </div>
                        <div class="form-group ">
                            <div class="col-lg-5 col-lg-offset-2">
                                <input id="SignUP" runat="server" type="button" value="Sign UP" class="btn btn-primary" onclick="fun()" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <hr />

        <div class="container">
            <div class="row" style="margin-top: 10px">
                <div class="col-lg-12">
                    <div class="form-horizontal table">
                        <div class="form-group h4 has-success has-feedback">
                            <asp:Label ID="Label3" runat="server" Text="Eamil ID" CssClass="control-label col-lg-2"></asp:Label>
                            <div class="col-lg-5">
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-pushpin"> </span>
                                    </span>
                                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your Email ID" CssClass="form-control"></asp:TextBox>
                                </div>
                                <span class="glyphicon glyphicon-ok form-control-feedback" style="font-size: 14px"></span>
                                <span class="help-block h6">Valid Email</span>
                            </div>
                        </div>
                        <div class="form-group h4 has-error has-feedback">
                            <asp:Label ID="Label4" runat="server" Text="Password" CssClass="control-label col-lg-2"></asp:Label>
                            <div class="col-lg-5">
                                <div class="input-group">
                                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter your Password" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-addon">A</span>
                                </div>
                                <%--<span class='glyphicon glyphicon-remove form-control-feedback' style='font-size: 14px'></span>--%>
                                <span class='help-block h6'>Wrong Password</span>
                            </div>
                        </div>
                        <div class="form-group ">
                            <div class="col-lg-5 col-lg-offset-2">
                                <input id="Button1" runat="server" type="button" value="Sign UP" class="btn btn-primary" onclick="fun()" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
