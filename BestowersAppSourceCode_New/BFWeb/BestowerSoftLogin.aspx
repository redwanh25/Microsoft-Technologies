<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BestowerSoftLogin.aspx.cs" Inherits="BFWeb.BestowerSoftLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Bestower Accounting Software</title>
    	<link rel="stylesheet" type="text/css" href="Themes/drupal.css" />
		
</head>
<body>
    <form id="form1" runat="server">
			<div align="center">
				<!-- begin login -->
				<asp:Panel ID="panelLogin" Runat="server">
					<TABLE class="lightbannercell" id="Table53" cellSpacing="1" cellPadding="0" width="350"
						align="center" border="0" valign="middle">
						<TR vAlign="bottom" align="center">
							<TD>
								<TABLE id="Table44" cellSpacing="0" cellPadding="0" border="0">
									<TR class="lightbannercell" vAlign="top">
										<TD>
											<TABLE id="Table45" cellSpacing="2" cellPadding="0" width="99%" border="0">
												<TR>
													<TD class="bannertext" vAlign="bottom" noWrap align="center">BESTOWER ACCOUNTING SOFTWARE  - PLEASE 
														LOGIN</TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
						<TR vAlign="top" align="center">
							<TD class="valuecell">
								<TABLE cellSpacing="0" cellPadding="0" align="center" border="0">
									<TR class="valuetextsmall">
										<TD>&nbsp;</TD>
										<TD>
											<asp:label id="message" runat="server" cssclass="errortext"></asp:label></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD align="right"><SPAN class="valuetextsmall">User&nbsp;Name:&nbsp; </SPAN>
										</TD>
										<TD>
											<asp:textbox id="username" runat="server" cssclass="NormalTextBox" width="130px"></asp:textbox></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD align="right"><SPAN class="valuetextsmall">Password:&nbsp; </SPAN>
										</TD>
										<TD>
											<asp:textbox id="password" runat="server" cssclass="NormalTextBox" width="130px" textmode="password"></asp:textbox></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD>&nbsp;</TD>
										<TD align="Left">
											<asp:button id="btnLogin" runat="server" Text="Login" Width="70" onclick="btnLogin_Click"></asp:button></TD>
									</TR>
									<TR>
										<TD align="center" colSpan="2">&nbsp;</TD>
									</TR>

									<TR class="valuetextsmall">
										<td>&nbsp;</td>
										<TD align="left">
                                            <asp:LinkButton ID="lbForgotPassword" runat="server" CssClass="valuetextsmall" OnClick="lbForgotPassword_Click" >Forgot Password?</asp:LinkButton>
                                        </TD>
									</TR>
									<TR>
										<TD align="center" colSpan="2">&nbsp;</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
					<table cellpadding="1" cellspacing="0" border="0">
					<tr><td></td></tr>
					</table>
				</asp:Panel>
				<!-- end login -->
				<!-- begin send password -->
				<asp:Panel ID="panelSendPassword" Runat="server" Visible="False">
					<TABLE class="lightbannercell" id="Table153" cellSpacing="1" cellPadding="0" width="350"
						align="center" border="0" valign="middle">
						<TR vAlign="bottom" align="center">
							<TD>
								<TABLE id="Table144" cellSpacing="0" cellPadding="0" border="0">
									<TR class="lightbannercell" vAlign="top">
										<TD>
											<TABLE id="Table145" cellSpacing="2" cellPadding="0" width="99%" border="0">
												<TR>
													<TD class="bannertext" vAlign="bottom" noWrap align="center">BESTOWER ACCOUNTING SOFTWARE  - SEND PASSWORD</TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
						<TR vAlign="top" align="center">
							<TD class="valuecell">
								<TABLE cellSpacing="0" cellPadding="0" align="center" border="0">
									<TR class="valuetextsmall">
										<TD colspan=2 align="center"><asp:label id="labelMsg" runat="server" cssclass="errortext"></asp:label>&nbsp;</TD>
									</TR>
									<TR class="valuetextsmall">
										<TD align="right"><SPAN class="valuetextsmall">User Name:</SPAN>
										</TD>
										<TD>
											<asp:textbox id="tbUserName" runat="server" cssclass="NormalTextBox" width="150px"></asp:textbox>
											</TD>
									</TR>
									<TR class="valuetextsmall">
										<TD align="right"><SPAN class="valuetextsmall">Email Address:</SPAN>
										</TD>
										<TD>
											<asp:textbox id="tbEmail" runat="server" cssclass="NormalTextBox" width="150px"></asp:textbox><SPAN class="valuetextsmall"></span>
											</TD>
									</TR>
									<TR class="valuetextsmall">
										<TD>&nbsp;</TD>
										<TD align="left">
											<asp:button id="btnSendPassword" runat="server" Text="Send" Width="70" onclick="btnSendPassword_Click"></asp:button>
                                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="70" OnClick="btnCancel_Click" /></TD>
									</TR>
									<TR>
										<TD align="center" colSpan="2">&nbsp;</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
					<table cellpadding="1" cellspacing="0" border="0">
					<tr><td></td></tr>
					</table>
				</asp:Panel>
				
				<!-- end change password -->
				<TABLE border="0" cellspacing="0" cellpadding="0" width="350" align="center" summary="footer of the page" align="center">
        	        
	                <TR>
		                <TD>
			                <TABLE border="0" width="100%" cellspacing="0" summary="PMSD Footer" ID="Table1">
				                <TR class="footerbannercell">
					                <TD align="center" class="copyright">
        						        
						                Copyright © 2014 Bestower Corporation &trade;
					                </TD>
				                </TR>
			                </TABLE>
		                </TD>
	                </TR>
                </TABLE>
			</div>
    </form>
</body>
</html>