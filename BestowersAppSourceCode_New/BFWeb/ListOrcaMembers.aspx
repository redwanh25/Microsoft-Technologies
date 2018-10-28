<%@ Page Title="" Language="C#" MasterPageFile="~/BestowerSoft.Master" AutoEventWireup="true" CodeBehind="ListOrcaMembers.aspx.cs" Inherits="BFWeb.ListOrcaMembers" %>
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
									<td class="bannertext" vAlign="bottom" align="left">BAS - DONATIONS</td>
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
							                <td>
							                    <table>
							                    <tr>
						                            <td>Search Criteria:
							
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
                                                    </td>
                                                    <td><asp:TextBox ID="TextBoxCriteria" runat="server"></asp:TextBox></td>
						                            <td><asp:Button ID="btnSearchOrcaMembers" Text="Search ORCA Member" runat="server" OnClick="btnSearchOrcaMembers_Click" /></td>
						                            <td><asp:Button ID="btnAdd" runat="server" Text="Add ORCA Member" OnClick="btnAdd_Click" /></td>
							                    
							                    </tr>
							                    </table>
							            
							                </td>
							            </tr>
							        </table>
							        
                                    <TABLE width="100%" border="0" cellspacing="1" cellpadding="2">
                                        <thead>
								        <tr class="bannercellstat">
								        <td class="bannertext" width="1%">&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Batch</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>CadetNo</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>First Name</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Last Name</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>City</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>State</u>&nbsp;</td>							                
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Country</u>&nbsp;</td>							                
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Phone</u>&nbsp;</td>							                
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Email</u>&nbsp;</td>							                
							            </tr>
                                        </thead>
									<asp:repeater id="repParent" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall"><a href="OrcaMemberDetails.aspx?id=<%# DataBinder.Eval(Container.DataItem, "MemberID") %>"><img src="LIB/Images/icon-pencil.gif" height="16" border="0" /></a></td>
        									    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "BatchID") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "CadetNo")%> </td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "FirstName") %></td>											    
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "LastName") %> </td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "City") %></td>											    
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "State") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "CountryID") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "HomePhone") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "HomeEmail") %></td>

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
