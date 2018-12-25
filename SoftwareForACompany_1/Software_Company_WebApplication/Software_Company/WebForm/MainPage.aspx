<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Software_Company.WebForm.MainPage" %>

<%--be carefull ClientIDMode="Static" aita na dile aishob page a jquery id selector kaj korbe na.
jegula page master page theke add content page create kora hoyese--%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server" ClientIDMode="Static">

    <%--Tech news from the Company blog responsive--%>
    <script type="text/javascript">
        $(document).ready(function () {
            // create local storage or check if local storage if not null then remove already exist
            // Null checking you need to make because only ones you need to call it
            if (localStorage.getItem('windowSizeratio') != null) {
                localStorage.removeItem('windowSizeratio');
            } else {
                // Assign ratio value as per your resize window setting
                var value = "0";
                if ($(this).width() > 0 && $(this).width() <= 540) {
                    value = "540";
                }
                else if ($(this).width() > 540 && $(this).width() <= 980) {
                    value = "980";
                } else if ($(this).width() > 980) {
                    value = "981";
                }
                //Assign localstorage value
                localStorage.setItem('windowSizeratio', value);
            }
            // Call this function which will set hidden field value also it will call the button click event.
            resize($(this).width());
        });
        window.onresize = function (event) {
            // On resize window function will get call
            resize($(this).width());
        };
        function resize(width) {
            //Assign localstorage value to variable if it exist else it will undefined
            var ratio = localStorage.getItem('windowSizeratio');
            //Check the width also you need to check it’s not in same ratio which was it before
            //So it will not call repeatedly for many times as infinite by checking ratio value which assigned from local storage.
            //And assign hidden field value and call the buttonclick event from jquery fuction so it will set the RepeatColumns value.
            if (width > 0 && width <= 540 && ratio != "540" && $("[id*=hfColumnRepeat]").val() != "2") {
                $("[id*=hfColumnRepeat]").val(2);
                $("[id*=btnfake]").click();
            }
            if (width > 540 && width <= 768 && ratio != "768" && $("[id*=hfColumnRepeat]").val() != "2") {
                $("[id*=hfColumnRepeat]").val(2);
                $("[id*=btnfake]").click();
            }
            else if (width > 768 && width <= 980 && ratio != "980" && $("[id*=hfColumnRepeat]").val() != "2") {
                $("[id*=hfColumnRepeat]").val(2);
                $("[id*=btnfake]").click();
            }
            else if (width > 980 && ratio != "981" && $("[id*=hfColumnRepeat]").val() != "4") {
                $("[id*=hfColumnRepeat]").val(4);
                $("[id*=btnfake]").click();
            }
        }
    </script>

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
                transform: scale(1.3);
            }

        /*remove shadow from glyphicons in bootstrap carousel*/
        /*.titelButton .carousel-control.left, .titelButton .carousel-control.right {
            background-image: none !important;
            filter: none !important;
        }*/

        /*.thumbnail .caption .btn:hover {
            animation: bounce .8s;
        }*/

        .imgHover {
            transition: all 0.5s ease;
        }

            .imgHover:hover {
                background-color: #F5F3F1;
                transition: 0.3s;
                /*transform: scale(1.1);*/
            }

        .logoBounce:hover {
            animation: bounce .8s;
        }

        .space {
            word-spacing: 30px
        }

        .innerShadow {
            box-shadow: inset 0px 0px 20px 0px rgba(0,0,0,1);
        }

        .panel {
            border-radius: 20px;
        }

        #map {
            height: 450px;
            width: 100%;
        }
    </style>

    <%--popup video show style section--%>
    <style>
        #home {
            background: url(../Image/computer1.jpg) no-repeat center fixed;
            display: table;
            height: 100%;
            width: 100%;
            position: relative;
            background-size: cover;
        }

        .landing-text {
            display: table-cell;
            text-align: center;
            vertical-align: middle;
        }
    </style>

    <br />
    <br />

    <div class="container">
        <%--    <div class="row text-center">
        <div class="col-xs-5">
            <div class="row">
                <div class="col-xs-6 column">Column 1</div>
                <div class="col-xs-6 column">Column 2</div>
            </div>
        </div>
        <div class="col-xs-7">
            <div class="row">
                <div class="col-xs-4 column">Column 3</div>
                <div class="col-xs-4 column">Column 4</div>
                <div class="col-xs-4 column">Column 5</div>
            </div>
        </div>
    </div>--%>

        <div class="row text-center">
            <p style="font-size: 50px; font-family: Impact">Over 250 satisfied customers globally</p>
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage1">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite;" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage2">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage3">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage4">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage5">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage6">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
        </div>
        <div class="row">
            <div class="col-xs-4 col-sm-2 col-md-2 col-md-offset-1 col-sm-offset-1 companyInnerImage7">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage8">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 companyInnerImage9">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 hidden-xs companyInnerImage10">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 hidden-xs companyInnerImage11">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 col-xs-offset-2 hidden-lg hidden-md hidden-sm companyInnerImage12">
                <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" />
                <br />
            </div>
            <div class="col-xs-4 col-sm-2 col-md-2 hidden-lg hidden-md hidden-sm companyInnerImage13">
                <a href="#">
                    <img src="../Image/company_name.png" style="border: 6px solid; border-color: antiquewhite" class="img-responsive imgHover" /></a>
                <br />
            </div>
        </div>
    </div>

    <br />
    <br />
    <br />

    <div id="home">
        <div class="landing-text" style="height: 300px">
            <br />
            <div class="container" align="center">
                <a id="VideoPopUp" href="#" data-target="#VideoModal" data-toggle="modal">
                    <img src="../Image/playButtonFrame.png" style="height: 100px;" class="img-responsive"/></a>
                <h2 style="color: white">Watch video of how it works here</h2>
            </div>
        </div>
    </div>



    <br />
    <br />
    <%--<hr style="border: 5px solid; color: #F5F3F1">--%>
    <br />

    <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <h1 class="text-center" style="font-family: Impact; font-size: 40px">Indigenous IT consulting company with global deliveries</h1>
                <br />
                <br />
                <div style="border-radius: 10px">
                    <%--class="shadow_B" --%>
                    <div>
                        <%--class="pre-scrollable"  style="min-height: 400px"--%>
                        <ul class="nav nav-tabs h4">
                            <li class="active"><a href="#Customer" data-toggle="tab" style="color: orange">CUSTOMER ENGAGEMENT</a></li>
                            <li><a href="#CAPACITY" data-toggle="tab" style="color: orange">CAPACITY </a></li>
                            <li><a href="#QUALITY" data-toggle="tab" style="color: orange">QUALITY </a></li>
                            <li><a href="#COMPETENCE" data-toggle="tab" style="color: orange">COMPETENCE </a></li>
                        </ul>
                        <br />
                        <div class="tab-content text-center well">
                            <div id="Customer" class="tab-pane active">
                                <div class="animated zoomIn">
                                    <span style="font-family: Arial; color: darkslateblue;" class="h3">
                                        <b>Long-term cooperation <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>Good communication <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>responsiveness</b>
                                    </span>
                                    <br />
                                    <i style="font-family: serif" class="h3">
                                        Our customers often talk about our commitment. We do not work with IT, we work with people.
                                    <br />
                                        Our team of developers is working agile against customers according to
                                    <br />
                                        proven SCRUM methodology, and we know what is
                                    <br />
                                        needed for communication between customer and development team to work<br />
                                        seamlessly at a distance.
                                    </i>
                                </div>
                            </div>
                            <div id="CAPACITY" class="tab-pane">
                                <div class="animated zoomIn">
                                    <span style="font-family: Arial; color: darkslateblue;" class="h3">
                                        <b>Flexible resources <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>Flexible resources <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>Quick recruitment</b>
                                    </span>
                                    <br />
                                    <i style="font-family: serif;" class="h3">
                                        We work purposefully to attract the best skills. At Indpro you stay for a long time. No matter where 
                                    <br />
                                    Our team of developers is working agile against customers according to
                                    <br />
                                    and we listen to our employees' career development needs.
                                    <br />
                                    needed for communication between customer and development team to work<br />
                                    seamlessly at a distance.
                                    </i>
                                </div>
                            </div>
                            <div id="QUALITY" class="tab-pane">
                                <div class="animated zoomIn">
                                    <span style="font-family: Arial; color: darkslateblue;" class="h3">
                                        <b>Swedish project management <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>Proven processes <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>Good customer</b>
                                    </span>
                                    <br />
                                    <i style="font-family: serif" class="h3">
                                        We have nearly 100 employees, which enables us to quickly find the right developer to our .
                                    <br />
                                    Our team of developers is working agile against customers according to
                                    <br />
                                    proven SCRUM methodology, and we know what is
                                    <br />
                                    needed for communication between customer and development team to work<br />
                                    seamlessly at a distance.
                                    </i>
                                </div>
                            </div>
                            <div id="COMPETENCE" class="tab-pane">
                                <div class="animated zoomIn">
                                    <span style="font-family: Arial; color: darkslateblue;" class="h3">
                                        <b>lace Knowledge <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>Satisfied staff <span style="font-size: 1em; color: Tomato;">
                                            <i class="fas fa-igloo" style="padding:20px"></i>
                                        </span>Agile development</b>
                                    </span>
                                    <br />
                                    <i style="font-family: serif;" class="h3">
                                        such as communication problems and contextual misunderstandings. We work with mixed teams 
                                    <br />
                                    Our team of developers is working agile against customers according to
                                    <br />
                                    between customers and developers.
                                    <br />
                                    needed for communication between customer and development team to work<br />
                                    seamlessly at a distance.
                                    </i>
                                </div>
                            </div>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <br />
    <br />
    <br />
    <hr style="border: 5px solid; color: #F5F3F1">
    <br />
    <br />

    <div class="container">
        <div class="row text-center">
            <h1 style="font-family: Impact; font-size: 50px">How does it work?</h1>
            <br />
            <div class="col-md-2 col-sm-4 col-xs-4 im1" style="color: orange">
                <img class="logoBounce" style="height: 100px; width: 100px" src="../Image/icons8-comments-64.png" />
                <h4><b>Requirement analysis</b></h4>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-4 im1" style="color: orange">
                <img class="logoBounce" style="height: 100px; width: 100px" src="../Image/icons8-idea-64.png" />
                <h4><b>Proposed solution</b></h4>
            </div>        
            <div class="col-md-2 col-sm-4 col-xs-4 im2" style="color: orange">
                <img class="logoBounce" style="height: 100px; width: 100px" src="../Image/icons8-increase-64.png" />
                <h4><b>improvements</b></h4>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-4 im2" style="color: orange">
                <img class="logoBounce" style="height: 100px; width: 100px" src="../Image/icons8-laptop-64.png" />
                <h4><b>Need analysis</b></h4>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-4 im2" style="color: orange">
                <img class="logoBounce" style="height: 100px; width: 100px" src="../Image/icons8-windows-client-64.png" />
                <h4><b>Start of project</b></h4>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-4 im1" style="color: orange">
                <img class="logoBounce" style="height: 100px; width: 100px" src="../Image/icons8-in-transit-64.png" />
                <h4><b>Development and delivery</b></h4>
            </div>
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-md-4 col-md-offset-4 col-sm-6 col-sm-offset-3">
                <a href="HowDoesItWork.aspx" id="btn-read" class="btn btn-block btn-default shadow_B" style="border-radius: 20px; font-size: 17px">READ MORE ABOUT THIS</a>
            </div>
        </div>
    </div>

    <br />
    <br />
    <br />
    <br />
    <br />

    <%--google map--%>
    <div id="map"></div>

    <br />
    <br />
    <br />
    <br />

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
            <div class="text-center">
                <p style="font-family: Impact; font-size: 50px;">Tech news from the Company blog</p>
            </div>
        </div>
        <br />
        <br />
        <%--<div class="row">
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
        </div>--%>

        <%-- Fake button just for call onClick of button event using jquery function--%>
        <asp:Button ID="btnfake" runat="server" OnClick="OnClick" Style="display: none" />
        <%-- Hidden filed to set the ratio value--%>
        <asp:HiddenField ID="hfColumnRepeat" runat="server" Value="4" />

        <div class="row">
            <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
                <ItemTemplate>
                    <div class="col-sm-12 col-md-12 col-lg-12">
                        <div class="thumbnail shadow_B">
                            <%--style="max-width: 500px"--%>
                            <div class="inner" align="center">
                                <%#GetImage1(Container.DataItem)%>
                            </div>
                            <br />
                            <div class="caption text-center">
                                <p>
                                    <asp:Label Style="font-size: 18px" ID="Label1" Text='<%#GetTitle1(Container.DataItem)%>' runat="server"></asp:Label>
                                </p>
                                <br />
                                <p>
                                    <asp:Label ForeColor="Red" CssClass="h5" ID="TextBox1" Text='<%# Eval("Date") %>' runat="server"></asp:Label>
                                </p>
                                <br />
                                <%#GetButton1(Container.DataItem)%>
                                <%--<a href="#" class="btn btn-default btn-block" style="border-radius: 20px; outline: none; color: orange; font-size: 15px">Get More Info</a>--%>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>

    <div class="modal fade" id="VideoModal" tabindex="-1" data-keyboard="false">
        <div class="modal-dialog modal-lg">
            <div class="modal-content" style="background-color: darkgray">
                <div class="modal-header">
                    <button class="close" data-dismiss="modal" style="color:black; font-size:40px">&times;</button>
                    <h4 class="modal-title h3 text-center" style="font-size: 30px"><b>Watch video of how it works here</b></h4>
                </div>
                <div class="modal-body col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <br />
                    <div class="col-sm-6">
                        <%--onek video iframe a support kore na embed a kore. but, embed a full screen hoy na. iframe a hoy--%>
                        <%--embed use korle youtube er video link like https://www.youtube.com/watch?v=aPw1M_Ehg94 ai ta er "watch?" tuku and "=" er poriborte "/" hobe --%>
                        <%--<embed width="300" height="180" src="https://www.youtube.com/v/aPw1M_Ehg94"/>--%>
                        <div class="embed-responsive embed-responsive-16by9" style="border-radius: 10px">
                            <iframe class="embed-responsive-item" src="https://www.youtube.com/embed/748BFvqYHG8" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        </div>
                        <br />
                    </div>
                    <div class="col-sm-6">
                        <div class="embed-responsive embed-responsive-16by9" style="border-radius: 10px">
                            <iframe class="embed-responsive-item" src="https://www.youtube.com/embed/nD7uDivzMiA" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <%--<asp:Button ID="btnHideVideoModal" runat="server" Text="Close" class="btn btn-primary btn-sm" data-dismiss="modal" />--%>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            //var el = document.getElementById('toggleButton');
            // space deoyar jonno \xa0 aita use korte hoy
            //el.value = "Watch video of how it works here" + "\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0||\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0\xa0" + "Watch video of how it works here";
            //el.innerHTML = "Watch video of how it works here" + "\xa0\xa0\xa0\xa0\xa0\xa0\xa0||\xa0\xa0\xa0\xa0\xa0\xa0\xa0" + "Watch video of how it works here";
            $('#toggleButton').click(function () {
                $('#video').collapse('toggle');
            });

        });
    </script>

    <%--Animate a div when we scroll to its position--%>
    <%--<script type="text/javascript">
        $(document).ready(function () {
            $(window).scroll(function () {
                var positionTop = $(document).scrollTop();
                console.log(positionTop);
                if ((positionTop > 1000) && (positionTop < 1900)) {
                    $('.im1').addClass('animated fadeInLeft');
                    $('.im2').addClass('animated fadeInRight');
                }
                else {
                    $('.im1').removeClass('animated fadeInLeft');
                    $('.im2').removeClass('animated fadeInRight');
                }
            });
        });
    </script>--%>


    <script type="text/javascript">
        $('.companyInnerImage1').mouseover(function () {
            $('.companyInnerImage1 img').addClass('animated flipInY');
        });
        $('.companyInnerImage1').mouseout(function () {
            $('.companyInnerImage1 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage2').mouseover(function () {
            $('.companyInnerImage2 img').addClass('animated flipInY');
        });
        $('.companyInnerImage2').mouseout(function () {
            $('.companyInnerImage2 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage3').mouseover(function () {
            $('.companyInnerImage3 img').addClass('animated flipInY');
        });
        $('.companyInnerImage3').mouseout(function () {
            $('.companyInnerImage3 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage4').mouseover(function () {
            $('.companyInnerImage4 img').addClass('animated flipInY');
        });
        $('.companyInnerImage4').mouseout(function () {
            $('.companyInnerImage4 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage5').mouseover(function () {
            $('.companyInnerImage5 img').addClass('animated flipInY');
        });
        $('.companyInnerImage5').mouseout(function () {
            $('.companyInnerImage5 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage6').mouseover(function () {
            $('.companyInnerImage6 img').addClass('animated flipInY');
        });
        $('.companyInnerImage6').mouseout(function () {
            $('.companyInnerImage6 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage7').mouseover(function () {
            $('.companyInnerImage7 img').addClass('animated flipInY');
        });
        $('.companyInnerImage7').mouseout(function () {
            $('.companyInnerImage7 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage8').mouseover(function () {
            $('.companyInnerImage8 img').addClass('animated flipInY');
        });
        $('.companyInnerImage8').mouseout(function () {
            $('.companyInnerImage8 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage9').mouseover(function () {
            $('.companyInnerImage9 img').addClass('animated flipInY');
        });
        $('.companyInnerImage9').mouseout(function () {
            $('.companyInnerImage9 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage10').mouseover(function () {
            $('.companyInnerImage10 img').addClass('animated flipInY');
        });
        $('.companyInnerImage10').mouseout(function () {
            $('.companyInnerImage10 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage11').mouseover(function () {
            $('.companyInnerImage11 img').addClass('animated flipInY');
        });
        $('.companyInnerImage11').mouseout(function () {
            $('.companyInnerImage11 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage12').mouseover(function () {
            $('.companyInnerImage12 img').addClass('animated flipInY');
        });
        $('.companyInnerImage12').mouseout(function () {
            $('.companyInnerImage12 img').removeClass('animated flipInY');
        });

        $('.companyInnerImage13').mouseover(function () {
            $('.companyInnerImage13 img').addClass('animated flipInY');
        });
        $('.companyInnerImage13').mouseout(function () {
            $('.companyInnerImage13 img').removeClass('animated flipInY');
        });

    </script>

    <script>
        var map;
        function initMap() {
            // The location of Uluru
            var Dhaka = { lat: 23.810331, lng: 90.412521 };
            var Talwan = { lat: 25.038410, lng: 121.563700 };
            var India = { lat: 20.593683, lng: 78.962883 };
            var Karachi = { lat: 24.860735, lng: 67.001137 };
            var Sweden = { lat: 60.128162, lng: 18.643501 };

            var map = new google.maps.Map(document.getElementById('map'), {
                zoom: 5,
                center: Dhaka
            });

            var markerDhaka = new google.maps.Marker({
                position: Dhaka,
                map: map
            });
            var markerTalwan = new google.maps.Marker({
                position: Talwan,
                map: map
            });
            var markerIndia = new google.maps.Marker({
                position: India,
                map: map
            });
            var markerKarachi = new google.maps.Marker({
                position: Karachi,
                map: map
            });
            var contentStringDhaka = '<div id="content" style="height:110px; width:200px;">' +
                '<div id="siteNotice">' +
                '</div>' +
                '<div id="bodyContent">' +
                '<h4>Address:</h4>' +
                '<p>Abcdefghijklmn 00, Abcde ABC</p>' +
                '<p>123 34 Dhaka</p>' +
                '<p>Bangladesh</p>' +
                '</div>' +
                '</div>';

            var infowindowDhaka = new google.maps.InfoWindow({
                content: contentStringDhaka
            });

            markerDhaka.addListener('click', function () {
                infowindowDhaka.open(map, markerDhaka);
            });

            var contentStringTalwan = '<div id="content" style="height:110px; width:200px;">' +
                '<div id="siteNotice">' +
                '</div>' +
                '<div id="bodyContent">' +
                '<h4>Address:</h4>' +
                '<p>Abcdefghijklmn 00, Abcde ABC</p>' +
                '<p>123 34 Talwan</p>' +
                '<p>Talwan</p>' +
                '</div>' +
                '</div>';

            var infowindowTalwan = new google.maps.InfoWindow({
                content: contentStringTalwan
            });

            markerTalwan.addListener('click', function () {
                infowindowTalwan.open(map, markerTalwan);
            });

            var contentStringIndia = '<div id="content" style="height:110px; width:200px;">' +
                '<div id="siteNotice">' +
                '</div>' +
                '<div id="bodyContent">' +
                '<h4>Address:</h4>' +
                '<p>Abcdefghijklmn 00, Abcde ABC</p>' +
                '<p>123 34 Mumbai</p>' +
                '<p>India</p>' +
                '</div>' +
                '</div>';

            var infowindowIndia = new google.maps.InfoWindow({
                content: contentStringIndia
            });

            markerIndia.addListener('click', function () {
                infowindowIndia.open(map, markerIndia);
            });

            var contentStringKarachi = '<div id="content" style="height:110px; width:200px;">' +
                '<div id="siteNotice">' +
                '</div>' +
                '<div id="bodyContent">' +
                '<h4>Address:</h4>' +
                '<p>Abcdefghijklmn 00, Abcde ABC</p>' +
                '<p>123 34 Karachi</p>' +
                '<p>Pakistan</p>' +
                '</div>' +
                '</div>';

            var infowindowKarachi = new google.maps.InfoWindow({
                content: contentStringKarachi
            });

            markerKarachi.addListener('click', function () {
                infowindowKarachi.open(map, markerKarachi);
            });
        }
    </script>

    <script async defer src="https://maps.googleapis.com/maps/api/js?key=&callback=initMap" type="text/javascript"></script>

</asp:Content>
