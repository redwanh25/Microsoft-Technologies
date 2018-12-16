<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Software_Company.WebForm.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
<script type="text/javascript" src="http://maxcdn.bootstrapcdn.com/bootstrap/3.0.3/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" />
<script type="text/javascript">
    $(document).ready(function () {
        // create local storage or check if local storage if not null then remove already exist
        // Null checking you need to make because only ones you need to call it
        if (localStorage.getItem('windowSizeratio') != null) {
            localStorage.removeItem('windowSizeratio');
        } else {
            // Assign ratio value as per your resize window setting
            var value = "0";
            if ($(this).width() > 0 && $(this).width() <= 540) {
                value = "540";
            }
            else if ($(this).width() > 540 && $(this).width() <= 980) {
                value = "980";
            } else if ($(this).width() > 980) {
                value = "981";
            }
            //Assign localstorage value
            localStorage.setItem('windowSizeratio', value);
        }
        // Call this function which will set hidden field value also it will call the button click event.
        resize($(this).width());
    });
    window.onresize = function (event) {
        // On resize window function will get call
        resize($(this).width());
    };
    function resize(width) {
        //Assign localstorage value to variable if it exist else it will undefined
        var ratio = localStorage.getItem('windowSizeratio');
        //Check the width also you need to check it’s not in same ratio which was it before
        //So it will not call repeatedly for many times as infinite by checking ratio value which assigned from local storage.
        //And assign hidden field value and call the buttonclick event from jquery fuction so it will set the RepeatColumns value.
        if (width > 0 && width <= 540 && ratio != "540" && $("[id*=hfColumnRepeat]").val() != "2") {
            $("[id*=hfColumnRepeat]").val(2);
            $("[id*=btnfake]").click();
        }
        else if (width > 540 && width <= 980 && ratio != "980" && $("[id*=hfColumnRepeat]").val() != "3") {
            $("[id*=hfColumnRepeat]").val(3);
            $("[id*=btnfake]").click();
        }
        else if (width > 980 && ratio != "981" && $("[id*=hfColumnRepeat]").val() != "5") {
            $("[id*=hfColumnRepeat]").val(5);
            $("[id*=btnfake]").click();
        }
    }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <%-- Fake button just for call onClick of button event using jquery function--%>
    <asp:Button ID="btnfake" runat="server" OnClick="OnClick" Style="display: none" />
    <%-- Hidden filed to set the ratio value--%>
    <asp:HiddenField ID="hfColumnRepeat" runat="server" Value="5" />
    <asp:DataList ID="dlCustomers" runat="server" CellSpacing="3" RepeatColumns="5">
        <ItemTemplate>
            <div class="row">
                <div class="col-sm-12 ">
                    <div class="col-sm-12">
                        <b>
                            <%# Eval("ContactName") %></b>
                    </div>
                    <div class="col-sm-12">
                        <%# Eval("City") %>,
                        <%# Eval("PostalCode") %><br />
                        <%# Eval("Country")%>
                    </div>
                    <div class="col-sm-6">
                        Phone:
                    </div>
                    <div class="col-sm-6">
                        <%# Eval("Phone")%>
                    </div>
                    <div class="col-sm-6">
                        Fax:
                    </div>
                    <div class="col-sm-6">
                        <%# Eval("Fax")%>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <br />
    <br />
    </form>
</body>
</html>
