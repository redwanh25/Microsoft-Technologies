<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Software_Company.WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://cdn.jsdelivr.net/particles.js/2.0.0/particles.min.js"></script>
    <script src="../jquery_Bootstrap_SweetAlert_IHover/jQuery/compressed/jquery-3.3.1.min.js"></script>
    <script src="../jquery_Bootstrap_SweetAlert_IHover/Bootstrap/js/bootstrap.min.js"></script>
    <link href="../jquery_Bootstrap_SweetAlert_IHover/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../jquery_Bootstrap_SweetAlert_IHover/SweetAlert/sweetalert.min.js"></script>
    <link href="../jquery_Bootstrap_SweetAlert_IHover/Bootstrap/css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="../jquery_Bootstrap_SweetAlert_IHover/Animate.css" rel="stylesheet" />
    <style>
        /* ---- reset ---- */ body {
            margin: 0;
            /*font: normal 75% Arial, Helvetica, sans-serif;*/
        }

        canvas {
            display: block;
            vertical-align: bottom;
        }
        /* ---- particles.js container ---- */

        #particles-js {
            position: absolute;
            width: 100%;
            height: 100%;
            background-color: #b61924;
            background-image: url("");
            background-repeat: no-repeat;
            background-size: cover;
            background-position: 50% 50%;
        }
        /* ---- stats.js ---- */

        .count-particles {
            background: #000022;
            position: absolute;
            top: 48px;
            left: 0;
            width: 80px;
            color: #13E8E9;
            font-size: .8em;
            text-align: left;
            text-indent: 4px;
            line-height: 14px;
            padding-bottom: 2px;
            font-family: Helvetica, Arial, sans-serif;
            font-weight: bold;
        }

        .js-count-particles {
            font-size: 1.1em;
        }

        #stats, .count-particles {
            -webkit-user-select: none;
            margin-top: 5px;
            margin-left: 5px;
        }

        #stats {
            border-radius: 3px 3px 0 0;
            overflow: hidden;
        }

        .count-particles {
            border-radius: 0 0 3px 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="particles-js">
                <div style="position: absolute; left:200px">
                    <div >
                        <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <h1 class="text-center shadow_T">Indigenous IT consulting company with global deliveries</h1>
                <br />
                <br />
                <div class="shadow_B" style="border-radius: 10px">
                    <div class="pre-scrollable" style="min-height: 400px">
                        <ul class="nav nav-tabs h4">
                            <li class="active"><a href="#Customer" data-toggle="tab" style="color: orange">CUSTOMER ENGAGEMENT</a></li>
                            <li><a href="#CAPACITY" data-toggle="tab" style="color: orange">CAPACITY </a></li>
                            <li><a href="#QUALITY" data-toggle="tab" style="color: orange">QUALITY </a></li>
                            <li><a href="#COMPETENCE" data-toggle="tab" style="color: orange">COMPETENCE </a></li>
                        </ul>
                        <br />
                        <div class="tab-content text-center">
                            <div id="Customer" class="tab-pane active">
                                <h3 class="animated bounceIn"><span style="font-family: Calibri" class="h3"><b>Long-term cooperation || Good communication || responsiveness</b></span>
                                    <br />
                                    <br />
                                    Our customers often talk about our commitment. We do not work with IT, we work with people.
                                    <br />
                                    Our team of developers is working agile against customers according to
                                    <br />
                                    proven SCRUM methodology, and we know what is
                                    <br />
                                    needed for communication between customer and development team to work<br />
                                    seamlessly at a distance.
                                </h3>
                            </div>
                            <div id="CAPACITY" class="tab-pane">
                                <h3 class="animated bounceIn"><span style="font-family: Calibri" class="h3"><b>Flexible resources || Flexible resources || Quick recruitment</b></span>
                                    <br />
                                    <br />
                                    We work purposefully to attract the best skills. At Indpro you stay for a long time. No matter where 
                                    <br />
                                    Our team of developers is working agile against customers according to
                                    <br />
                                    and we listen to our employees' career development needs.
                                    <br />
                                    needed for communication between customer and development team to work<br />
                                    seamlessly at a distance.
                                </h3>
                            </div>
                            <div id="QUALITY" class="tab-pane">
                                <h3 class="animated bounceIn"><span style="font-family: Calibri" class="h3"><b>Swedish project management  || Proven processes || Good customer </b></span>
                                    <br />
                                    <br />
                                    We have nearly 100 employees, which enables us to quickly find the right developer to our .
                                    <br />
                                    Our team of developers is working agile against customers according to
                                    <br />
                                    proven SCRUM methodology, and we know what is
                                    <br />
                                    needed for communication between customer and development team to work<br />
                                    seamlessly at a distance.
                                </h3>
                            </div>
                            <div id="COMPETENCE" class="tab-pane">
                                <h3 class="animated bounceIn"><span style="font-family: Calibri" class="h3"><b>lace Knowledge || Satisfied staff || Agile development</b></span>
                                    <br />
                                    <br />
                                    such as communication problems and contextual misunderstandings. We work with mixed teams 
                                    <br />
                                    Our team of developers is working agile against customers according to
                                    <br />
                                    between customers and developers.
                                    <br />
                                    needed for communication between customer and development team to work<br />
                                    seamlessly at a distance.
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
                    </div>
                    
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
                </div>
            </div>
        </div>
    </form>
</body>
</html>

<script type="text/javascript">
    particlesJS("particles-js", {
        particles: {
            number: { value: 180, density: { enable: true, value_area: 800 } },
            color: { value: "#363636" },
            shape: {
                type: "circle",
                stroke: { width: 0, color: "#000000" },
                polygon: { nb_sides: 5 },
                image: { src: "img/github.svg", width: 100, height: 100 }
            },
            opacity: {
                value: 0.5,
                random: false,
                anim: { enable: false, speed: 1, opacity_min: 0.1, sync: false }
            },
            size: {
                value: 3,
                random: true,
                anim: { enable: false, speed: 40, size_min: 0.1, sync: false }
            },
            line_linked: {
                enable: true,
                distance: 150,
                color: "#363636",
                opacity: 0.4,
                width: 1
            },
            move: {
                enable: true,
                speed: 6,
                direction: "none",
                random: false,
                straight: false,
                out_mode: "out",
                bounce: false,
                attract: { enable: false, rotateX: 600, rotateY: 1200 }
            }
        },
        interactivity: {
            detect_on: "canvas",
            events: {
                onhover: { enable: true, mode: "repulse" },
                onclick: { enable: true, mode: "push" },
                resize: true
            },
            modes: {
                grab: { distance: 400, line_linked: { opacity: 1 } },
                bubble: { distance: 400, size: 40, duration: 2, opacity: 8, speed: 3 },
                repulse: { distance: 200, duration: 0.4 },
                push: { particles_nb: 4 },
                remove: { particles_nb: 2 }
            }
        },
        retina_detect: true
    });
    var count_particles, stats, update;
    stats = new Stats();
    stats.setMode(0);
    stats.domElement.style.position = "absolute";
    stats.domElement.style.left = "0px";
    stats.domElement.style.top = "0px";
    document.body.appendChild(stats.domElement);
    count_particles = document.querySelector(".js-count-particles");
    update = function () {
        stats.begin();
        stats.end();
        if (window.pJSDom[0].pJS.particles && window.pJSDom[0].pJS.particles.array) {
            count_particles.innerText = window.pJSDom[0].pJS.particles.array.length;
        }
        requestAnimationFrame(update);
    };
    requestAnimationFrame(update);

</script>
