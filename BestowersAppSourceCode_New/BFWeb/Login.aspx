<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BFWeb.Login" %>
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
									<td class="bannertext" valign="bottom" align="left">BESTOWER FOUNDATION AFFILIATES - PLEASE LOGIN</td>
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
							<table width="100%"><tr><td>
							
							<span class="valuetextsmall">
                                                        
                                                        
                                                        
<!-- begin login -->
				<asp:Panel ID="panelLogin" Runat="server">
					<TABLE border="0" cellSpacing="1" cellPadding="0" width="100%"	align="center" border="0" valign="middle">
						
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
											<asp:textbox id="username" runat="server" cssclass="NormalTextBox" width="150px"></asp:textbox>
											<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="*"></asp:requiredfieldvalidator></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD align="right"><SPAN class="valuetextsmall">Password:&nbsp; </SPAN>
										</TD>
										<TD>
											<asp:textbox id="password" runat="server" cssclass="NormalTextBox" width="150px" textmode="password"></asp:textbox>
											<asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="*"></asp:requiredfieldvalidator></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD>&nbsp;</TD>
										<TD>
											<asp:button id="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click"></asp:button></TD>
									</TR> <!--
									<TR class="valuetextsmall">
										<TD align="center" colSpan="2"><SPAN class="valuetextsmall"><A href="javascript:forgotPassword();">Forgot password?</A></span></TD>
									</TR>
									-->
									<TR>
										<TD align="center" colSpan="2">&nbsp;</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
				</asp:Panel>
				<!-- end login -->     
				
				<!-- begin change password -->
				<asp:Panel ID="panelCP" Runat="server" Visible="False">
					<TABLE class="lightbannercell" id="Table153" cellSpacing="1" cellPadding="0" width="350"
						align="center" border="0" valign="middle">
						<TR vAlign="bottom" align="center">
							<TD>
								<TABLE id="Table144" cellSpacing="0" cellPadding="0" border="0">
									<TR class="lightbannercell" vAlign="top">
										<TD>
											<TABLE id="Table145" cellSpacing="2" cellPadding="0" width="99%" border="0">
												<TR>
													<TD class="bannertext" vAlign="bottom" noWrap align="center">BESTOWER FOUNDATION - CHANGE YOUR 
														PASSWORD</TD>
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
										<TD align="center" colSpan="2">
											<asp:label id="labelMsg" runat="server" cssclass="errortext"></asp:label></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD align="right"><SPAN class="valuetextsmall">New&nbsp;Password:</SPAN>
										</TD>
										<TD>
											<asp:textbox id="TextboxCPNewPassword1" runat="server" cssclass="NormalTextBox" width="70px"
												textmode="password"></asp:textbox>
											<asp:requiredfieldvalidator id="Requiredfieldvalidator3" runat="server" ControlToValidate="TextboxCPNewPassword1"
												ErrorMessage="*"></asp:requiredfieldvalidator></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD align="right"><SPAN class="valuetextsmall">New&nbsp;Password:</SPAN>
										</TD>
										<TD>
											<asp:textbox id="TextboxCPNewPassword2" runat="server" cssclass="NormalTextBox" width="70px"
												textmode="password"></asp:textbox><SPAN class="valuetextsmall">(Confirm)</SPAN>
											<asp:requiredfieldvalidator id="Requiredfieldvalidator4" runat="server" ControlToValidate="TextboxCPNewPassword2"
												ErrorMessage="*"></asp:requiredfieldvalidator></TD>
									</TR>
									<TR class="valuetextsmall">
										<TD>&nbsp;</TD>
										<TD>
											<asp:button id="btnChangePassword" runat="server" Text="Change" Width="70" onclick="btnChangePassword_Click"></asp:button></TD>
									</TR>
									<TR>
										<TD align="center" colSpan="2">&nbsp;</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
				</asp:Panel>
				<!-- end change password -->
                                                   
				
							</td></tr></table>
							
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
