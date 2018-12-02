<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Software_Company.WebForm.MainPage" %>

<%--be carefull ClientIDMode="Static" aita na dile aishob page a jquery id selector kaj korbe na.
jegula page master page theke add content page create kora hoyese--%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server" ClientIDMode="Static">

    <style>
        #imageCarousel1 .carousel-inner .item .well {
            /*padding: 10px;*/
            height: 220px;
            border-radius: 60px;
        }
        #imageCarousel2 .carousel-inner .item .well {
            /*padding: 10px;*/
            height: 250px;
            border-radius: 60px;
        }

        .inner {
            overflow: hidden;
        }

        .inner img {
            transition: all 1.0s ease;
        }

        .inner:hover img {
            transform: scale(1.5);
        }

        /*remove shadow from glyphicons in bootstrap carousel*/
        /*.titelButton .carousel-control.left, .titelButton .carousel-control.right {
            background-image: none !important;
            filter: none !important;
        }*/
    </style>

    <div class="container">
        <div class="row">
            <br />
            <div class="text-center">
                <div id="imageCarousel2" class="carousel slide" data-interval="false"
                    data-ride="carousel" data-pause="false" data-wrap="true">

                    <div class="carousel-inner hidden-lg hidden-md" style="border-radius: 5px">
                        <div class="item active">
                            <div class="well" style="color: black">
                                <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                </i></h4>
                                <h3>Redwan Hossain</h3>
                                <b style="color: orange">CEO, Metric Industrial AB</b>
                            </div>
                        </div>
                        <div class="item">
                            <div class="well" style="color: black">
                                <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                </i></h4>
                                <h3>Ramijul Islam</h3>
                                <b style="color: orange">CEO, Metric Industrial AB</b>
                            </div>
                        </div>
                        <div class="item">
                            <div class="well" style="color: black">
                                <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                </i></h4>
                                <h3>Shihab Sharar</h3>
                                <b style="color: orange">CEO, Metric Industrial AB</b>
                            </div>
                        </div>
                        <div class="item">
                            <div class="well" style="color: black">
                                <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                </i></h4>
                                <h3>Mohoshin Khan</h3>
                                <b style="color: orange">CEO, Metric Industrial AB</b>
                            </div>
                        </div>
                    </div>
                    <div class="titelButton">
                        <a href="#imageCarousel2" class="carousel-control left hidden-lg hidden-md" style="height: 250px; border-radius: 5px" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </a>
                        <a href="#imageCarousel2" class="carousel-control right hidden-lg hidden-md" style="height: 250px; border-radius: 5px" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right"></span>
                        </a>
                    </div>
                </div>

                <div id="imageCarousel1" class="carousel slide" data-interval="false"
                    data-ride="carousel" data-pause="false" data-wrap="true">
                    <div class="carousel-inner hidden-sm hidden-xs" style="border-radius: 5px">
                        <div class="item active">
                            <div class="row">
                                <div class="col-lg-6 col-md-6">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                        </i></h4>
                                        <h3>Redwan Hossain</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                                <div class="hidden-lg hidden-sm hidden-md col-xs-12">
                                    <br />
                                </div>
                                <div class="col-lg-6 col-md-6">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                        </i></h4>
                                        <h3>Ramijul Islam</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="item">
                            <div class="row">
                                <div class="col-lg-6 col-md-6">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                        </i></h4>
                                        <h3>Shihab Sharar Khan</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                                <div class="hidden-lg hidden-sm hidden-md col-xs-12">
                                    <br />
                                </div>
                                <div class="col-lg-6 col-md-6">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                        </i></h4>
                                        <h3>Mohoshin Khan</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="titelButton">
                        <a href="#imageCarousel1" class="carousel-control left hidden-sm hidden-xs" style="height: 220px; border-radius: 5px" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </a>
                        <a href="#imageCarousel1" class="carousel-control right hidden-sm hidden-xs" style="height: 220px; border-radius: 5px" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right"></span>
                        </a>
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>
    <hr style="border: 5px solid; color: #F5F3F1">
    <div class="container">
        <div class="row">
            <div class="text-center shadow_T">
                <h1>Tech news from the Company blog</h1>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <div class="inner">
                        <img src="../Image/benches.jpg" class="img-responsive" />
                    </div>

                    <div class="caption text-center">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                        <a href="#" class="btn btn-default btn-block" style="border-radius: 20px; outline: none; color: olivedrab; font-size: 16px" role="button">Get More Info</a>
                    </div>
                </div>
            </div>

            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <div class="inner">
                        <img src="../Image/bridge.jpg" class="img-responsive" />
                    </div>

                    <div class="caption text-center">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                        <a href="#" class="btn btn-default btn-block" style="border-radius: 20px; outline: none; color: olivedrab; font-size: 16px" role="button">Get More Info</a>
                    </div>
                </div>
            </div>

            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <div class="inner">
                        <img src="../Image/coast.jpg" class="img-responsive" />
                    </div>
                    <div class="caption text-center">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                        <a href="#" class="btn btn-default btn-block" style="border-radius: 20px; outline: none; color: olivedrab; font-size: 16px" role="button">Get More Info</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <div class="inner">
                        <img src="../Image/park.jpg" class="img-responsive" />
                    </div>
                    <div class="caption text-center">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                        <a href="#" class="btn btn-default btn-block" style="border-radius: 20px; outline: none; color: olivedrab; font-size: 16px" role="button">Get More Info</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
