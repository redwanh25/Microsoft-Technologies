<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AuthenticationBasedProject_API.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../JavaScriptFile/Login.js"></script>
    <script src="../JavaScriptFile/Register.js"></script>

    <style>
        .design {
            text-align: center;
            background-color: #DEEFD7;
            border-radius: 10px;
        }

        .designButton {
            text-align: right;
        }
    </style>
</head>
<body style="padding-top: 20px">
    <form id="form1" runat="server">
        <div class="col-md-5 col-md-offset-4">
            <div class="well">
                <div class="designButton" style="padding-bottom: 10px">
                    <asp:LinkButton ID="LinkButton3" Style="border-radius: 20px" runat="server" CssClass="btn btn-success" OnClick="LinkButton3_Click">
                        <img src="../Image/lock.png" style="margin-right: 0.2em" /> Register
                    </asp:LinkButton>
                </div>
                <div class="design col-lg-12">
                    <div class="col-lg-4">
                        <marquee width="100%" behavior="alternate">
                            <h4>Please Login</h4>
                        </marquee>
                    </div>
                    <div class="col-lg-4">
                        <marquee width="100%" behavior="alternate">
                            <img src="../Image/icons8-contacts-500.png" style="height: 50px; padding-left:50px" />
                        </marquee>
                    </div>
                    <div class="col-lg-4">
                        <marquee width="100%" behavior="alternate">
                            <h4>Please login</h4>
                        </marquee>
                    </div>
                </div>
                <div class="col-lg-12">
                    <br />
                </div>
                <div class="form-horizontal table">
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label3" runat="server" Text="User Name" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-6">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-pencil"></span>
                                </span>
                                <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter your User Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label2" runat="server" Text="Password" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-6">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-lock"></span>
                                </span>
                                <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter your Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="container">
                    <div style="text-align: center" class="col-md-2">
                        <input id="btnLogin" class="btn btn-success btn-block" type="button" value="Login" />
                    </div>
                </div>

                <br />
                <!--Bootstrap alert to display error message if the login fails-->
                <div id="divError" class="alert alert-danger collapse">
                    <a id="linkClose" href="#" class="close">&times;</a>
                    <div id="divErrorText"></div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
