﻿<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="ApplyForAJob.aspx.cs" Inherits="Software_Company.WebForm.ApplyForAJob" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server" ClientIDMode="Static">

    <style>
        div ul li {
            line-height:150%;
        }
        div h4 {
            line-height:130%;
        }
    </style>

    <br />
    <br />
    <div class="container">
        <div align="center">
            <b style="font-size: 40px; color: orange">Software Engineer, Asp.net</b>
            <hr style="border: 4px solid; width: 375px; color: #F5F3F1">
        </div>
    </div>
    <br />

    <div class="container">
        <div class="row">
            <div class="col-lg-10 col-md-10 col-sm-12 col-xs-12 col-lg-offset-1 col-md-offset-1">
                <div class="well">
                    <h3 style="font-family: Impact">Job Responsibilities</h3>
                    <ul class="h4">
                        <li>Analyze and Design applications and databases</li>
                        <li>Develop standard web based business application using Asp.Net and SQL Server</li>
                        <li>Strong knowledge on ASP.NET MVC, Cshtml/Razor and JS/Jquery</li>
                        <li>Excellent capability of writing complex SQL queries and Procedure/function</li>
                        <li>Ability to meet deadlines and achieve specified results.</li>
                    </ul>
                </div>
                <div class="well">
                    <h4 style="font-family: Impact">Employment Status</h4>
                    <ul class="h4">
                        <li>Full-time</li>
                    </ul>
                    <h4 style="font-family: Impact">Educational Requirements</h4>
                    <ul class="h4">
                        <li>B.Sc in Computer Science and Engineering.</li>
                    </ul>
                    <h4 style="font-family: Impact">Experience Requirements</h4>
                    <ul class="h4">
                        <li>At least 3 year(s)</li>
                        <li>The applicants should have experience in the following area(s):</li>
                    </ul>
                </div>
                <div class="well">
                    <h3 style="font-family: Impact">Additional Requirements</h3>
                    <ul class="h4">
                        <li>Age 24 to 32 years</li>
                        <li>Both males and females are allowed to apply</li>
                        <li>At least 3 year experience of ASP.NET Development experience (Must)</li>
                        <li>Good understanding about SQL SERVER</li>
                        <li>Excellent Knowledge on C#/.NET, Entity Framework and LINQ</li>
                        <li>Sound Knowledge in Telerik</li>
                        <li>Candidate must have strong skills in programming languages such as JavaScript, HTML, XML, XHTML and XAML</li>
                        <li>Sound knowledge on OOP principles, design patterns etc.</li>
                        <li>Good understanding about .NET language features like Attributes, Reflections, Serializations and Generic etc.</li>
                        <li>Excellent capability of writing complex SQL queries and database administration</li>
                        <li>Writes optimized code</li>
                        <li>Should have sound knowledge in Web 2.0 concept, including Ajax Toolkits, JQuery, Ajax, , Angular, Crystal Report</li>
                        <li>You must be a good team player, highly self motivated and a strong communicator</li>
                        <li>Experience in ERP will be preferred.</li>
                        <li>Knowledge of Bangladesh Financial and Capital Markets is a STRONG PLUS.</li>
                    </ul>
                </div>
                <div class="well">
                    <h4 style="font-family: Impact">Job Location</h4>
                    <ul class="h4">
                        <li>Dhaka, Dhaka Division</li>
                    </ul>
                    <h4 style="font-family: Impact">Salary</h4>
                    <ul class="h4">
                        <li>Negotiable</li>
                    </ul>
                    <h4 style="font-family: Impact">Compensation & Other Benefits</h4>
                    <ul class="h4">
                        <li>Provident fund, Weekly 2 holidays, Performance bonus</li>
                        <li>Salary Review: Half Yearly</li>
                        <li>Festival Bonus: 2(Yearly)</li>
                    </ul>
                </div>
                <div class="well">
                    <h3 style="font-family: Impact">Read Before Apply</h3>
                    <h4>Company Information Cygnus Innovation Ltd. Address : House-C-39, 1st Floor, Block-C, Road-06, Niketon, Gulshan-1, Dhaka-1212. Web : Business : CYGNUS INNOVATION LTD. is one of the leading Information Technology Solution Companies in Bangladesh with a strong talented team that provides extensive range of products and services. It has built a reputation for innovation and delivering excellence in enterprise application development, with industry-specific software expertise in financial, real estate and medical sectors.
                    </h4>
                    <h4>We offer comprehensive products and services, custom software and web solutions for businesses worldwide. With a rich experience of successful offshore & national engagements, we are committed to building long lasting strategic partnerships with our clients to ensure extremely competitive and affordable prices, timely delivery and measurable business results. We constantly focus on providing high quality products and services to meet the exacting requirements of our customers.
                    </h4>
                </div>
                <div class="well">
                    <div class="row">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                            <div class="form-group has-success">
                                <label>Name</label>
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-user"></span>
                                    </span>
                                    <asp:TextBox ID="txtName" runat="server" placeholder="Enter your Name" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                            <div class="form-group has-success">
                                <label>Phone Number</label>
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-phone-alt"></span>
                                    </span>
                                    <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="Enter your Phone Number" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                            <div class="form-group has-success">
                                <label>Email ID</label>
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-envelope"></span>
                                    </span>
                                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your Email ID" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                            <div class="form-group has-success">
                                <label>Upload Your CV</label>
                                <div class="input-group">
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-open"></span>
                                    </span>
                                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                                </div>
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
                        <asp:Button ID="btnUpload" runat="server" Text="Upload Your CV" OnClick="Upload" CssClass="btn btn-primary btn-sm pull-right" Style="width: 190px; margin-right: 16px;" />
                    </div>
                </div>
            </div>
        </div>
    </div>



    <script type="text/javascript">
        $('#btnUpload').click(function () {
            var extension = $('#FileUpload1').val().split('.').pop().toLowerCase();

            if ($('#txtName').val().trim() !== '' && $('#txtPhoneNumber').val().trim() !== '' && $('#txtEmail').val().trim() !== '' && $('#FileUpload1').val() !== '') {
                if ($.inArray(extension, ['pdf']) == -1) {
                    //alert('Sorry, You can only upload an image.');
                    swal("Sorry!", "You can only upload a pdf file!", "error");
                    return false;
                }
                else {
                    alert('Thank you for Uploading your CV!');
                    //swal("Success!", "Thank you for Uploading your CV!", "Success");
                    return true;
                }
            }
            else {
                var str = '';
                if ($('#txtName').val().trim() === '') {
                    str += "Name is missing ** ";
                }
                if ($('#txtPhoneNumber').val().trim() === '') {
                    str += "Phone is missing ** ";
                }
                if ($('#txtEmail').val().trim() === '') {
                    str += "Email is missing ** ";
                }
                if ($('#FileUpload1').val() == '') {
                    str += "File is missing ** ";
                }
                $('#divErrorText').text(str);
                $('#divError').show('fade');
                return false;   // return false na dile hobe na. return false er jonno button ta kaj korbe na.
            }
        });
        $('#linkClose').click(function () {
            $('#divError').hide('fade');
            return false;   // return false na dile hobe na. return false er jonno crose button a click korle
            // popup modal chole jay na.
        });
    </script>
        
</asp:Content>