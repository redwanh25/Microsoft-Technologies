<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="TemplateAnnualReport.aspx.cs" Inherits="BFWeb.TemplateAnnualReport" %>
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
									<td class="bannertext" valign="bottom" align="left">TEMPLATE - ANNUAL FINANCIAL REPORT</td>
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
							
				   
							
                   <table>
                    <tr>
                        <td>
                           
						<table cellspacing="0" border="1" rules="all" 
							style="border-color:gray;width:100%;border-collapse:collapse;">
	
	                        <tr class="bannercell">
		                        <td class="bannertext" colspan="3" align="left">1.&nbsp;INCOME - FISCAL YEAR 2017</td>
										
                        	</tr>
	
	                        <tr class="footerbannercell" align="center" valign="top" >
		                        <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                        <td class="theadertext" width="9%">Amount</td>
	                        </tr>
	
	                        <tr class="datacell">
		                        <td class="valuetextsmall" width="1%">1.1</td>
                        										
		                        <td class="valuetextsmall" width="80%">Begining Balance</td>
		                        <td align="right" class="valuetextsmall" width="9%">$624.00</td>
                        	</tr>
                        	<tr class="datacell2" >
		                        <td class="valuetextsmall" width="1%">1.1</td>
								<td class="valuetextsmall" width="80%">Contribution received to plant medical grant tree</td>
							    <td align="right" class="valuetextsmall" width="9%">$10,000.00</td>
                        	</tr>
                        	<tr class="datacell">
		                        <td class="valuetextsmall" width="1%">1.3</td>
							    <td class="valuetextsmall" width="80%">Other gifts, grants and/or divident received</td>
							    <td align="right" class="valuetextsmall" width="9%">$2,000.00</td>
                        	</tr>
	                        <tr class="bannercell">
		                        <td class="bannertext" colspan="2" align="right" width="80%">Total Income:</td>
    							<td align="right" class="bannertext" width="9%">$12,624.00</td>
                        	</tr>
	
                        </table>


                        <br />
                        
                        <table cellspacing="0" border="1" rules="all" 
							style="border-color:gray;width:100%;border-collapse:collapse;">
	
	                        <tr class="bannercell">
		                        <td class="bannertext" colspan="3" align="left">2.&nbsp;EXPENSE - FISCAL YEAR 2017</td>
										
                        	</tr>
	
	                        <tr class="footerbannercell" align="center" valign="top" >
		                        <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                        <td class="theadertext" width="9%">Amount</td>
	                        </tr>
	
	                        <tr class="datacell">
		                        <td class="valuetextsmall" width="1%">2.1</td>
                        										
		                        <td class="valuetextsmall" width="80%">Begining Balance</td>
		                        <td align="right" class="valuetextsmall" width="9%">$624.00</td>
                        	</tr>
                        	<tr class="datacell2" >
		                        <td class="valuetextsmall" width="1%">2.1</td>
								<td class="valuetextsmall" width="80%">Contribution received to plant medical grant tree</td>
							    <td align="right" class="valuetextsmall" width="9%">$10,000.00</td>
                        	</tr>
                        	<tr class="datacell">
		                        <td class="valuetextsmall" width="1%">2.3</td>
							    <td class="valuetextsmall" width="80%">Other gifts, grants and/or divident received</td>
							    <td align="right" class="valuetextsmall" width="9%">$2,000.00</td>
                        	</tr>
	                        <tr class="bannercell">
		                        <td class="bannertext" colspan="2" align="right" width="81%">Total Expense:</td>
    							<td align="right" class="bannertext" width="9%">$10,624.00</td>
                        	</tr>
	
                        </table>

                        <br />
                        
                        <table cellspacing="0" border="1" rules="all" 
							style="border-color:gray;width:100%;border-collapse:collapse;">
	
	                        <tr class="bannercell">
		                        <td class="bannertext" colspan="3" align="left">3.&nbsp;BALANCE - FISCAL YEAR 2017</td>
										
                        	</tr>
	
	                        <tr class="footerbannercell" align="center" valign="top" >
		                        <td colspan="2" align="left" class="theadertext" width="81%">&nbsp;Item</td>
		                        <td class="theadertext" width="9%">Amount</td>
	                        </tr>
	
	                        <tr class="datacell">
		                        <td class="valuetextsmall" width="1%">3.1</td>
                        										
		                        <td class="valuetextsmall" width="80%">Total Income</td>
		                        <td align="right" class="valuetextsmall" width="9%">$12,624.00</td>
                        	</tr>
                        	<tr class="datacell2" >
		                        <td class="valuetextsmall" width="1%">3.2</td>
								<td class="valuetextsmall" width="80%">Total Expense</td>
							    <td align="right" class="valuetextsmall" width="9%">$10,000.00</td>
                        	</tr>
	                        <tr class="bannercell">
		                        <td class="bannertext" colspan="2" align="right" width="81%">Ending Balance End-of-the-year 2017:</td>
    							<td align="right" class="bannertext" width="9%">$2,000.00</td>
                        	</tr>
	
                        </table>

                        

                        </TD>
                    </tr>
                   </table>
                           
							
							
							<!-- end content table -->
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<!-- show the content end --->
</asp:Content>
