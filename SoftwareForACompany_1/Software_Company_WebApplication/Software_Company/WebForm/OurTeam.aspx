<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="OurTeam.aspx.cs" Inherits="Software_Company.WebForm.OurTeam" %>

<%--be carefull ClientIDMode="Static" aita na dile aishob page a jquery id selector kaj korbe na.
jegula page master page theke add content page create kora hoyese--%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server" ClientIDMode="Static">
    <link href="../jquery_Bootstrap_SweetAlert_IHover/IHover/ihover.css" rel="stylesheet" />
    <link href="../jquery_Bootstrap_SweetAlert_IHover/GalleryGrid/gallery-grid.css" rel="stylesheet" />
    <style>
        body{
            padding-top:50px;
        }
    </style>
    <div class="container">
        <div class="container gallery-container">
            <br />
            <div class="row">
                <div class="col-xs-12">
                    <img class="img-responsive shadow_B" src="../Image/redwan.jpg" style="border-radius:15px"/>
                    <br />
                    <div class="well" id="abc">
                        <h1 style="font-family:Impact; font-size:40px;">Global skills with local touch</h1>
                        <h3>Our employees are our most valuable assets. Indpro has over 80 employees,
                            skilled in various technologies and platforms. Our employees are our most
                            valuable assets. Indpro has over 80 employees,skilled in various technologies
                            and platforms.Our employees are our most valuable assets. Indpro has over 80
                            employees, skilled in various technologies and platforms.
                        </h3>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="container gallery-container">
            <h1 class="text-center shadow_T">Our Employees</h1>
            <h3 class="page-description text-center shadow_T">Our employees are our most valuable assets. Indpro has over 80 employees,
                            skilled in various technologies and platforms.</h3>
            <br />
            <div class="row">
                <div class="col-xs-12">
                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                        <div class="ih-item circle effect3 left_to_right shadow_B">
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
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>
</asp:Content>
