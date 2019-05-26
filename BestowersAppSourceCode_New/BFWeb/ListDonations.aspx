<%@ Page Title="" Debug="true" Language="C#" MasterPageFile="~/BestowerSoft.Master" AutoEventWireup="true" CodeBehind="ListDonations.aspx.cs" Inherits="BFWeb.ListDonations" %>
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
						                            <td>Year:<asp:TextBox ID="tbYear" runat="server" Width="50"></asp:TextBox></td>
						                            <td><asp:Button ID="btnGetDonations" Text="Search Donations" runat="server" OnClick="btnGetDonations_Click" /></td>
						                            <td><asp:Button ID="btnAdd" runat="server" Text="Add Donation" OnClick="btnAdd_Click" /></td>
							                    
							                    </tr>
							                    </table>
							            
							                </td>
							            </tr>
							            <tr>
	    						            <td><asp:Label ID="lblTesting" runat="server"></asp:Label></td>
    						            </tr>
							        </table>
							        
                                    <TABLE width="100%" border="0" cellspacing="1" cellpadding="2">
                                        <thead>
								        <tr class="bannercellstat">
								        <td class="bannertext" width="1%">&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Donor</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Amount</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Fund</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Date</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Anonymous</u>&nbsp;</td>
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Purpose</u>&nbsp;</td>							                
							                <td class="bannertext" nowrap onclick="javascript:sortColumn(event);">&nbsp;<u style='TEXT-DECORATION: underline'>Email</u>&nbsp;</td>
							            </tr>
                                        </thead>
									<asp:repeater id="repParent" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall"><a href="DonationDetails.aspx?id=<%# DataBinder.Eval(Container.DataItem, "ID") %>"><img src="LIB/Images/icon-pencil.gif" height="16" border="0" /></a></td>
        									    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "DonorName") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "Amount", "{0:0.##}")%> </td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "FundName") %></td>											    
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "DonationDate", "{0:MM/dd/yyyy}") %> </td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "Anonymous") %></td>											    
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "Purpose") %></td>
											    <td class="valuetextsmall"><%# DataBinder.Eval(Container.DataItem, "DonorEmail") %></td>

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
