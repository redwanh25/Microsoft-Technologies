<%@ Page Title="" Language="C#" MasterPageFile="~/BestowerSoft.Master" AutoEventWireup="true" CodeBehind="ExpenseDetails.aspx.cs" Inherits="BFWeb.ExpenseDetails" %>
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
									<td class="bannertext" vAlign="bottom" align="left"><asp:label id="lblHeader" runat="server"></asp:label></td>
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
                         													                           
                           <table cellSpacing="1" cellPadding="2" width="100%" align="left" border="0">
				                <tr>
					                <td class="navback">
						                <table width="100%">							
							                
							                
							                <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Projects:</td>
								                <td class="valuecell" noWrap align="left"><asp:dropdownlist id="ddlProjects" runat="server" DataTextField="Name" DataValueField="ID"></asp:dropdownlist></td>
							                </tr>
							                <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Amount:</td>
								                <td class="valuecell" noWrap align="left"><asp:textbox id="tbAmount" Runat="server"></asp:textbox></td>
							                </tr>

							                <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Expense Date:</td>
								                <td class="valuecell" noWrap align="left"><asp:textbox id="tbExpenseDate" Runat="server"></asp:textbox></td>
							                </tr>							                
                                            <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Fund:</td>
								                <td class="valuecell" noWrap align="left"><asp:dropdownlist id="ddlFund" runat="server" DataTextField="Name" DataValueField="ID"></asp:dropdownlist></td>
							                </tr>
							               
                                           
							               
							                <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Purpose:</td>
								                <td class="valuecell" noWrap align="left"><asp:textbox id="tbPurpose" Runat="server"></asp:textbox></td>
							                </tr>
							                
							                <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Comments:</td>
								                <td class="valuecell" noWrap align="left"><asp:textbox id="tbComments" Runat="server"></asp:textbox></td>
							                </tr>
							                 
							                 
							                <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Organization:</td>
								                <td class="valuecell" noWrap align="left"><asp:dropdownlist id="ddlOrganization" runat="server" DataTextField="Name" DataValueField="ID"></asp:dropdownlist></td>
							                </tr>

                                            <tr class="valuetextsmall">
								                <td vAlign="top" noWrap align="right">Tree:</td>
								                <td class="valuecell" noWrap align="left"><asp:dropdownlist id="ddlTree" runat="server" DataTextField="Name" DataValueField="ID"></asp:dropdownlist></td>
							                </tr>
							                
							                <tr class="valuetextsmall">
								                <td>&nbsp;</td>
								                <td noWrap align="left"><asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />&nbsp;<asp:button id="btnOK" runat="server" Text=" Save " onclick="btnOK_Click"></asp:button>&nbsp;
								                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
								                <br>
									                <asp:label id="lblMsg" runat="server" ForeColor="#0000ff"></asp:label></td>
							                </tr>
						                </table>
					                </td>
				                </tr>
			                </table>

                           				

							<!-- end content table -->
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
	<!-- show the content end --->

</asp:Content>
