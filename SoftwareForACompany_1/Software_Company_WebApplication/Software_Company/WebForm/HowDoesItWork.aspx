<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="HowDoesItWork.aspx.cs" Inherits="Software_Company.WebForm.HowDoesItWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>

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
    <br />
    <div class="container" align="center">
        <div class="tz-gallery">
            <div class="row">
                <a class="lightbox" href="../Image/computer.jpg">
                    <img src="../Image/computer.jpg" class="img-responsive" style="border-radius: 10px" />
                </a>
            </div>
        </div>

        <br />
        <br />
        <div class="row">
            <div class="col-sm-12">
                <p style="font-family: Impact; font-size: 45px;">A Swedish IT company with global skills</p>

                <h3>We have created our own model for global IT deliveries, which we have developed and honed for over ten years. Our methodology for delivery and cooperation is based on SCRUM and our project tool of choice is Jira.
When you contact us at Indpro, we always begin by discussing your needs. This is what our process looks like, step by step:</h3>
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
                        <img src="../Image/about01.png" class="img-responsive" />
                        <h3>Write Something here</h3>
                    </div>
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/about02.png" class="img-responsive" />
                        <h3>Write Something</h3>
                    </div>
                    <div class=" col-xs-4 col-sm-4 col-md-4">
                        <img src="../Image/about03.png" class="img-responsive" />
                        <h3>Write Something here</h3>
                    </div>
                </div>
                <br />
                <span style="color: white">---------------------------<span style="font-size: 50px;">~~</span>---------------------------</span><br />
                <br />
                <div class="row">
                    <div class="col-sm-12" style="color: cornsilk">
                        <p style="font-family: Georgia; font-size: 50px; color: white"><b>This is how it works</b></p>

                        <h3>We have created our own model for global IT deliveries, which we have
                            developed and honed for over ten years. Our methodology for delivery and
                            cooperation is based on SCRUM and our project tool of choice is Jira.
                            When you contact us at Indpro, we always begin by discussing your needs.
                            This is what our process looks like, step by step:

                        </h3>
                    </div>
                </div>
                <br />
                <br />
            </div>
        </div>
    </div>

    <br />
    <br />
    <br />
    <br />

    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-10 col-md-10 col-lg-10 col-lg-offset-1">
                <div class="row">
                    <div class="col-xs-4 col-sm-3 col-md-2 col-lg-2">
                        <img src="../Image/icons8-comments-64.png" style="height: 100px; width: 100px" class="img-responsive" />
                    </div>
                    <div class="col-xs-8 col-sm-9 col-md-10 col-lg-10">
                        <h3 style="font-family: Impact">1. Requirement analysis</h3>
                        <h4>What do you need help with? And how can we set it up for you?
                        To answer these questions we start off with a meeting, where we get
                        a feel for each other. Then we conduct a workshop where we explore your
                        needs and discuss solutions.</h4>
                    </div>
                </div>

                <hr style="border: 2px solid; color: #F5F3F1">

                <div class="row">
                    <div class="col-xs-4 col-sm-3 col-md-2 col-lg-2">
                        <img src="../Image/icons8-idea-64.png" style="height: 100px; width: 100px" class="img-responsive" />
                    </div>
                    <div class="col-xs-8 col-sm-9 col-md-10 col-lg-10">
                        <h3 style="font-family: Impact">2. Proposed solution</h3>
                        <h4>After our workshop we propose a solution. The proposal includes 
                            suggestions for structure, skills, process, scope and technology.
                            Sometimes we also include a wireframe design. We discuss and adjust
                            the proposal together.</h4>
                    </div>
                </div>

                <hr style="border: 2px solid; color: #F5F3F1">

                <div class="row">
                    <div class="col-xs-4 col-sm-3 col-md-2 col-lg-2">
                        <img src="../Image/icons8-increase-64.png" style="height: 100px; width: 100px" class="img-responsive" />
                    </div>
                    <div class="col-xs-8 col-sm-9 col-md-10 col-lg-10">
                        <h3 style="font-family: Impact">3. Start of project</h3>
                        <h4>When we agree on what is to be done, we at Indpro prepare the tools required, and plan the project. We prefer to work in Jira, and when we do we prepare it completely and all you need to do is join the project. If we help you build a dedicated team, we also recruit in this phase.</h4>
                    </div>
                </div>

                <hr style="border: 2px solid; color: #F5F3F1">

                <div class="row">
                    <div class="col-xs-4 col-sm-3 col-md-2 col-lg-2">
                        <img src="../Image/icons8-laptop-64.png" style="height: 100px; width: 100px" class="img-responsive" />
                    </div>
                    <div class="col-xs-8 col-sm-9 col-md-10 col-lg-10">
                        <h3 style="font-family: Impact">4. Requirement analysis</h3>
                        <h4>What do you need help with? And how can we set it up for you?
                        To answer these questions we start off with a meeting, where we get
                        a feel for each other. Then we conduct a workshop where we explore your
                        needs and discuss solutions.</h4>
                    </div>
                </div>

                <hr style="border: 2px solid; color: #F5F3F1">

                <div class="row">
                    <div class="col-xs-4 col-sm-3 col-md-2 col-lg-2">
                        <img src="../Image/icons8-windows-client-64.png" style="height: 100px; width: 100px" class="img-responsive" />
                    </div>
                    <div class="col-xs-8 col-sm-9 col-md-10 col-lg-10">
                        <h3 style="font-family: Impact">5. Follow up and improvements</h3>
                        <h4>Since work with SCRUM methodology, we continuously evaluate and 
                            improve our work. After each iteration we review what we did well, 
                            what we did not do as well, and what we should start doing.</h4>
                    </div>
                </div>

                <hr style="border: 2px solid; color: #F5F3F1">

                <div class="row">
                    <div class="col-xs-4 col-sm-3 col-md-2 col-lg-2">
                        <img src="../Image/icons8-in-transit-64.png" style="height: 100px; width: 100px" class="img-responsive" />
                    </div>
                    <div class="col-xs-8 col-sm-9 col-md-10 col-lg-10">
                        <h3 style="font-family: Impact">6. Development and delivery</h3>
                        <h4>We practice agile development, and use Indpro’s own cooperation model.
                            Our model includes development of code, testing of code, code review,
                            commit, deliveries and demo. If you prefer we will incorporate ourselves
                            into you process. Otherwise we work fully based on Indpro’s process.</h4>
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
            <p style="font-family: Arial; font-size: 45px; color: orange"><b>Help with a defined project?</b></p>
            <h3>Feel free to get in touch before you’ve made up your mind on that. We’ll look over your needs together, and then we’ll propose a solution that’s adjusted to your individual needs: whether it’s a defined project, or a dedicated team working exclusively for you.</h3>
            <br />
            <h3>A defined project is often a good start. Partly because it allows us to get to know each other, but also because it becomes a test, allowing us both to validate that our partnership is running smoothly.</h3>
        </div>
    </div>

    <script type="text/javascript">
        baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>
