<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AuthenticationBasedProject_API.RegistrationAndLoginPage.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
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
        <div class="col-md-6 col-md-offset-3">
            <div class="well">
                <div class="designButton" style="padding-bottom: 10px">
                    <asp:LinkButton ID="LinkButton1" Style="border-radius: 20px" runat="server" CssClass="btn btn-success">
                        <img src="../Image/search.png" style="margin-right: 0.2em" /> Google SignIn
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" Style="border-radius: 20px" runat="server" CssClass="btn btn-success">
                        <img src="../Image/facebook-logo.png" style="margin-right: 0.2em" /> Facebook SignIn
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" Style="border-radius: 20px" runat="server" CssClass="btn btn-success" OnClick="LinkButton3_Click">
                        <img src="../Image/lock.png" style="margin-right: 0.2em" /> Login
                    </asp:LinkButton>
                </div>
                <div class="design">
                    <marquee width="100%" behavior="alternate">
                            <h3>Please Register In</h3>
                            <img src="../Image/icons8-contacts-500 (1).png" style="height: 60px; padding-left:70px" /> 
                    </marquee>
                </div>
                <br />
                <div class="form-horizontal table">
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label3" runat="server" Text="User Name" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-5">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-pencil"></span>
                                </span>
                                <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter your User Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label5" runat="server" Text="Phone Number" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-5">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-phone"></span>
                                </span>
                                <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="Enter your Phone Number" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label6" runat="server" Text="User Self ID" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-5">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-globe"></span>
                                </span>
                                <asp:DropDownList ID="dropDownUserSelfId" class="form-control" runat="server">
                                    <asp:ListItem Text="Set UserSelfId" Value="-1"></asp:ListItem>
                                    <asp:ListItem Text="User One" Value="User_One"></asp:ListItem>
                                    <asp:ListItem Text="User Two" Value="User_Two"></asp:ListItem>
                                    <asp:ListItem Text="User Three" Value="User_Three"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label1" runat="server" Text="Email ID" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-5">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-envelope"></span>
                                </span>
                                <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your Email ID" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label2" runat="server" Text="Password" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-5">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-lock"></span>
                                </span>
                                <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter your Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group h4 has-success has-feedback">
                        <asp:Label ID="Label4" runat="server" Text="Confirm Password" CssClass="control-label col-lg-4"></asp:Label>
                        <div class="col-lg-5">
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-lock"></span>
                                </span>
                                <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="Enter your Confirm Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <%--<div class="container">
                    <div style="text-align: center" class="col-md-3">
                    <asp:LinkButton ID="btnRegister" Style="border-radius: 20px" class="btn btn-success btn-block" runat="server"><b>Register</b></asp:LinkButton>
                bal ai button kaj kore na.
                    </div>--%>
                <div class="container">
                    <div style="text-align: center" class="col-md-3">
                        <input id="btnRegister" class="btn btn-success btn-block" type="button" value="Register" />
                    </div>
                </div>

                <br />



                <!--Bootstrap modal dialog that shows up when regsitration is successful-->
                <div class="modal fade" tabindex="-1" id="successModal" data-keyboard="false" data-backdrop="static">
                    <div class="modal-dialog modal-md">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times; </button>
                                <h4 class="modal-title">Success</h4>
                            </div>
                            <div class="modal-body">
                                <h3 class="modal-title">Registration Successful!</h3>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-success" data-dismiss="modal">Close </button>
                            </div>
                        </div>
                    </div>
                </div>

                <!--Bootstrap alert to display any validation errors-->
                <div id="divError" class="alert alert-danger collapse">
                    <a id="linkClose" href="#" class="close">&times;</a>
                    <div id="divErrorText"></div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
