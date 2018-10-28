<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation_Bar_Top.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_20_To_30.Navigation_Bar_Top" %>

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
        <nav class="navbar navbar-default navbar-inverse navbar-fixed-top" style="padding-left:30px; padding-right:30px">

                <div class="navbar-header">
                    <button id="Button1" type="button" value="button" class="navbar-toggle" data-toggle="collapse" data-target="#nnn">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>       
                </div>
                <div class="navbar-collapse collapse" id="nnn">
                    <ul class="nav navbar-nav">
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span> Home </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-earphone"></span> Donations </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span> Expenses </a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span> Reports </a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="glyphicon glyphicon-earphone"></span> Configure
                                <span class="caret"></span>
                            </a>
                            <ul class="dropdown-menu">
                                <li><a href="#"><span class="glyphicon glyphicon-home"></span> Users </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-earphone"></span> Templates </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-info-sign"></span> Funds </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-home"></span> User Roles </a></li>
                                <li><a href="#"><span class="glyphicon glyphicon-home"></span> Expense Categories </a></li>
                            </ul>
                        </li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>Subscribe </a></li>
                    </ul>
                    <div class="navbar-form navbar-right">
                        <div class="form-group">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="search"></asp:TextBox>
                            <asp:Button ID="Button2" runat="server" Text="Button" class="btn" />
                        </div>
                    </div>
                </div>

        </nav>
        <pre>
            When this was added to my website the problems above were
            fixed, but the ASP events weren't being fired, so that whether 
            I was using a master page or not my aspx page wasn't behaving.  
            This problem is fixed when the last script, js/contact_me.js, is removed. 
            Not a problem for me since my contacts page uses server-side aspx logic, 
            not bootsrap client-side javascript.

            With this fix I was able to put all the bootstrap code to 
            handle the navigation bar into my master page, making my .
            aspx pages much simpler and giving me a single place to write 
            the menu code, put in Google Analytics, and all the other stuff that
            one can use master pages for.   One very minor issue: in the original
            Bootstrap code the active page is highlighted in the menu with
            "class="active" being added to the html.  I don't know
            how to do this in this situation, but for me it doesn't
            matter if all the menu items show as default.

            When this was added to my website the problems above were fixed,
            but the ASP events weren't being fired, so that whether 
            I was using a master page or not my aspx page wasn't behaving.  
            This problem is fixed when the last script, js/contact_me.js, 
            is removed.  Not a problem for me since my contacts page uses 
            server-side aspx logic, not bootsrap client-side javascript.

            With this fix I was able to put all the bootstrap code to handle the navigation
            bar into my master page, making my .aspx pages much simpler
            and giving me a single place to write the menu code, put in
            Google Analytics, and all the other stuff that one can use
            master pages for.   One very minor issue: in the original
            Bootstrap code the active page is highlighted in the menu with
            "class="active" being added to the  html.  I don't know
            how to do this in this situation, but for me it doesn't matter
            if all the menu items show as default.
             When this was added to my website the problems above were
            fixed, but the ASP events weren't being fired, so that whether 
            I was using a master page or not my aspx page wasn't behaving.  
            This problem is fixed when the last script, js/contact_me.js, is removed. 
            Not a problem for me since my contacts page uses server-side aspx logic, 
            not bootsrap client-side javascript.

            With this fix I was able to put all the bootstrap code to 
            handle the navigation bar into my master page, making my .
            aspx pages much simpler and giving me a single place to write 
            the menu code, put in Google Analytics, and all the other stuff that
            one can use master pages for.   One very minor issue: in the original
            Bootstrap code the active page is highlighted in the menu with
            "class="active" being added to the  html.  I don't know
            how to do this in this situation, but for me it doesn't
            matter if all the menu items show as default.

            When this was added to my website the problems above were fixed,
            but the ASP events weren't being fired, so that whether 
            I was using a master page or not my aspx page wasn't behaving.  
            This problem is fixed when the last script, js/contact_me.js, 
            is removed.  Not a problem for me since my contacts page uses 
            server-side aspx logic, not bootsrap client-side javascript.

            With this fix I was able to put all the bootstrap code to handle the navigation
            bar into my master page, making my .aspx pages much simpler
            and giving me a single place to write the menu code, put in
            Google Analytics, and all the other stuff that one can use
            master pages for.   One very minor issue: in the original
            Bootstrap code the active page is highlighted in the menu with
            "class="active" being added to the html.  I don't know
            how to do this in this situation, but for me it doesn't matter
            if all the menu items show as default.
    </pre>
    </form>
</body>
</html>
