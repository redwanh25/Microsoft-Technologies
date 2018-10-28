<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallServiceFromJS.aspx.cs" Inherits="BFWeb.CallServiceFromJS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    
    <script type="text/javascript">
 function CallService()
 {
     BFWS.OrcaWebServices.HelloWorld("REZA", "Hi",
   Callback );
 }

 function Callback( result )
 {
   var outDiv = document.getElementById("outputDiv");
   outDiv.innerText = result;
 }
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
        <asp:ServiceReference Path="http://eos/BFWS/ORCAWebServices.asmx" />
        </Services>
        </asp:ScriptManager>
    
    </div>
    <asp:Button ID="Button1" runat="server" Text="Testing Service"  OnClientClick="CallService();return false;"/>
    
    <div id="outputDiv">
</div>
    </form>
</body>

</html>
