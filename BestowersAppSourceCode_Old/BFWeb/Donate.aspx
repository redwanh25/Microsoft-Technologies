<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="Donate.aspx.cs" Inherits="BFWeb.Donate" %>
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
									<td class="bannertext" valign="bottom" align="left">DONATE SECURELY USING PAYPAL</td>
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
							
							<span class="valuetextsmall">
							
							<b>Pay Online:</b><br />
Bestower Foundation uses PayPal to process credit cards for donations. Be assured that the transaction is very secure and that we do not store any user information. You can donate now by clicking the button below. May Lord accept your effort!
<br />


<TABLE>
<TR><TD class="valuetextsmall">
<input type="hidden" name="cmd" value="_s-xclick">

<input type="radio" name="hosted_button_id" value="4Q9RCNB8X74EW" checked>Scholarship for Students Fund<br />
<input type="radio" name="hosted_button_id" value="CQ6U98XJD2HKY">Grants for the Needy Fund<br />
<input type="radio" name="hosted_button_id" value="4FPKQTG4F3QJY">Grants for Religious Institution Fund<br />
<input type="radio" name="hosted_button_id" value="WUTEAYNQ46CJU">Zakat Fund<br />
<input type="radio" name="hosted_button_id" value="WPT656EUXP8KU">Affiliation Fund<br />
<input type="radio" name="hosted_button_id" value="38K9QRLJ677D4">General Fund<br />


</TD>
<TR><TD class="valuetextsmall">
<asp:ImageButton runat="server" ImageUrl="https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif" OnClientClick="postdata(); alert('hello'); return false;" />

<!--
<input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">
-->

</TD>
</TR>
</TABLE>


 
<br />
 
If you would rather mail a check or do a wire transfer, please follow the informaiton below: <br />
<br />
<b>Mail a check:</b><br />
Please send your check to the address below.<br />
Bestower Foundation<br />
6023 NW 107th Place<br />
Alachua, FL 32615<br />
USA<br /><br />
<b>Wire Transfer:</b><br />
If you prefer to do wire transfer directly to Bestower Foundation bank account, please e-mail <a href="maito:info@bestower.org">info@bestower.org</a> to obtain the wire transfer information (e.g. routing number, account number etc.) needed by your bank.

<br /><br />
<br />
<b>Paypal Frequently Asked Questions:</b><br /><br />
<TABLE>
<tr>
<td class="valuetextsmall" colspan="2">
<b>Q1:&nbsp;I am using Internet Explorer and when I click the "Donate" button, I get "Fatal Failure". How can I resolve this?</b></td>
</tr>
<tr>
<td class="valuetextsmall" colspan="2">
PayPal requires a cookie-enabled browser to make donations online. By default, all major broswers (e.g. Mozilla, Safari, Chrome etc) accept cookies except IE. Hence, you need to enable cookies in your Internet Explorer browser. Please follow the steps outlined at <a href="EnableCookiesIE.aspx">How to Enable Cookies in Internet Explorer</a> web page. After enabling cookies, please make sure to close the current browser and open a new browser session.</td>
</tr>

<tr>
<td class="valuetextsmall" colspan="2">&nbsp;</td></tr>

<tr>
<td class="valuetextsmall" colspan="2">
<b>Q2:&nbsp;I made sure my browser is set to accept cookies. However, I am still geting "Fatal Failure" when I clicked on "Donate" button. What can I do?</b></td>
</tr>
<tr>
<td class="valuetextsmall" colspan="2">
Please contact technical support at <a href="mailto:support@bestower.org">support@bestower.org</a></td>
</tr>

</TABLE>


														
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
