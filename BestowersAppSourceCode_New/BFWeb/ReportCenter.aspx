<%@ Page Title="" Language="C#" MasterPageFile="~/BestowerSoft.Master" AutoEventWireup="true" CodeBehind="ReportCenter.aspx.cs" Inherits="BFWeb.ReportCenter" %>
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
									<td class="bannertext" vAlign="bottom" align="left">BESTOWER ACCOUNTING SOFTWARE - REPORT CENTER</td>
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
							                        <td class="valuetextsmall"  align="right">Year:</td><td class="valuetextsmall" align="left"><asp:TextBox ID="tbYear" runat="server"></asp:TextBox></td>
							                        <td class="valuetextsmall"  align="right">Report Name:</td><td class="valuetextsmall" align="left">
							                            <asp:DropDownList ID="ddlReportName" runat="server">
                                                            <asp:ListItem Text="Annual Report" Value="Annual"></asp:ListItem>
                                                            <asp:ListItem Text="Standard Report" Value="Standard"></asp:ListItem>
                                                            <asp:ListItem Text="Income By Donors [Details]" Value="IncomeByDonors"></asp:ListItem>                                                            
                                                            <asp:ListItem Text="Income By Donors [Simplified]" Value="IncomeByDonorsSimplified"></asp:ListItem>
                                                        </asp:DropDownList>
							                        </td>
							                        <td class="valuetextsmall"  align="left"><asp:Button ID="btnGetReports" Text="Generate Reports" runat="server" OnClick="btnGetReports_Click" /></td>
							                        <td><asp:Button ID="btnSendDonationReceipt" runat="server" Text="Send Donation Receipt" OnClick="btnSendDonationReceipt_Click" /></td>
							                        <td class="valuetextsmall" align="left"><asp:Label ID="lblTesting" runat="server"></asp:Label></td>
        							                
							                    </tr>
							                </table>
							                
							            </td>    
							            </tr>
							            
    						            
							            <tr><td class="valuetext"><b><asp:Label ID="lblReportHeader" runat="server"></asp:Label>&nbsp;</b></td></tr>
						
							        </table>
                                    
                                    
                                   
                                   
                                    <!-- report will display here --->
                                       
                                       
                                       <!-- begin report 1: annual report --->
                                       
                                       <asp:Panel ID="panelAnnualReport" runat="server">
                                       
                                        <!-- INCOME TABLE BEGIN -->
                                        <TABLE width="100%" border="1" cellspacing="1" cellpadding="2" rules="all" 
                							style="border-color:gray;" >
                                       
                                        <tr class="bannercell">
		                                    <td class="bannertext" colspan="3" align="left">1.&nbsp;INCOME - FISCAL YEAR <%=reportYear %></td>
										
                        	            </tr>
                                         <tr class="footerbannercell" align="center" valign="top" >
		                                    <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                                    <td class="theadertext" width="9%">Amount</td>
	                                    </tr>
                                        
									<asp:repeater id="repParentDonationAnnualReport" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall" width="1%" align="left"><%# DataBinder.Eval(Container.DataItem, "SectionID") %></td>
											    <td class="valuetextsmall" width="80%" align="left"><%# DataBinder.Eval(Container.DataItem, "FundName") %></td>											    
											    <td class="valuetextsmall" width="9%" align="right"><%# DataBinder.Eval(Container.DataItem, "SumOfAmount")%> </td>
											    
											</tr>
										</ItemTemplate>
									</asp:repeater>
									        <tr class="bannercell">
		                                        <td class="bannertext" colspan="2" align="right" width="80%">Total Income:</td>
    							                <td align="right" class="bannertext" width="9%"><%=strTotalIncomeAnnual %></td>
                        	                </tr>
                                    </TABLE>
                                    <!-- INCOME TABLE ENDS --->
                                    
                                        <br />
                                        
                                        <!-- EXPENSE TABLE BEGIN -->
                                        <TABLE width="100%" border="1" cellspacing="1" cellpadding="2" rules="all" 
                							style="border-color:gray;" >
                                       
                                        <tr class="bannercell">
		                                    <td class="bannertext" colspan="3" align="left">2.&nbsp;EXPENSE - FISCAL YEAR <%=reportYear %></td>
										
                        	            </tr>
                                         <tr class="footerbannercell" align="center" valign="top" >
		                                    <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                                    <td class="theadertext" width="9%">Amount</td>
	                                    </tr>
                                        
									<asp:repeater id="repParentExpenseAnnualReport" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall" width="1%" align="left"><%# DataBinder.Eval(Container.DataItem, "SectionID") %></td>
											    <td class="valuetextsmall" width="80%" align="left"><%# DataBinder.Eval(Container.DataItem, "FundName") %></td>											    
											    <td class="valuetextsmall" width="9%" align="right"><%# DataBinder.Eval(Container.DataItem, "SumOfAmount")%> </td>
											    
											</tr>
										</ItemTemplate>
									</asp:repeater>
									        <tr class="bannercell">
		                                        <td class="bannertext" colspan="2" align="right" width="80%">Total Expense:</td>
    							                <td align="right" class="bannertext" width="9%"><%=strTotalExpenseAnnual%></td>
                        	                </tr>
                                    </TABLE>
                                    <!-- EXPENSE TABLE ENDS --->
                                    <br />
                                    
                                     <!-- BEGIN BALACE TABLE -->
                                     <TABLE width="100%" border="1" cellspacing="1" cellpadding="2" rules="all" 
                							style="border-color:gray;" >
                                       
                                        <tr class="bannercell">
		                                    <td class="bannertext" colspan="3" align="left">3.&nbsp;BALANCE - FISCAL YEAR <%=reportYear %></td>
										
                        	            </tr>
                                         <tr class="footerbannercell" align="center" valign="top" >
		                                    <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                                    <td class="theadertext" width="9%">Amount</td>
	                                    </tr>
	                                    
	                                    <tr class='datacell' >											
											    <td class="valuetextsmall" width="1%" align="left">3.1</td>
											    <td class="valuetextsmall" width="80%" align="left">Total Income</td>											    
											    <td class="valuetextsmall" width="9%" align="right"><%=strTotalIncomeAnnual %> </td>
											    
										</tr>
										<tr class='datacell2' >											
											    <td class="valuetextsmall" width="1%" align="left">3.2</td>
											    <td class="valuetextsmall" width="80%" align="left">Total Expense</td>											    
											    <td class="valuetextsmall" width="9%" align="right"><%=strTotalExpenseAnnual %> </td>
											    
										</tr>
										 <tr class="bannercell">
		                                        <td class="bannertext" colspan="2" align="right" width="80%">Ending Balance End-of-the-year <%=reportYear %>:</td>
    							                <td align="right" class="bannertext" width="9%"><asp:Label ID="lblEndingBalace" runat="server"></asp:Label></td>
                        	             </tr>
                        	             </TABLE>

                                    <!-- END BALACE TABLE -->
                                    <br />
                            
                            
                                </asp:Panel>
                                <!-- end report 1: annual report panel -->
                                       
                                <!-- begin reprot 2: standard income/expense report -->
                                
                                <asp:Panel ID="panelStandardReport" runat="server">
                                
                                <!-- INCOME TABLE BEGIN -->
                                        <TABLE width="100%" border="1" cellspacing="1" cellpadding="2" rules="all" 
                							style="border-color:gray;" >
                                       
                                        <tr class="bannercell">
		                                    <td class="bannertext" colspan="3" align="left">1.&nbsp;INCOME - FISCAL YEAR <%=reportYear %></td>
										
                        	            </tr>
                                         <tr class="footerbannercell" align="center" valign="top" >
		                                    <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                                    <td class="theadertext" width="9%">Amount</td>
	                                    </tr>
                                        
									<asp:repeater id="repParentIncomeStandard" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall" width="1%" align="left"><%# DataBinder.Eval(Container.DataItem, "SectionID") %></td>
											    <td class="valuetextsmall" width="80%" align="left"><%# DataBinder.Eval(Container.DataItem, "FundName") %></td>											    
											    <td class="valuetextsmall" width="9%" align="right"><%# DataBinder.Eval(Container.DataItem, "SumOfAmount")%> </td>
											    
											</tr>
										</ItemTemplate>
									</asp:repeater>
									        <tr class="bannercell">
		                                        <td class="bannertext" colspan="2" align="right" width="80%">Total Income:</td>
    							                <td align="right" class="bannertext" width="9%"><%=strTotalIncomeStandard %></td>
                        	                </tr>
                                    </TABLE>
                                    <!-- INCOME TABLE ENDS --->
                                    
                                        <br />
                                        
                                        <!-- EXPENSE TABLE BEGIN -->
                                        <TABLE width="100%" border="1" cellspacing="1" cellpadding="2" rules="all" 
                							style="border-color:gray;" >
                                       
                                        <tr class="bannercell">
		                                    <td class="bannertext" colspan="3" align="left">2.&nbsp;EXPENSE - FISCAL YEAR <%=reportYear %></td>
										
                        	            </tr>
                                         <tr class="footerbannercell" align="center" valign="top" >
		                                    <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                                    <td class="theadertext" width="9%">Amount</td>
	                                    </tr>
                                        
									<asp:repeater id="repParentExpenseStandard" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall" width="1%" align="left"><%# DataBinder.Eval(Container.DataItem, "SectionID") %></td>
											    <td class="valuetextsmall" width="80%" align="left"><%# DataBinder.Eval(Container.DataItem, "FundName") %></td>											    
											    <td class="valuetextsmall" width="9%" align="right"><%# DataBinder.Eval(Container.DataItem, "SumOfAmount")%> </td>
											    
											</tr>
										</ItemTemplate>
									</asp:repeater>
									        <tr class="bannercell">
		                                        <td class="bannertext" colspan="2" align="right" width="80%">Total Expense:</td>
    							                <td align="right" class="bannertext" width="9%"><%=strTotalExpenseStandard %></td>
                        	                </tr>
                                    </TABLE>
                                    <!-- EXPENSE TABLE ENDS --->
                                    <br />
                                
                                
                                </asp:Panel>                                                 
                                                                       
                                       
                                       <!-- begin reprot 3: donations by donor details report -->
                                
                                <asp:Panel ID="panelIncomeByDonors" runat="server">
                                
                                
                                
                                 <TABLE width="100%" border="1" cellspacing="1" cellpadding="2" rules="all" 
                							style="border-color:gray;" >
                                       
                                        <tr class="bannercell">
		                                    <td class="bannertext" colspan="4" align="left">INCOME BY DONORS <%=reportYear %></td>
										
                        	            </tr>
                                         <tr class="footerbannercell" align="center" valign="top" >
		                                    <td class="theadertext" width="20%">Donor Name</td>
		                                    <td class="theadertext" width="65%">Email</td>
		                                    <td class="theadertext" width="10%"  align="right">Amount</td>
		                                    <td class="theadertext" width="10%" nowrap>Send Receipt?<asp:CheckBox ID="cbToggleAll" runat="server" /></td>
											    
	                                    </tr>
                                        
									<asp:repeater id="repParentIncomeByDonors" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall" width="20%" align="left"><b><%# DataBinder.Eval(Container.DataItem, "DonorName") %></b></td>
											    <td class="valuetextsmall" width="65%" align="left"><b><%# DataBinder.Eval(Container.DataItem, "DonorEmail") %></b></td>											    
											    <td class="valuetextsmall" width="10%" align="right"><b><%# DataBinder.Eval(Container.DataItem, "SumOfAmount")%></b> </td>
											    <td class="valuetextsmall" align="right" width="10%"><%# DataBinder.Eval(Container.DataItem, "ReceiptSentDate", "{0:MM/dd/yyyy}")%> <asp:CheckBox ID="cbSendReceipt" runat="server"></asp:CheckBox></td>
											</tr>
											<tr>
											<td colspan="3">
											<table width="100%" border="0" cellspacing="0" cellpadding="0">
											<thead>
											    <tr class="bannercellstat">
										            <td class="bannertext" width="20%" onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Donation Date</u>&nbsp;</td>
										            <td class="bannertext" width="65%" onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Fund Name</u>&nbsp;</td>
										            <td class="bannertext" align="right" width="10%" onclick="javascript:sortColumn(event);">&nbsp;<u style='CURSOR: hand; TEXT-DECORATION: underline'>Amount</u>&nbsp;</td>
										        </tr>
    											</thead>
											 <asp:Repeater ID="repChildIncomeByDonors" runat="server" DataSource='<%# GetChildRelation(Container.DataItem, "MyRelation") %>'>
												    <ItemTemplate>
													    <tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >
													        <td class="valuetextsmall" nowrap><%# DataBinder.Eval(Container.DataItem, "DonationDate", "{0:MM/dd/yyyy}")%></td>
													        <td class="valuetextsmall" nowrap><%# DataBinder.Eval(Container.DataItem, "FundName") %></td>
													        <td class="valuetextsmall" align="right" nowrap><%# DataBinder.Eval(Container.DataItem, "DonationAmount")%></td>
													    </tr>
												    </ItemTemplate>
											    </asp:Repeater>

											</table>
											</td>
											<td width="10%">&nbsp;</td>
											</tr>
																						    
										</ItemTemplate>
										
										
									</asp:repeater>
									        <tr class="bannercell">
		                                        <td class="bannertext" colspan="2" align="right" width="80%">Total Income:</td>
    							                <td align="right" class="bannertext" width="9%"><%=strTotalIncomeStandard %></td>
    							                <td>&nbsp;</td>
                        	                </tr>
                                    </TABLE>
                                    <!-- INCOME TABLE ENDS --->
                                    <br />
                                
                                
                                </asp:Panel>
                                        <!-- end reprot 3: donations by donor report -->                         
                                    

                                       
                                       <!-- begin reprot 4: donations by donor simplified report -->
                                
                                <asp:Panel ID="panelDonationsByDonorSimplified" runat="server">
                                
                                
                                
                                 <TABLE width="100%" border="1" cellspacing="1" cellpadding="2" rules="all" 
                							style="border-color:gray;" >
                                       
                                        <tr class="bannercell">
		                                    <td class="bannertext" colspan="4" align="left">INCOME BY DONORS [SIMPLIFIED VERSION] <%=reportYear %></td>
										
                        	            </tr>
                                         <tr class="footerbannercell" valign="top" >
		                                    <td class="theadertext" width="20%">Donor Name</td>
		                                    <td class="theadertext" width="65%">Email</td>
		                                    <td class="theadertext" width="10%"  align="right">Amount</td>
		                                    <td class="theadertext" width="10%" nowrap>Send Receipt?<asp:CheckBox ID="cbToggleAllSimplified" runat="server" /></td>
											    
	                                    </tr>                               
	                                    
                                        
									<asp:repeater id="repDonationByDonorSimplified" Runat="server">									    
										<ItemTemplate>
											<tr class='<%# DataBinder.Eval(Container.DataItem, "TRClass") %>' >											
											    <td class="valuetextsmall" width="20%" align="left"><%# DataBinder.Eval(Container.DataItem, "DonorName") %></td>
											    <td class="valuetextsmall" width="65%" align="left"><%# DataBinder.Eval(Container.DataItem, "DonorEmail") %></td>											    
											    <td class="valuetextsmall" width="10%" align="right"><%# DataBinder.Eval(Container.DataItem, "SumOfAmount")%> </td>
											    <td class="valuetextsmall" align="right" width="10%"><%# DataBinder.Eval(Container.DataItem, "ReceiptSentDate", "{0:MM/dd/yyyy}")%> <asp:CheckBox ID="cbSendReceiptSimplified" runat="server"></asp:CheckBox></td>
											</tr>																						    
										</ItemTemplate>
										
										
									</asp:repeater>
									        <tr class="bannercell">
		                                        <td class="bannertext" colspan="2" align="right" width="80%">Total Income:</td>
    							                <td align="right" class="bannertext" width="9%"><%=strTotalIncomeStandard %></td>
    							                <td>&nbsp;</td>
                        	                </tr>
                                    </TABLE>
                                    <!-- INCOME TABLE ENDS --->
                                    <br />
                                
                                
                                </asp:Panel>
                                        <!-- end reprot 4: donations by donor simplified report -->                         

                                    <!-- end displaing report -->
                                    

                            
							<!-- end content table -->
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
	<!-- show the content end --->

</asp:Content>
