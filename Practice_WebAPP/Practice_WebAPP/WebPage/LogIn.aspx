<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Practice_WebAPP.WebPage.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="31px" style="margin-top: 0px; margin-bottom: 0px" Width="232px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Height="27px" OnClick="Button1_Click" Text="Insert" Width="80px" />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="30px" style="margin-left: 0px; margin-bottom: 0px" Width="233px"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" Height="27px" OnClick="Button2_Click" Text="search" Width="80px" />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="240px">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <asp:GridView ID="tblPerson" runat="server">
        </asp:GridView>
        <br />
        <asp:GridView ID="tblDepartment" runat="server">
        </asp:GridView>
        <br />
        <asp:GridView ID="tblEmployee" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
