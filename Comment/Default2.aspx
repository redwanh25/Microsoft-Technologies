<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <style>
        .col-md-12 {
        padding-left:100px;
        }

        tr, td {
        width:500px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div >
        <div class="container" style=" padding:15px 20px; width:auto; ">
        <div class="row">
            <div class="col-md-6">
                <asp:TextBox ID="textComment" runat="server" CssClass="input-group" TextMode="MultiLine" Width="300px"  Height="60px" Rows="15" ></asp:TextBox>
<%--        <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/h.jpg"  Width="30px" Height="30px"  style="border:1px solid #4800ff;" />--%>
<br/>        <asp:Button ID="btnCommentpublilsh" CssClass="btn-sm btn-default"   Text="Comment" runat="server"  OnClick="btnCommentPublish_Click" />
            </div>
            <div class="col-md-6"></div>
        </div>
    

    </div>

     <%--Comment Session--%>
        <asp:GridView ID="GridView1" BorderStyle="None" CssClass="table-responsive" Width="100%"  GridLines="None" runat="server" AutoGenerateColumns="False" ShowHeader="False">
            <Columns>
                 
                <asp:BoundField DataField="ParentCommentID"  Visible="false" HeaderText="ParentCommentID" />

                <asp:TemplateField HeaderText="ParentMessage">
                    <ItemTemplate>
                        <div class="container">
                            <div class="row">
                                <div class="col-lg-12">
                                     <table>
                                         <tr>
                                    <td style="width:55px;vertical-align:top;padding-top:10px">
                                    <asp:Label ID="lblParentDate" runat="server" Text='<%#Bind("ParanetCommentDate") %>'></asp:Label>
                                        <br /> 
                                            <asp:Image ID="ImageParent" runat="server" style="width:25px;height:25px;" ImageUrl="~/Image/student-512.png" />
                                    <asp:Label ID="Label4" Font-Bold="true" ForeColor="#cc0066" runat="server" Text='<%# Bind("ParentUserName") %>'></asp:Label> 
                                         
                                    </td>
                                          </tr>
                                               
                                         <tr>
                                         <td><asp:Label ID="Label1" runat="server" Text='<%# Bind("ParentCommentMessage") %>'></asp:Label></td>     
                                         </tr>
                                         <tr >
                                             <td><asp:Label ID="lb1COmmenId" runat="server" Visible="false" Text='<%#Eval("ParentCommentID") %>'></asp:Label>
                                         
                                                         <a class="link" id='lnkReplyParent<%#Eval("ParentCommentID") %>' href="javascript:void(0)" onclick="showReply(<%#Eval("ParentCommentID") %>);return false;">Reply</a>&nbsp;
                                        <a class="link" id="lnkCancle" href="javascript:void(0)" onclick="closeReply(<%#Eval("ParentCommentID") %>);return false;">Cancle</a>
                                        <div id='divReply<%#Eval("ParentCommentID") %>' style="display:none;margin-top:5px;">
                                            <asp:TextBox ID="textCommentReplyParent" CssClass="input-group" runat="server" Width="300px" TextMode="MultiLine" ></asp:TextBox>
                                            <br />
                                            <asp:Button ID="btnReplyParent" runat="server" Text="Reply" CssClass="input-group btn"  OnClick="btnReplyParent_Click" /></div>
                                             </td>
                                         </tr>
                                          
                                         <tr >
                                              <td style="padding-left:100px;border-bottom:1px solid #4cff00; ">
                                                 <br />
                                                  
                                     <asp:GridView ID="GridView2" BorderStyle="None" GridLines="None" runat="server" AutoGenerateColumns="False" DataSource='<%# Bind("Empl") %>' ShowHeader="False">
                            <Columns>
                                <asp:TemplateField HeaderText="UserName">
                                    <ItemTemplate>
                                        <asp:Label ID="lblChildDate" runat="server" Text='<%#Bind("ChilCommentDate") %>'></asp:Label>
                                        <br />
                                        <asp:Image ID="ImageParent" runat="server" style="width:25px;height:25px;" ImageUrl="~/Image/student-512.png" />
                                        <asp:Label ID="Label2" runat="server" Font-Bold="true" ForeColor="#ff0066" Text='<%#Bind("UserName") %>'></asp:Label>
                                        <br />
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("ChildcommentMessage") %>'></asp:Label>
                                        <hr />
                                        
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 
                            </Columns>
                        </asp:GridView> 
                       
                                                         <br />
                                                          
                                             
                                         
                                                      
                                                 
                                             </td>
                                         </tr>
                                     </table>
                                </div>
                                 
                            </div>
                        </div>
                        
                         
                        
                     
                       
                        
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllDepartmentsandEmployee" TypeName="ParentCommentIDAcess"></asp:ObjectDataSource>
        <br />
    
    </div>
        <script src="script/jquery.min.js"></script>
    <script type="text/javascript">
        //GridView Comment
        function showReply(n) {
            $("#divReply" + n).show();
            return false;
        }
        function closeReply(n) {
            $("#divReply" + n).hide();
            return false;
        }
         
         
       </script>
    </form>

</body>
</html>
