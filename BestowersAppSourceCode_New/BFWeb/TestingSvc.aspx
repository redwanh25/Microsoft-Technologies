<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="TestingSvc.aspx.cs" Inherits="BFWeb.TestingSvc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <TABLE width="100%" border="0" cellspacing="1" cellpadding="2">
                                        <THEAD>
								        <tr class="bannercell">
								        <td class="bannertext" width="1%">&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>User Name</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Developer Name</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Email</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='TEXT-DECORATION: underline'>Role</u>&nbsp;</td>
							            </tr>
                                        </THEAD>
									<asp:repeater id="repParent" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall"><a href="UserDetails.aspx?id=<%# DataBinder.Eval(Container.DataItem, "UserID") %>"><img src="LIB/Images/icon-pencil.gif" height="16" border="0" /></a></td>
        									    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "UserName") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "FirstName") %> <%# DataBinder.Eval(Container.DataItem, "LastName") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "Email") %></td>											    
											     <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "RoleName") %></td>
											     
											</tr>
										</ItemTemplate>
									</asp:Repeater>
                                    </TABLE>
                                    
</asp:Content>
