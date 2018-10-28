<%@ Page Title="" Language="C#" MasterPageFile="~/BestowerSoft.Master" AutoEventWireup="true" CodeBehind="BestowerSoft.aspx.cs" Inherits="BFWeb.BestowerSoft1" %>
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
									<td class="bannertext" vAlign="bottom" align="left">HOME - BESTOWER ACCOUNTING SOFTWARE</td>
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
							<span class="valuetextsmall">
                            
                            Project Management System Database [PMSD] is a project assignment given in CIS744 course, Spring 2008, Kansas State University. Following is the description of the requirement:
                            <br /><br />
                            <b>Problem Description Summary:</b><br />
                                <ul><li>	
                                The Project Management System Database (PMSD) exists to capture the information for each program unit of a given project. 
                                </li>
                                <li>A user must login with a valid password before using the system.</li>

                                <li>The information maintained about each unit includes the unit name, unit type (package or class), assigned programmer, status of development, current version, and reference to the corresponding requirements document.</li>
                                <li>Only a manager may input information into the system. However, the information may be queried by any valid user of the system.</li> 


                                <li>The possible interactive operations that a user may request include:

                                listing project data (sorted by programmer name or primary requirements) displaying all information on a selected program unit, collecting statistics on the level of development for all programming units. 
                                An inquiry session will continue until a user enters a request to quit.</li>

                                <li>To safeguard the data, an operator may backup the database by logging in and performing a backup operation. </li>
                                </ul>
                           <br />	
                           
                           <b>Interactive User Operation Include:</b><br />
                           <ul>
                                <li>List project data by programming unit</li>
                                <ul><li>May be sorted by assigned programmer, primary requirements, or unsorted</li></ul>
                                <li>Display information about a specific program unit</li>
                                <ul><li>User selects one unit from list and then requests further information</li></ul>
                                	
                                <li>Collect statistics on the level of development for all selected programming units</li>
                                <ul><li>User selects multiple program units from lists and requests statistics</li>
                                <li>Statistics include number of units in each status state as well as a estimate of overall completion percentage</li>
                           </ul>
                            </ul>
                            
                            <b>Users and level of access:</b><br />
                            <ul>
                            <li>Manager</li>
                            <ul>
                            <li>Requires Login</li>
                            <li>May Query System</li>
                            <li>May Enter Information</li>
                            </ul>
                            <li>User</li>
                            <ul>
                            <li>Requires Login</li>
                            <li>May Query System</li>
                            </ul>

                            	
                            <li>Operator</li>
                            <ul>
                            <li>Requires Login</li>
                            <li>May perform backup operation</li>
                            </ul>

                            </ul>

                           						
							</span>
							<!-- end content table -->
						</TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
	<!-- show the content end --->




</asp:Content>
