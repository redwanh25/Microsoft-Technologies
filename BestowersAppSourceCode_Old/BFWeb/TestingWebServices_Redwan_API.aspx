<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="TestingWebServices_Redwan_API.aspx.cs" Inherits="BFWeb.WebForm2" %>


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
                                <br />

                                <script src="jquery_Bootstrap_SweetAlert/jQuery/compressed/jquery-3.3.1.min.js"></script>
                                <link href="jquery_Bootstrap_SweetAlert/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
                                <script src="jquery_Bootstrap_SweetAlert/Bootstrap/js/bootstrap.min.js"></script>

                                <div class="well col-md-12 col-lg-12 col-xs-12">
                                    <table>
                                        <tr>
                                            <td>
                                                <h4>First Name</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="FirstNameTextBox" runat="server" placeholder=" Habibullah" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td>
                                                <h4>&nbsp;&nbsp; Last Name</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="LastNameTextBox" runat="server" placeholder=" Bahar" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td>
                                                <h4>&nbsp;&nbsp; Batch ID</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="BatchIDTextBox" runat="server" placeholder=" 11" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td>
                                                <h4>&nbsp;&nbsp; Cadet No</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="CadetNoTextBox" runat="server" placeholder=" 587" CssClass="form-control"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>Home Email</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="HomeEmailTextBox" runat="server" placeholder=" smhbahar@hotmail.com" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td>
                                                <h4>&nbsp;&nbsp; Home Phone</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="HomePhoneTextBox" runat="server" placeholder=" 613-531-6014" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td>
                                                <h4>&nbsp;&nbsp; City Name&nbsp;&nbsp;&nbsp; </h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="CityTextBox" runat="server" placeholder=" Guelph" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td>
                                                <h4>&nbsp;&nbsp; State Name&nbsp;&nbsp;&nbsp; </h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="StateTextBox" runat="server" placeholder=" ON" CssClass="form-control"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>country Name&nbsp;&nbsp;&nbsp; </h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="CountryIDTextBox" runat="server" placeholder=" CA" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td>
                                                <h4>&nbsp;&nbsp; Sorting Parameter&nbsp;&nbsp;&nbsp; </h4>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="form-control">
                                                    <asp:ListItem Text="Default Order" Value="-1"></asp:ListItem>
                                                    <asp:ListItem Text="MemberID" Value="memberID"></asp:ListItem>
                                                    <asp:ListItem Text="FirstName" Value="firstName"></asp:ListItem>
                                                    <asp:ListItem Text="LastName" Value="lastName"></asp:ListItem>
                                                    <asp:ListItem Text="BatchID" Value="batchID"></asp:ListItem>
                                                    <asp:ListItem Text="CadetNo" Value="cadetNo"></asp:ListItem>
                                                    <asp:ListItem Text="HomeEmail" Value="homeEmail"></asp:ListItem>
                                                    <asp:ListItem Text="HomePhone" Value="homePhone"></asp:ListItem>
                                                    <asp:ListItem Text="City" Value="city"></asp:ListItem>
                                                    <asp:ListItem Text="State" Value="state"></asp:ListItem>
                                                    <asp:ListItem Text="CountryID" Value="countryID"></asp:ListItem>
                                                </asp:DropDownList>

                                            </td>
                                            <td colspan="4">
                                                <h5 style="color: green">&nbsp;&nbsp; [Default: ORDER BY BatchID, CadetNo] </h5>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td colspan="8" align="right">
                                                <input id="Search" type="button" value="Get OrcaMember Service" class="btn btn-primary" />
                                                <%--<asp:Button ID="Search" runat="server" Text="Get OrcaMember Service" CssClass="btn btn-primary" />--%>
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    <br />
                                    <table class="table table-bordered table-hover table-responsive table-striped">

                                        <thead>
                                            <tr class="success h4">
                                                <td>MemberID</td>
                                                <td>FirstName</td>
                                                <td>LastName</td>
                                                <td>BatchID</td>
                                                <td>CadetNo</td>
                                                <td>HomeEmail</td>
                                                <td>HomePhone</td>
                                                <td>City</td>
                                                <td>State</td>
                                                <td>CountryID</td>
                                            </tr>
                                        </thead>

                                        <tbody id="tbody">
                                        </tbody>
                                    </table>
                                </div>

                                <script type="text/javascript">
                                    $(document).ready(function () {
                                        var tbody = $('#tbody');
                                        $('#Search').click(function () {
                                            $.ajax({
                                                type: 'Get',
                                                url: 'http://localhost:49910/api/members/',
                                                dataType: 'json',
                                                success: function (data) {
                                                    tbody.empty();
                                                    $.each(data, function (index, val) {

                                                        tbody.append('<tr style="font-size:16px"> <td>' + val.MemberID + '</td> <td>' + val.FirstName +
                                                            '</td> <td>' + val.LastName + '</td> <td>' + val.BatchID + '</td> <td>' + val.CadetNo +
                                                            '</td> <td>' + val.HomeEmail + '</td> <td>' + val.HomePhone + '</td> <td>' + val.City +
                                                            '</td> <td>' + val.State + '</td> <td>' + val.CountryID + '</td> </tr>');
                                                    });
                                                },
                                                complete: function (jqXHR) {
                                                    tbody.append('<tr> <td style="color:red">' + jqXHR.status + ' : ' + jqXHR.statusText + '</td> </tr>');
                                                }
                                            });
                                        });
                                    });

                                </script>

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
