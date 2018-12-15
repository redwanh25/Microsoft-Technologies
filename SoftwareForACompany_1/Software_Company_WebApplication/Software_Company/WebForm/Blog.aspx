<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="Software_Company.WebForm.Blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>
    <style>
        #Image1:hover {
            overflow: hidden;
            transition: all 1.0s ease;
            transform: scale(1.5);
        }
    </style>
    <div class="container">
        <div class="row">
            <%--<asp:Label ID="TitleName1" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="DateTime1" runat="server" Text="Label"></asp:Label>
            <asp:Image ID="Image1" runat="server" CssClass="img-responsive" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>

            <asp:GridView ID="GridView1" runat="server" GridLines="None" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="" InsertVisible="False" SortExpression="CustomerId">
                        <ItemTemplate>
                            <div class="well">
                                <asp:Label CssClass="h2 shadow_T" ID="txbType" Text='<%# Eval("Title") %>' runat="server"></asp:Label>
                                <br />
                                <br />
                                <asp:Label ForeColor="Red" CssClass="h4 navbar-right" ID="TextBox1" Text='<%# Eval("Date") %>' runat="server"></asp:Label>
                                <br />
                                <br />
                                <br />

                                <div class="container">
                                    <div class="tz-gallery">
                                        <div class="row">
                                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 col-lg-offset-3 col-md-offset-3 col-sm-offset-3 col-xs-offset-3">
                                                <%--<a class="lightbox" href="../Image/rocks.jpg">--%>
                                                <%--<%#GetImage(Container.DataItem)%>--%>       <%--method k call kora hoise. ai method ta Blog.aspx.cs er moddhe ase--%>
                                                <%--<asp:Image Style="border-radius: 10px" ID="Image1" runat="server" CssClass="img-responsive shadow_B" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("BlogImage")) %>' />--%>
                                                <%--</a>--%>
                                                <%#GetImage(Container.DataItem)%>      
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="well">
                                    <asp:Label CssClass="h4" ID="TextBox2" Text='<%# Eval("Text") %>' runat="server"></asp:Label>
                                </div>
                            </div>

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <script type="text/javascript">
        baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>
