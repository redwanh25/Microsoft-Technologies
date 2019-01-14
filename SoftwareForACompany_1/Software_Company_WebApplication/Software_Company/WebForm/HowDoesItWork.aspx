<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="HowDoesItWork.aspx.cs" Inherits="Software_Company.WebForm.HowDoesItWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <style>
        #home {
            background: url(../Image/macbook-pro.jpg) no-repeat center fixed;
            display: table;
            height: 100%;
            width: 100%;
            position: relative;
            background-size: cover;
        }

        .landing-text {
            display: table-cell;
            /*text-align: center;*/
            vertical-align: middle;
        }
    </style>
    <br />
    <div class="container" align="center">
        <div class="tz-gallery">
            <div class="row">
                <a class="lightbox" href="../Image/computer.jpg">
                    <img src="../Image/computer.jpg" class="img-responsive" style="border-radius: 10px; max-height: 400px; max-width: 700px" />
                </a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <p style="font-family: Impact; font-size: 30px;">A Swedish IT company with global skills</p>
                <h4 style="line-height: 130%">We have created our own model for global IT deliveries, which we have developed and honed for over ten years. Our methodology for delivery and cooperation is based on SCRUM and our project tool of choice is Jira.
When you contact us at Indpro, we always begin by discussing your needs. This is what our process looks like, step by step:</h4>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div id="home">
        <div class="landing-text">
            <div class="container" align="center">
                <br />
                <br />
                <div class="row" style="color: orange">
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/Wordpress_Blue_logo.png" class="img-responsive" style="max-height: 150px; min-height: 100px" />
                        <h3>Wordpress</h3>
                    </div>
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/MicrosoftNet_Blue_logo.png" class="img-responsive" style="max-height: 150px; min-height: 120px" />
                        <h3>.Net</h3>
                    </div>
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/Drupal_Blue_logo.png" class="img-responsive" style="max-height: 130px; min-height: 100px" />
                        <h3>Drupal</h3>
                    </div>
                </div>
                <br />
                <div class="row" style="color: orange">
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/Bootstrap_Blue_logo.png" class="img-responsive" style="max-height: 150px; min-height: 100px" />
                        <h3>Bootstrap</h3>
                    </div>
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/Html_Blue_logo.png" class="img-responsive" style="max-height: 150px; min-height: 100px" />
                        <h3>Html</h3>
                    </div>
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/PHP_Blue_logo.png" class="img-responsive" style="max-height: 150px; min-height: 100px" />
                        <h3>Php</h3>
                    </div>
                </div>
                <%--<br />
                <span style="color: white">---------------------------<span style="font-size: 50px;">~~</span>---------------------------</span><br />
                <br />
                <div class="row">
                    <div class="col-sm-12" style="color: cornsilk">
                        <p style="font-family: Georgia; font-size: 30px; color: white"><b>This is how it works</b></p>
                    <h4 style="line-height: 130%">We have created our own model for global IT deliveries, which we have
                            developed and honed for over ten years. Our methodology for delivery and
                            cooperation is based on SCRUM and our project tool of choice is Jira.
                            When you contact us at Indpro, we always begin by discussing your needs.
                            This is what our process looks like, step by step:

                        </h4>
                    </div>
                </div>
                <br />
                <br />--%>
                <br />
            </div>
        </div>
    </div>

    <br />
    <br />
    <br />


    <div class="container">
        <div class="row text-center">
            <p style="font-family: Impact; font-size: 30px;"><b>This is how it works</b></p>
            <h4 style="line-height: 130%">We have created our own model for global IT deliveries, which we have
                            developed and honed for over ten years. Our methodology for delivery and
                            cooperation is based on SCRUM and our project tool of choice is Jira.
                            When you contact us at Indpro, we always begin by discussing your needs.
                            This is what our process looks like, step by step:

            </h4>
        </div>
        <br />
        <br />
        <div class="row text-center">
            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <img class="img-responsive" src="../Image/about02.png" />

                    <div class="caption">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                    </div>
                </div>
            </div>

            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <img class="img-responsive" src="../Image/about02.png" />

                    <div class="caption">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                    </div>
                </div>
            </div>

            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <img class="img-responsive" src="../Image/about02.png" />

                    <div class="caption">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                    </div>
                </div>
            </div>

            <div class="col-sm-6 col-md-3 col-lg-3">
                <div class="thumbnail shadow_B">
                    <img class="img-responsive" src="../Image/about02.png" />

                    <div class="caption">
                        <h3>Thumbnail label</h3>
                        <p>
                            Cras justo odio, dapibus ac facilisis in,
                            egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh
                            ultricies vehicula ut id elit.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <hr style="border: 5px solid; color: #F5F3F1">
    <br />
    <br />
    <div class="container">
        <div class="row" align="center">
            <a href="http://nomaa.se/WebForm/Help_With_A_Defined_Project.aspx" class="btn btn-default" style="font-family: Arial; font-size: 25px; color: orange; border-radius: 12px">Help with a defined project?</a>
            <br />
            <br />
            <h4 style="line-height: 130%">Feel free to get in touch before you’ve made up your mind on that. We’ll look over your needs together, and then we’ll propose a solution that’s adjusted to your individual needs: whether it’s a defined project, or a dedicated team working exclusively for you.</h4>
            <br />
            <h4 style="line-height: 130%">A defined project is often a good start. Partly because it allows us to get to know each other, but also because it becomes a test, allowing us both to validate that our partnership is running smoothly.</h4>
        </div>
    </div>

    <script type="text/javascript">
        baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>
