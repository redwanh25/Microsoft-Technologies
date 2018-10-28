<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users_Male_or_Female.aspx.cs" Inherits="WebApplication1.Users_Male_or_Female" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jQuery/compressed/jquery-3.3.1.min.js"></script>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <div class="container well">
            <div class="row">
                <div class="col-xs-12">
                    <div class="form-inline">
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="username" CssClass="h4"></asp:Label>
                            <asp:TextBox ID="username" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:Label ID="Label2" runat="server" Text="password" CssClass="h4"></asp:Label>
                            <asp:TextBox ID="password" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-xs-12">
                    <div>
                        <input id="Find" type="button" value="Show Employee" class="btn btn-primary" />
                        <input id="Hide" type="button" value="Hide Employee" class="btn btn-danger" />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-xs-5">
                    <table class="table table-bordered table-hover table-striped table-responsive h4 text-center">
                        <thead>
                            <tr class="success">
                                <td>Full Name</td>
                            </tr>
                        </thead>
                        <tbody id="tbody">

                        </tbody>
                    </table>
                </div>
            </div>
        </div>      
    </form>

    <script type="text/javascript">
        $(document).ready(function () {
            var tbody = $('#tbody');
            $('#Find').click(function () {
                var username = $('#username').val();
                var password = $('#password').val();
                $.ajax({
                    type: 'Get',
                    url: 'http://localhost:59705/api/users/',
                    dataType: 'json',
                    headers: {
                        'Authorization': 'Basic ' + btoa(username + ':' + password)
                    },
                    success: function (data) {
                        tbody.empty();
                        $.each(data, function (index, val) {
                            var fullname = val.first_Name + ' ' + val.last_Name;
                            tbody.append('<tr> <td>' + fullname + '</td> </tr>');
                        });
                    },
                    complete: function (jqXHR) {
                        if (jqXHR.status == 401) {
                            tbody.empty();
                            tbody.append('<tr> <td style="color:red">' + jqXHR.status + ' : ' + jqXHR.statusText + '</td> </tr>');
                        }
                    }
                });
            });
            $('#Hide').click(function () {
                tbody.empty();
            });
        });
    </script>
</body>
</html>
