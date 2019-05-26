<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="TestingWebServices_Redwan.aspx.cs" Inherits="BFWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- show the content -->
    <table cellspacing="0" class="lightbannercell" cellpadding="0" border="0" width="100%">
        <tr valign="bottom" align="center">
            <td>
                <table cellspacing="0" cellpadding="0" width="100%" border="0">
                    <tr class="lightbannercell" valign="top">
                        <td>
                            <table cellspacing="2" cellpadding="0" width="99%" border="0">
                                <tr>
                                    <td class="bannertext" valign="bottom" align="left">TestingWebServices_Redwan</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr valign="top" align="left">
            <td>
                <table cellspacing="1" cellpadding="3" width="100%" border="0">
                    <tr>
                        <td width="100%" class="navback">
                            <!-- this is content table comes in -->
                            <span class="valuetextsmall">

<div>
    <table >
        <tr>
            <td>
                <h3>First Name</h3>
            </td>
            <td>
                <asp:TextBox ID="FirstNameTextBox" runat="server" placeholder=" Habibullah"></asp:TextBox>
            </td>
            <td>
                <h3>Last Name</h3>
            </td>
            <td>
                <asp:TextBox ID="LastNameTextBox" runat="server" placeholder=" Bahar"></asp:TextBox>
            </td>
            <td>
                <h3>Batch ID</h3>
            </td>
            <td>
                <asp:TextBox ID="BatchIDTextBox" runat="server" placeholder=" 11"></asp:TextBox>
            </td>
            <td>
                <h3>Cadet No</h3>
            </td>
            <td>
                <asp:TextBox ID="CadetNoTextBox" runat="server" placeholder=" 587"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <h3>Home Email</h3>
            </td>
            <td>
                <asp:TextBox ID="HomeEmailTextBox" runat="server" placeholder=" smhbahar@hotmail.com"></asp:TextBox>
            </td>
            <td>
                <h3>Home Phone</h3>
            </td>
            <td>
                <asp:TextBox ID="HomePhoneTextBox" runat="server" placeholder=" 613-531-6014"></asp:TextBox>
            </td>
            <td>
                <h3>City Name</h3>
            </td>
            <td>
                <asp:TextBox ID="CityTextBox" runat="server" placeholder=" Guelph"></asp:TextBox>
            </td>
            <td>
                <h3>State Name</h3>
            </td>
            <td>
                <asp:TextBox ID="StateTextBox" runat="server" placeholder=" ON"></asp:TextBox>
            </td>   
        </tr>
        <tr>
            <td>
                <h3>country Name</h3>
            </td>
            <td>
                <asp:TextBox ID="CountryIDTextBox" runat="server" placeholder=" CA"></asp:TextBox>
            </td>
            <td>
                <h3>Sorting Parameter</h3>
            </td>
            <td colspan="5">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Text ="Default Order" Value="-1"></asp:ListItem>
                    <asp:ListItem Text ="MemberID" Value="memberID"></asp:ListItem>
                    <asp:ListItem Text ="FirstName" Value="firstName"></asp:ListItem>
                    <asp:ListItem Text ="LastName" Value="lastName"></asp:ListItem>
                    <asp:ListItem Text ="BatchID" Value="batchID"></asp:ListItem>
                    <asp:ListItem Text ="CadetNo" Value="cadetNo"></asp:ListItem>
                    <asp:ListItem Text ="HomeEmail" Value="homeEmail"></asp:ListItem>
                    <asp:ListItem Text ="HomePhone" Value="homePhone"></asp:ListItem>
                    <asp:ListItem Text ="City" Value="city"></asp:ListItem>
                    <asp:ListItem Text ="State" Value="state"></asp:ListItem>
                    <asp:ListItem Text ="CountryID" Value="countryID"></asp:ListItem>
                </asp:DropDownList>
                <b>[Default: ORDER BY BatchID, CadetNo]</b>
            </td>
            
        </tr>
        <tr>
            <td colspan="8" align="right">
                <asp:Button ID="Search" runat="server" Text="Get OrcaMember Service" OnClick="Search_Click"/>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="100%" EnableModelValidation="True" Font-Size="Small" CellPadding="3" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px">
    </asp:GridView>
</div>
                                <br />




                            </span>
                            <!-- end content table -->
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <!-- show the content end --->

</asp:Content>
