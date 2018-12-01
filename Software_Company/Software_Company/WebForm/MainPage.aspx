<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Software_Company.WebForm.MainPage" %>

<%--be carefull ClientIDMode="Static" aita na dile aishob page a jquery id selector kaj korbe na.
jegula page master page theke add content page create kora hoyese--%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server" ClientIDMode="Static">

    <style>
        .carousel-inner .item .well {
            /*padding: 10px;*/
            height: 220px;
            border-radius: 60px;
        }

    </style>

    <div class="container">
        <div class="row">
            <div align="center">

                <h1>Shrinking Bootstrap navbar</h1>
                <h1>Use this document as a way to quickly start any new project. 
                    All you get is this text and a mostly barebones HTML document.
                </h1>
                <h1>Shrinking Bootstrap navbar</h1>
                <h1>Use this document as a way to quickly start any new project. 
                 All you get is this text and a mostly barebones HTML document.
                </h1>
                <div class="jumbotron">
                    <p>
                        Use this document as a way to quickly start any new project. 
                All you get is this text and a mostly barebones HTML document. Cras mattis consectetur purus sit amet fermentum. 
                Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.
                Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor. Aenean lacinia bibendum nulla sed
                consectetur. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.
                    </p>
                </div>
                <div class="jumbotron">
                    <h3>Desert </h3>
                    <p>
                        From its formation, the ICC had Lord's Cricket Ground as its home, and from 1993 had its
                offices in the "Clock Tower" building at the nursery end of the ground. The independent 
                ICC was funded initially by commercial exploitation of the rights to the World Cup of One
                Day International cricket. As not all Member countries had double-tax agreements with the
                United Kingdom, it was necessary to protect cricket's revenues by creating a company, ICC
                Development (International) Pty Ltd – known as IDI, outside the UK. This was established 
                in January 1994 and was based in Monaco.
                    </p>
                </div>
                <div class="jumbotron">
                    <h3>JellyFish </h3>
                    <p>
                        From its formation, the ICC had Lord's Cricket Ground as its home, and from 1993 had its
                offices in the "Clock Tower" building at the nursery end of the ground. The independent 
                ICC was funded initially by commercial exploitation of the rights to the World Cup of One
                Day International cricket. As not all Member countries had double-tax agreements with the
                United Kingdom, it was necessary to protect cricket's revenues by creating a company, ICC
                Development (International) Pty Ltd – known as IDI, outside the UK. This was established 
                in January 1994 and was based in Monaco.
                    </p>
                </div>
                
            </div>
            <br />
            <div class="text-center">
                <div id="imageCarousel1" class="carousel slide" data-interval="false"
                    data-ride="carousel" data-pause="false" data-wrap="true">

                    <div class="carousel-inner" style="border-radius:5px" >
                        <div class="item active">
                            <div class="row">
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                            </i></h4>
                                        <h3>Fredrik Navjord</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                                <div class="hidden-lg hidden-sm hidden-md col-xs-12">
                                    <br />
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                            </i></h4>
                                        <h3>Fredrik Navjord</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="item">
                            <div class="row">
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                            </i></h4>
                                        <h3>Fredrik Navjord</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                                <div class="hidden-lg hidden-sm hidden-md col-xs-12">
                                    <br />
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                                    <div class="well" style="color: black">
                                        <h4><i>We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                                We had numerous reasons for wanting to set up a web shop,
                                                and Indpro immediately felt like the right provider for us.
                                            </i></h4>
                                        <h3>Fredrik Navjord</h3>
                                        <b style="color: orange">CEO, Metric Industrial AB</b>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <a href="#imageCarousel1" class="carousel-control left" style="height:220px; border-radius:5px" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left"></span>
                    </a>
                    <a href="#imageCarousel1" class="carousel-control right" style="height:220px; border-radius:5px" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right"></span>
                    </a>
                </div>
            </div>
            <br />
        </div>
    </div>

</asp:Content>
