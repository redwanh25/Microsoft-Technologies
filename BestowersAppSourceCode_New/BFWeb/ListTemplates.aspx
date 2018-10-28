<%@ Page Title="" Language="C#" MasterPageFile="~/BestowerSoft.Master" AutoEventWireup="true" CodeBehind="ListTemplates.aspx.cs" Inherits="BFWeb.ListTemplates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<!-- show the content -->
	<TABLE cellSpacing="0" class="lightbannercell" cellPadding="0" border="0" width="100%">
		<TR vAlign="bottom" align="center">
			<td>
				<table cellSpacing="0" cellPadding="0" width="100%" border="0">
					<tr class="lightbannercell" vAlign="top">
						<td>
							<table cellSpacing="2" cellPadding="0" width="99%" border="0">
								<tr>
									<td class="bannertext" vAlign="bottom" align="left">BAS - TEMPLATES</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</TR>
		<TR vAlign="top" align="left">
			<TD>
				<TABLE cellSpacing="1" cellPadding="3" width="100%" border="0">
					<TR>
						<TD width="100%" class="navback">
							<!-- this is content table comes in -->
							        <table>
							            <tr>
							                <td><asp:Button ID="btnAdd" runat="server" Text="Add Template" OnClick="btnAdd_Click" /></td>
							                
							            </tr>
							        </table>
							        
                                    <TABLE width="100%" border="0" cellspacing="1" cellpadding="2">
                                        <THEAD>
								        <tr class="bannercellstat">
								        <td class="bannertext" width="1%">&nbsp;</td>
							                <td class="bannertext" width="20%" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Template Name</u>&nbsp;</td>
							                <td class="bannertext" width="80%" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Content</u>&nbsp;</td>
							                
							            </tr>
                                        </THEAD>
                                        
                                        <asp:Repeater ID="repParent" runat="server">
                                        <ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall" valign="top"><a href="TemplateDetails.aspx?id=<%# DataBinder.Eval(Container.DataItem, "ID") %>"><img src="LIB/Images/icon-pencil.gif" height="16" border="0" /></a></td>
        									    <td class="valuetextsmall" width="20%" valign="top"><%# DataBinder.Eval(Container.DataItem, "Name") %></td>
											    <td class="valuetextsmall" width="80%" valign="top"><%# DataBinder.Eval(Container.DataItem, "TemplateContent") %> </td>
											    											    
											    
											</tr>
										</ItemTemplate>
                                        
                                        </asp:Repeater>
									
                                    </TABLE>
                                    

                            
							<!-- end content table -->
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
	<!-- show the content end --->



</asp:Content>

