<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IsPostBack_Example.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.ASP_Tutorial.ASP_1_To_10.IsPostBack_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
