﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionState_2.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.ASP_Tutorial.ASP_1_To_10.SessionState_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go To SessionState_1" />
        </div>
    </form>
</body>
</html>
