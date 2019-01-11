<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="OurTeam.aspx.cs" Inherits="Software_Company.WebForm.OurTeam" %>

<%--be carefull ClientIDMode="Static" aita na dile aishob page a jquery id selector kaj korbe na.
jegula page master page theke add content page create kora hoyese--%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server" ClientIDMode="Static">
    <link href="../jquery_Bootstrap_SweetAlert_IHover/IHover/ihover.css" rel="stylesheet" />
<%--    <style>
        body {
            padding-top: 50px;
        }
    </style>--%>
    <div class="container">
        <div class="row">
            <div class="col-sm-4 col-md-4 col-lg-4">
                <div class="thumbnail">
                    <img class="img-responsive" src="../Image/redwan.jpg" style="border-radius: 5px" />

                    <div class="caption">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                        <p>
                            <a href="#" class="btn btn-primary" role="button">Button</a>
                            <a href="#" class="btn btn-default" role="button">Button</a>
                        </p>
                    </div>
                </div>
            </div>

            <div class="col-sm-4 col-md-4 col-lg-4">
                <div class="thumbnail">
                    <img class="img-responsive" src="../Image/redwan.jpg" style="border-radius: 5px" />

                    <div class="caption">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                        <p><a href="#" class="btn btn-primary" role="button">Button</a> <a href="#" class="btn btn-default" role="button">Button</a></p>
                    </div>
                </div>
            </div>

            <div class="col-sm-4 col-md-4 col-lg-4">
                <div class="thumbnail">
                    <img class="img-responsive" src="../Image/redwan.jpg" style="border-radius: 5px" />
                    <div class="caption">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                        <p><a href="#" class="btn btn-primary" role="button">Button</a> <a href="#" class="btn btn-default" role="button">Button</a></p>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <h2 class="text-center shadow_T"> <b>Our Employees</b></h2>
            <h4 class="page-description text-center shadow_T"><b>Our employees are our most valuable assets. Indpro has over 80 employees,
                            skilled in various technologies and platforms.</b></h4>
            <br />
            <div class="row">
                <div class="col-xs-12">
                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="ih-item circle effect3 left_to_right">
                            <a href="#">
                                <div class="img">
                                    <img src="../Image/RedwanPic.jpg" alt="img" />
                                </div>
                                <div class="info">
                                    <p style="font-size: 18px; padding-top: 40px">
                                        Redwan Hossain
                                    <br />
                                        Developer
                                    </p>
                                    <p>
                                        Education: DIU
                                    <br />
                                        Certification: B.Sc
                                    <br />
                                        Working Since: 2006
                                    <br />
                                        Experience: 19 years
                                    </p>

                                </div>
                            </a>
                        </div>
                        <br />
                    </div>

                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="ih-item circle effect3 left_to_right">
                            <a href="#">
                                <div class="img">
                                    <img src="../Image/RedwanPic.jpg" alt="img" />
                                </div>
                                <div class="info">
                                    <p style="font-size: 18px; padding-top: 40px">
                                        Redwan Hossain
                                    <br />
                                        Developer
                                    </p>
                                    <p>
                                        Education: DIU
                                    <br />
                                        Certification: B.Sc
                                    <br />
                                        Working Since: 2006
                                    <br />
                                        Experience: 19 years
                                    </p>

                                </div>
                            </a>
                        </div>
                        <br />
                    </div>

                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="ih-item circle effect3 left_to_right">
                            <a href="#">
                                <div class="img">
                                    <img src="../Image/RedwanPic.jpg" alt="img" />
                                </div>
                                <div class="info">
                                    <p style="font-size: 18px; padding-top: 40px">
                                        Redwan Hossain
                                    <br />
                                        Developer
                                    </p>
                                    <p>
                                        Education: DIU
                                    <br />
                                        Certification: B.Sc
                                    <br />
                                        Working Since: 2006
                                    <br />
                                        Experience: 19 years
                                    </p>

                                </div>
                            </a>
                        </div>
                        <br />
                    </div>

                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="ih-item circle effect3 left_to_right">
                            <a href="#">
                                <div class="img">
                                    <img src="../Image/RedwanPic.jpg" alt="img" />
                                </div>
                                <div class="info">
                                    <p style="font-size: 18px; padding-top: 40px">
                                        Redwan Hossain
                                    <br />
                                        Developer
                                    </p>
                                    <p>
                                        Education: DIU
                                    <br />
                                        Certification: B.Sc
                                    <br />
                                        Working Since: 2006
                                    <br />
                                        Experience: 19 years
                                    </p>

                                </div>
                            </a>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>
</asp:Content>
