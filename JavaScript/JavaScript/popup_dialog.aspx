<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="popup_dialog.aspx.cs" Inherits="JavaScript.popup_dialog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery/uncompressed/jquery-3.3.1.js"></script>
    <script src="bootstrap/js/bootstrap.js"></script>
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <%-- akta from er moddhe arekta from likha jay na. r asp:button aita akta from er moddhe e likhte hobe jei from a runat="server" ase. --%>
    <%-- ASP sara onclick kaj kore na. --%>
    <%--r jodi kono folder er moddhe .aspx / .html file rakhi taile abr bootstrap kaj kore na. i don't know why--%>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" data-target="#loginModal" data-toggle="modal" />
            <input class="btn btn-primary" id="Button1" data-target="#loginModal" data-toggle="modal" type="button" value="button" />
            <button onclick="but" data-target="#loginModal" data-toggle="modal" class="btn"> login</button>
        </div>

        <div class="container">
            <div class="row">
                <div class="modal" id="loginModal" tabindex="-1">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <label>Login</label>
                            </div>
                            <div class="modal-body">
                                <table style="margin-top: 20px; margin-bottom: 20px; border: 1px solid black">
                                    <tr>
                                        <td colspan="2" style="border-bottom: 1px solid black; text-align: center">
                                            <b>Login </b>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Email ID : </b>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="emailTextBox" placeholder="sample@gmail.com" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Password :</b>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="passwordTextBox" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="textLabel" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="Login" runat="server" Text="Login" />
                                        </td>
                                        <td align="right">
                                            <asp:Button ID="SignUp" runat="server" Text="Sign Up" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="modal-footer">

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
