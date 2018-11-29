<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Software_Company.WebForm.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <style>
        .well {
            min-height: 10px;
            padding: 5px;
            margin-bottom: 10px;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-lg-7 col-md-7 col-sm-7 col-xs-12">
                <div class="h2">
                    <p>Contact us at Software Company</p>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group">
                            <label>Name</label>
                            <asp:TextBox ID="Name" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>

                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group">
                            <label>Phone Number</label>
                            <asp:TextBox ID="Phone" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group">
                            <label>Email</label>
                            <asp:TextBox ID="Email" runat="server" CssClass="form-control" placeholder="Email Address"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="form-group">
                            <label>Address</label>
                            <asp:TextBox ID="Address" runat="server" CssClass="form-control" placeholder="Address"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="form-group">
                            <label>Message </label>
                            <asp:TextBox ID="Message" runat="server" CssClass="form-control" placeholder="Write here..." TextMode="MultiLine" Rows="4"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div id="divError" class="alert alert-danger collapse">
                            <button id="linkClose" class="close">&times;</button>
                            <div id="divErrorText"></div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <asp:Button ID="Send" runat="server" Text="Send Message" CssClass="btn btn-danger btn-block" />
                    </div>
                </div>
            </div>
            <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
                <br /><br />
                <div>
                    <div class="well">
                        <h4>Address:</h4>
                        <p>Abcdefghijklmn 00, Abcde ABC</p>
                        <p>123 34 Dhaka</p>
                        <p>Bangladesh</p>
                    </div>
                    <div class="well">
                        <h4>Organization number:</h4>
                        <p>123456-1234</p>
                    </div>
                    <div class="well">
                        <h4>Tel: +12 34 567 89 10</h4>
                    </div>
                    <div class="well">
                        <h4>E-post:</h4>
                        <p>redwanh25@gmail.com</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
