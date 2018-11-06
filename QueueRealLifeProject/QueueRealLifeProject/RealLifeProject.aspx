<%@ Page Title="Real Life Project" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RealLifeProject.aspx.cs" Inherits="QueueRealLifeProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="jquery_Bootstrap_SweetAlert/jQuery/compressed/jquery-3.3.1.min.js"></script>
    <link href="jquery_Bootstrap_SweetAlert/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="jquery_Bootstrap_SweetAlert/Bootstrap/js/bootstrap.min.js"></script>
    <style>
        .padddingStyle{
            margin-top:15px;
            width:100%
            
            
        }
        .centerStyle{
            text-align:center
        }
    </style>

    <div class="container" style="min-width:580px">
        <div class="row">
            <h2><%: Title %></h2>
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-md-12">
                 <asp:Label ID="txtNextToken" runat="server" ForeColor="#009900" CssClass="form-control" Font-Size="Large"></asp:Label>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-4 col-sm-4 col-xs-4">
                <asp:Label ID="Label1" runat="server" Text="Counter 1" CssClass="h4 col-md-offset-3 col-sm-offset-3 col-xs-offset-3" ForeColor="#FF3300"></asp:Label>
                <asp:TextBox ID="txtCounter1" runat="server" CssClass="padddingStyle form-control" Font-Size="Large" ></asp:TextBox>
                <asp:Button ID="btnCounter1" runat="server" Text="Next" CssClass="padddingStyle btn btn-primary btn-sm" OnClick="btnCounter1_Click"/>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-4">
                <asp:Label ID="Label2" runat="server" Text="Counter 2" CssClass="h4 col-md-offset-3 col-sm-offset-3 col-xs-offset-3" ForeColor="#FF3300"></asp:Label>
                <asp:TextBox ID="txtCounter2" runat="server" CssClass="padddingStyle form-control" Font-Size="Large" ></asp:TextBox>
                <asp:Button ID="btnCounter2" runat="server" Text="Next" CssClass="padddingStyle btn btn-primary btn-sm" OnClick="btnCounter2_Click"/>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-4">
                <asp:Label ID="Label3" runat="server" Text="Counter 3" CssClass="h4 col-md-offset-3 col-sm-offset-3 col-xs-offset-3" ForeColor="#FF3300"></asp:Label>
                <asp:TextBox ID="txtCounter3" runat="server" CssClass="padddingStyle form-control" Font-Size="Large" ></asp:TextBox>
                <asp:Button ID="btnCounter3" runat="server" Text="Next" CssClass="padddingStyle btn btn-primary btn-sm" OnClick="btnCounter3_Click"/>
            </div>
        </div>
        <br />
        
        <br />
        <br />

        <div class="row">
            <div class="col-md-4 col-sm-4 col-xs-4">
                
            </div>
            <div class="col-md-4 col-sm-4 col-xs-4"> 
                <asp:ListBox ID="listTokens" runat="server" Width="100%" Rows="6" Font-Size="Large"></asp:ListBox>
                <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" CssClass="padddingStyle btn btn-danger btn-sm" OnClick="btnPrintToken_Click" />
            </div>
            <div class="col-md-4 col-sm-4 col-xs-4">
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-12">
                 <asp:Label ID="lblCurrentStatus" runat="server" ForeColor="#009900" CssClass="form-control" Font-Size="Large"></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>
