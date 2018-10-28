<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

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
        <div class="container">
            <div class="row" style="margin-top: 50px">
                <input id="showEmployee" type="button" value="Show Employee" class="btn btn-primary" />
                <input id="hideEmployee" type="button" value="Hide Employee" class="btn btn-danger" />
            </div>
            <br />
            <div>
                <ul id="ulEmployee">
                </ul>
            </div>
        </div>
        <asp:Button ID="button" runat="server" Text="button" class="btn btn-primary" />

        <script type="text/javascript">
            //$(document).ready(function () {
            //});
            // er vitore function call kora jabe na. taile kaj korbe na.. er bahire call korte hobe.
            //function myClick() {
            //    alert('redwan');
            //}
            $(document).ready(function () {
                $('#button').click(function () {
                    alert('redwan hossain');
                });
            });
        </script>
    </form>

    <script type="text/javascript">
        $(document).ready(function () {
            var ulEmployee = $('#ulEmployee');
            $('#showEmployee').click(function () {
                $.ajax({
                    type: 'Get',
                    url: 'http://localhost:59705/api/employees/',    // aita cross domain so http://localhost:59705/ use korte hobe.
                    dataType: 'json',
                    success: function (data) {
                        ulEmployee.empty();
                        $.each(data, function (index, val) {
                            var fullName = val.first_Name + ' ' + val.last_Name;
                            ulEmployee.append('<li>' + fullName + '</li>');
                        });
                    }
                });
            });
            $('#hideEmployee').click(function () {
                ulEmployee.empty();
            });
        });
    </script>
</body>
</html>

