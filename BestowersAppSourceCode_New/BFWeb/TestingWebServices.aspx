<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="TestingWebServices.aspx.cs" Inherits="BFWeb.TestingWebServices" %>
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
									<td class="bannertext" valign="bottom" align="left">TESTING WEB SERVICES</td>
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
							<table><tr><td>
							
							<table>
							<tr><td>Search Criteria:
							
							<asp:DropDownList ID="DdlColumn" runat="server">
                    <asp:ListItem>--</asp:ListItem>
                    <asp:ListItem>Batch No</asp:ListItem>
                    <asp:ListItem>Cadet No</asp:ListItem>
                    <asp:ListItem>First Name</asp:ListItem>
                    <asp:ListItem>Last Name</asp:ListItem>
                    <asp:ListItem>City</asp:ListItem>
                    <asp:ListItem>State</asp:ListItem>
                    <asp:ListItem>Country</asp:ListItem>
                       
                    </asp:DropDownList>
                    
                    <asp:TextBox ID="TextBoxCriteria" runat="server"></asp:TextBox>
                      <asp:Button ID="ButtonFindMembers" runat="server" Text="Test GetOrcaMembers Service" 
                            onclick="ButtonFindMembers_Click" />
							</td></tr>
							
							<tr><td>Sorting Parameter: <asp:TextBox ID="TextBoxOrderBy" runat="server"></asp:TextBox> <i>[Default: ORDER BY m.BatchID, m.CadetNo]</i></td></tr>
							<tr><td>Web Service URL: http://bestower.org/BFWS/OrcaWebServices.asmx</td></tr>
							<tr><td>CadetNo:<asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
							        Password:<asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
							        <asp:Button ID="btnAuthenticateOrcans" runat="server" Text="Test AuthenticateOrcans Service" OnClick="btnAuthenticateOrcans_Click"/>
                                <asp:Button ID="btnHelloWorld" runat="server" Text="Test Hello World Service" />
                                </td>
							        </tr>
							
							<tr><td><asp:Label ID="lblUserExists" runat="server" CssClass="errortext"></asp:Label></td></tr>
							<tr><td>
							
							<asp:GridView ID="GridViewOrcaMembers" runat="server">
                        </asp:GridView>
                     
							</td></tr>
							
							</table>
							
											
							
							</td></tr></table>
							<!-- end content table -->
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<!-- show the content end --->

        
</asp:Content>
