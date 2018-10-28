<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show_hide.aspx.cs" Inherits="JavaScript.show_hide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script>  
        var flag = true;
        function commentform() {
            var cform = "<form action='Comment'>Enter Name:<br><input type='text' name='name'/><br/>Enter Email: <br><input type='email' name='email' /><br>Enter Comment:<br /><textarea rows='5' cols='70'></textarea><br><input type='submit' value='Post Comment' /></form>";
            if (flag) {
                document.getElementById("mylocation").innerHTML = cform;
                flag = false;
            } else {
                document.getElementById("mylocation").innerHTML = "";
                flag = true;
            }
        }

    </script>

    <script>
        var x = 10;
        console.log(x);
    </script>

    <button onclick="commentform()">Comment</button>
    <div id="mylocation"></div>
</body>
</html>
