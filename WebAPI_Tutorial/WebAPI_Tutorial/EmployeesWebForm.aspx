<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesWebForm.aspx.cs" Inherits="WebAPI_Tutorial.EmployeesWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
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
        <asp:Button ID="button" runat="server" Text="button" class="btn btn-primary" OnClientClick="myClick()" />

        <script type="text/javascript">
            //$(document).ready(function () {
            //});
            // er vitore function call kora jabe na. taile kaj korbe na.. er bahire call korte hobe.
            function myClick() {
                alert('redwan');
            }
        </script>
    </form>

    <script type="text/javascript">
        var name, ck = 0;
        $(document).ready(function () {
            var ulEmployee = $('#ulEmployee');
            $('#showEmployee').click(function () {
                $.ajax({
                    type: 'Get',
                    url: 'api/employees',   // cross domain na hole http://localhost:59705/ deoyar dorkar nai.
                    dataType: 'json',
                    success: function (data) {
                        ulEmployee.empty();
                        name = '';
                        $.each(data, function (index, val) {
                            var fullName = val.first_Name + ' ' + val.last_Name;
                            name += '<li>' + fullName + '</li>';  
                        });
                        ulEmployee.append(name);
                        ck = 1;
                    }
                });
            });
            if (ck == 0) {
                ulEmployee.empty();
                ulEmployee.append(name);
            }
            $('#hideEmployee').click(function () {
                ulEmployee.empty();
            });
        });
    </script>
</body>
</html>
