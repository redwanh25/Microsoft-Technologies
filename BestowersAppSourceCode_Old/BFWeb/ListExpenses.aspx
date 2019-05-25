<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="ListExpenses.aspx.cs" Inherits="BFWeb.ListExpenses" %>
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
									<td class="bannertext" vAlign="bottom" align="left">BAS - EXPENSES</td>
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
							                <td>Year:<asp:TextBox ID="tbYear" runat="server" Width="50"></asp:TextBox></td>
							                <td><asp:Button ID="btnGetExpenses" Text="Search Expenses" runat="server" OnClick="btnGetExepenses_Click" /></td>
							                <td><asp:Button ID="btnAdd" runat="server" Text="Add Expenses" OnClick="btnAdd_Click" /></td>
							                
							            </tr>
							        </table>
							        
                                    <TABLE width="100%" border="0" cellspacing="1" cellpadding="2">
                                        <THEAD>
								        <tr class="bannercellstat">
								        <td class="bannertext" width="1%">&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Category</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Amount</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Fund</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Date</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Purpose</u>&nbsp;</td>							                
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='TEXT-DECORATION: underline'>Comments</u>&nbsp;</td>
							            </tr>
                                        </THEAD>
									<asp:repeater id="repParent" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall"><a href="ExpenseDetails.aspx?id=<%# DataBinder.Eval(Container.DataItem, "ID") %>"><img src="LIB/Images/icon-pencil.gif" height="16" border="0" /></a></td>
        									    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "CategoryName") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "Amount") %> </td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "FundName") %></td>											    
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "ExpenseDate") %> </td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "Purpose") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "Comments") %></td>
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
