<%@ Page Title="" Language="C#" MasterPageFile="~/BFWeb.Master" AutoEventWireup="true" CodeBehind="EnableCookiesIE.aspx.cs" Inherits="BFWeb.EnableCookiesIE" %>
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
									<td class="bannertext" valign="bottom" align="left">HOW TO ENABLE COOKIES IN INTERNET EXPLORER</td>
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
                                                        


Follow the steps below according to the version of the browser you are using to enable the cookies needed to make donations using payPal or accessing  backend applicaiton:

<p><a href="#ie8">Internet Explorer 8.0</a><br/>
 <a href="#ie7">Internet Explorer 7.0</a><br/>
 <a href="#ie6">Internet Explorer 6.0</a><br/>
 <a href="#ie5">Internet Explorer 5.0/5.5</a> </p>

<p><strong>TIP:</strong> If you do not know the version of your browser click <strong>Help->About Internet Explorer</strong> (Note: the help menu is a "?" icon in Internet Explorer 8).</p>
<h2 id="ie8">Internet Explorer 8.0</h2>
<ol>
 <li> Click on the "Tools" menu in Internet Explorer and select "Internet Options"<br />
 <img src="./Lib/scs/ie8-1.png" alt="Internet Explorer cookies - Tools>Internet Options" /></li>

 <li> Change to the "Privacy" tab.<br /><br>
 </li>
 <li> You now have two options (refer to section 3.1 and 3.2 for details) depending on how much you want to restrict cookies:
 <h3>3.1 Allow cookies for all sites</h3>
 <ol>
 <li> Set the slider to "Accept All Cookies". <br />
 <i>NOTE: Set the slider to "Low" should also be fine for making donations and logon to ORCA backend</i><br>
<img src="./Lib/scs/ie8-2.png" alt="Internet Explorer Cookies - Privacy" />
 </li>
 <li>Click "Apply"</li>

 <li>Click "OK".</i>
 </ol>
 <h3>3.2 Allow cookies to selective sites</h3>
 <p><strong>NOTE</strong>: Using this method you will have to enable cookies for every site you need them on.</p>

 <ol>
 <li> Set the slider to "High". then Click on "Sites" button<br />
 <img src="./Lib/scs/ie8-3.png" alt="Internet Explorer Cookies - High" /> </li>

 <li> Enter "paypal.com" in the "Address of the website:" input.<br />

 <img src="./Lib/scs/ie8-4.png" alt="Internet Explorer Cookies - Allow paypal.com"  /> </li>
 <li> Click "Allow" and then Click "OK" button <br />
 <img src="./Lib/scs/ie8-5.png" alt="Internet Explorer Cookies - added paypal.com"  /></li>
 <li> Click "Apply".<br />
 <img src="./Lib/scs/ie8-6.png" alt="Internet Explorer Cookies - Apply Settings"  />

 </li>
 <li> Click "OK". <br />
  <img src="./Lib/scs/ie8-7.png" alt="Internet Explorer Cookies - All Done ... Clikc OK"  />
 </li>
 </ol>

 </li>
</ol>
<h2 id="ie7">Internet Explorer 7.0</h2>

<ol>
 <li> Click on the "Tools" menu in Internet Explorer and select "Internet Options"<br />
 <img src="./Lib/scs/ie7-1.png" alt="Internet Explorer cookies - Tools>Internet Options" /></li>

 <li> Change to the "Privacy" tab.<br /><br>
 </li>
 <li> You now have two options (refer to section 3.1 and 3.2 for details) depending on how much you want to restrict cookies:
 <h3>3.1 Allow cookies for all sites</h3>
 <ol>
 <li> Set the slider to "Accept All Cookies". <br />
 <i>NOTE: Set the slider to "Low" should also be fine for making donations and logon to ORCA backend</i><br>
<img src="./Lib/scs/ie7-2.png" alt="Internet Explorer Cookies - Privacy" />
 </li>
 <li>Click "Apply"</li>
 <li>Click "OK".</i>
 </ol>
 <h3>3.2 Allow cookies to selective sites</h3>
 <p><strong>NOTE</strong>: Using this method you will have to enable cookies for every site you need them on.</p>

 <ol>
 <li> Set the slider to "High". then Click on "Sites" button<br />
 <img src="./Lib/scs/ie7-3.png" alt="Internet Explorer Cookies - High" /> </li>

 <li> Enter "paypal.com" in the "Address of the website:" input.<br />

 <img src="./Lib/scs/ie7-4.png" alt="Internet Explorer Cookies - Allow paypal.com"  /> </li>
 <li> Click "Allow" and then Click "OK" button <br />
 <img src="./Lib/scs/ie7-5.png" alt="Internet Explorer Cookies - added paypal.com"  /></li>
 <li> Click "Apply".<br />
 <img src="./Lib/scs/ie7-6.png" alt="Internet Explorer Cookies - Apply Settings"  />
 </li>
 <li> Click "OK". <br />
  <img src="./Lib/scs/ie7-7.png" alt="Internet Explorer Cookies - All Done ... Clikc OK"  />
 </li>
 </ol>


<h2 id="ie6">Internet Explorer 6.0</h2>

<ol>
 <li> Click on the "Tools" menu in Internet Explorer and select "Internet Options"<br />
 <img src="./Lib/scs/ie6-1.png" alt="Internet Explorer cookies - Tools>Internet Options" /></li>

 <li> Change to the "Privacy" tab.<br /><br>
 </li>
 <li> You now have two options (refer to section 3.1 and 3.2 for details) depending on how much you want to restrict cookies:
 <h3>3.1 Allow cookies for all sites</h3>
 <ol>
 <li> Set the slider to "Accept All Cookies". <br />
 <i>NOTE: Set the slider to "Low" should also be fine for making donations and logon to ORCA backend</i><br>
<img src="./Lib/scs/ie6-2.png" alt="Internet Explorer Cookies - Privacy" />
 </li>
 <li>Click "Apply"</li>
 <li>Click "OK".</i>
 </ol>
 <h3>3.2 Allow cookies to selective sites</h3>
 <p><strong>NOTE</strong>: Using this method you will have to enable cookies for every site you need them on.</p>

 <ol>
 <li> Set the slider to "High". then Click on "Sites" button<br />
 <img src="./Lib/scs/ie6-3.png" alt="Internet Explorer Cookies - High" /> </li>

 <li> Enter "paypal.com" in the "Address of the website:" input.<br />

 <img src="./Lib/scs/ie6-4.png" alt="Internet Explorer Cookies - Allow paypal.com"  /> </li>
 <li> Click "Allow" and then Click "OK" button <br />
 <img src="./Lib/scs/ie6-5.png" alt="Internet Explorer Cookies - added paypal.com"  /></li>
 <li> Click "Apply".<br />
 <img src="./Lib/scs/ie6-6.png" alt="Internet Explorer Cookies - Apply Settings"  />
 </li>
 <li> Click "OK". <br />
  <img src="./Lib/scs/ie6-7.png" alt="Internet Explorer Cookies - All Done ... Clikc OK"  />
 </li>
 </ol>


<h2 id="ie5">Internet Explorer 5.0/5.5</h2>
<ol>
 <li>Click on the <strong>Tools</strong>-menu in Internet Explorer.</li>
 <li>Click on the <strong>Internet Options</strong> item in the menu - a new window opens.</li>
 <li>Click on the <strong>Security</strong> tab near the top of the window. <br /><img src="./Lib/scs/ie5-1.png" alt="Internet Explorer cookies" width="406" height="452" /></li>

 <li>Click on the <strong>Custom Level...</strong> button near the bottom of the window.</li>
 <li>Scroll down to <strong>Cookies </strong> in the new dialog, and set both <strong>"Allow cookies that are stored on your computer"</strong> and <strong>"Allow per-session cookies</strong> to <strong>Enable</strong>. <br /><img src="./Lib/scs/ie5-2.png" alt="Internet Explorer cookies" width="353" height="405" /></li>

 <li>Click "OK" button.</li>

                               <br />
				
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
