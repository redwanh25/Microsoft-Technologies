<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AuthenticationBasedProject_API.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
        <title></title>
        <script src="../Scripts/jquery-3.3.1.min.js"></script>
        <script src="../Scripts/bootstrap.min.js"></script>
        <link href="../Content/bootstrap.min.css" rel="stylesheet" />
        <script src="../JavaScriptFile/Login.js"></script>
    </head>
    <body>
        <form runat="server">
            <div class="container">
                <div class="row">

                    <h1>Welcome To the Main Page</h1>
                    <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                </div>
            </div>
        </form>
    </body>
    </html>
</asp:Content>
