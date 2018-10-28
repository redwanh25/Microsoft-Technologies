<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormControl.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_20_To_30.FormControl" %>

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
        <div class="row" style="background-color: gray; padding-top: 6px; padding-bottom: 6px;">
            <div class="col-lg-12 col-md-12">
                <div class="form-inline" align="right" style="padding-right:10px">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Email" class="h4"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Password" class="h4"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Password" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Button2" runat="server" Text="Button" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
        <hr />
        <div class="container">
            <div class="row">
                <div class="col-lg-3">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                        <asp:ListItem>option 1</asp:ListItem>
                        <asp:ListItem>option 2</asp:ListItem>
                        <asp:ListItem>option 3</asp:ListItem>
                        <asp:ListItem>option 4</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-lg-4">
                    <div class="form-group">
                        <p>Email</p>
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <p>Password</p>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>

            <hr />

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Email" CssClass="control-label col-lg-2"></asp:Label>
                            <div class=" col-lg-6">
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Password" CssClass="control-label col-lg-2"></asp:Label>
                            <div class=" col-lg-6">
                                <asp:TextBox ID="TextBox6" runat="server" placeholder="Password" CssClass="form-control"></asp:TextBox>
                            </div>

                        </div>
                        <div class="form-group">
                            <div class="col-lg-6 col-lg-offset-2">
                                <asp:Button ID="Button3" runat="server" Text="Button" CssClass="btn btn-primary" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <hr />
       
        
    </form>
</body>
</html>
