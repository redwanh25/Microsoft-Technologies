<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Software_Company.WebForm.ContactUs" %>

<%--be carefull ClientIDMode="Static" aita na dile aishob page a jquery id selector kaj korbe na.
jegula page master page theke add content page create kora hoyese--%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server" ClientIDMode="Static">
    <style>
        /*well k override kora hoise.*/
        .well {
            min-height: 10px;
            padding: 5px;
            margin-bottom: 10px;
        }
        .temp.btn:hover{
            animation: bounce .8s;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-lg-7 col-md-7 col-sm-7 col-xs-12">
                <div class="h2 animated fadeInLeft">
                    <p>Contact us at Software Company</p>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group has-success animated fadeInLeft">
                            <label>Name</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-user"></span>
                                </span>
                                <asp:TextBox ID="Name1" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group has-success animated bounceInLeft">
                            <label>Phone Number</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-phone-alt"></span>
                                </span>
                                <asp:TextBox ID="Phone1" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group has-success animated fadeInLeft">
                            <label>Email</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-envelope"></span>
                                </span>
                                <asp:TextBox ID="Email1" runat="server" CssClass="form-control" placeholder="Email Address"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group has-success animated bounceInLeft">
                            <label>Address</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon glyphicon-home"></span>
                                </span>
                                <asp:TextBox ID="Address1" runat="server" CssClass="form-control" placeholder="Address"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row  animated fadeInLeft">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="form-group has-success">
                            <label>Message </label>
                            <asp:TextBox ID="Message1" runat="server" CssClass="form-control" placeholder="Write here..." TextMode="MultiLine" Rows="4"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div id="divError1" class="alert alert-danger collapse">
                            <button id="linkClose1" class="close">&times;</button>
                            <div id="divErrorText1" runat="server"></div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 animated bounceInLeft">
                        <%--<input id="Send1" type="button" value="Send Message" runat="server" class="btn btn-info btn-block"/>--%>
                        <%--<asp:Button ID="Send1" runat="server" Text="Send Message" CssClass="temp btn btn-block" OnClick="Send_Click" style="border-radius:20px; outline:none; background-color:#DEEFD7; font-size:17px"/>--%>
                        <asp:LinkButton ID="Send1" runat="server" CssClass="btn btn-block" OnClick="LinkButton1_Click" style="border-radius:30px; outline:none; background-color:#DEEFD7; font-size:18px">
                            <%--<marquee behavior="alternate" scrollamount="6">Send Your Message</marquee>--%>
                            Send Your Message
                        </asp:LinkButton>

                    </div>
                </div>
            </div>
            <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
                <br />
                <br />
                <div>
                    <div class="well animated fadeInRight">
                        <h4>Address:</h4>
                        <p>Abcdefghijklmn 00, Abcde ABC</p>
                        <p>123 34 Dhaka</p>
                        <p>Bangladesh</p>
                    </div>
                    <div class="well animated bounceInRight">
                        <h4>Organization number:</h4>
                        <p>123456-1234</p>
                    </div>
                    <div class="well animated fadeInRight">
                        <h4>Tel: +12 34 567 89 10</h4>
                    </div>
                    <div class="well animated bounceInRight">
                        <h4>E-post:</h4>
                        <p>redwanh25@gmail.com</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <hr style="border: 5px solid; color: #F5F3F1">
    <div class="container">
        <div class="row">
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-6 text-center animated bounceInLeft">
                <h3><b>Sweden</b></h3>
                <p>Abcdefghijklmn 00, Abcde ABC</p>
                <p>123 34 Dhaka</p>
                <p>Bangladesh</p>
                <p style="color:orange">Tel: +12 34 567 89 10</p>
            </div>
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-6 text-center animated bounceInLeft">
                <h3><b>USA</b></h3>
                <p>Abcdefghijklmn 00, Abcde ABC</p>
                <p>123 34 Dhaka</p>
                <p>Bangladesh</p>
                <p style="color:orange">Tel: +12 34 567 89 10</p>
            </div>
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-6 text-center animated bounceInRight">
                <h3><b>India</b></h3>
                <p>Abcdefghijklmn 00, Abcde ABC</p>
                <p>123 34 Dhaka</p>
                <p>Bangladesh</p>
                <p style="color:orange">Tel: +12 34 567 89 10</p>
            </div>
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-6 text-center animated bounceInRight">
                <h3><b>Germany</b></h3>
                <p>Abcdefghijklmn 00, Abcde ABC</p>
                <p>123 34 Dhaka</p>
                <p>Bangladesh</p>
                <p style="color:orange">Tel: +12 34 567 89 10</p>
            </div>
        </div>
    </div>
    <br />
    <script type="text/javascript">
        $(document).ready(function () {

            $('#Send1').click(function () {
                if ($('#Name1').val().trim() === '' || $('#Phone1').val().trim() === '' || $('#Email1').val().trim() === ''
                    || $('#Address1').val().trim() === '' || $('#Message1').val().trim() === '') {
                    var str = '';
                    if ($('#Name1').val().trim() === '') {
                        str += "Name is missing ** ";
                    }
                    if ($('#Phone1').val().trim() === '') {
                        str += "Phone is missing ** ";
                    }
                    if ($('#Email1').val().trim() === '') {
                        str += "Email is missing ** ";
                    }
                    if ($('#Address1').val().trim() === '') {
                        str += "Address is missing ** ";
                    }
                    if ($('#Message1').val().trim() === '') {
                        str += "Message is missing ** ";
                    }
                    $('#divErrorText1').text(str);
                    $('#divError1').show('fade');
                    return false;       // return false na dile hobe na. return false er jonno button ta kaj korbe na.
                }
                else {
                    alert('Thank You!\nNext Time We Will Contact With You...');
                }
            });
            $('#linkClose1').click(function () {
                $('#divError1').hide('fade');
                return false;
            });
        });
    </script>

</asp:Content>
