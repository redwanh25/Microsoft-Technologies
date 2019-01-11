<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="Web_Development.aspx.cs" Inherits="Software_Company.WebForm.Web_Development" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>

    <div class="container">
        <div class="row" align="center">
            <div class="tz-gallery">
                <div class="row">
                    <a class="lightbox" href="../Image/WebDevelopmentPic.jpg">
                        <img src="../Image/WebDevelopmentPic.jpg" class="img-responsive" style="border-radius: 10px; max-height:400px; max-width:700px" />
                    </a>
                </div>
            </div>
        </div>
        <div class="row" align="center">
            <h2 style="color: orange">Do you need web developers?</h2>
            <hr style="border: 2px solid; color: lightgray; width: 200px">
            <p style="font-family: Impact; font-size: 25px">software company is an IT partner with resources in web development.</p>
            <h4 style="font-family: Calibri">We are a Swedish company with over twelve years of experience in IT delivery. 
                    We are proud to list award winning Swedish web productions amongst our client 
                    projects, such as the e-commerce success MatHem.se, and the communication tool 
                    for preschools, Förskoleappen.
            </h4>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-9 col-md-12 col-lg-9 col-lg-offset-2 col-sm-offset-1">
                <h2 align="center"><b>Some of the technologies we are skilled in:</b></h2>
                <div class="col-sm-3 col-md-3 col-md-offset-2 col-sm-offset-2">
                    <ul style="font-size: 20px">
                        <li>HTML5</li>
                        <li>CSS3</li>
                        <li>Javascript</li>
                        <li>jQuery</li>
                        <li>Bootstrap</li>
                    </ul>
                </div>

                <div class="col-sm-6 col-md-6">
                    <ul style="font-size: 20px">
                        <li>ASP.NET</li>
                        <li>ASP.NET Web API</li>
                        <li>ASP.NET MVC</li>
                        <li>ADO.NET</li>
                        <li>SQL Server</li>
                    </ul>
                </div>

            </div>
        </div>
    </div>
    <br />
    <hr style="border: 5px solid; color: #F5F3F1">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-sm-10 col-md-12 col-lg-10 col-lg-offset-1 col-sm-offset-1">
                <h2 style="color: orange; font-family: Impact" class="text-center">How does it work?</h2>
                <br />
                <h3><b>We have two models of cooperation:</b></h3>
                <ul style="font-size: 19px">
                    <li>Project development. We take full responsibility for the project, from specs to delivery.</li>
                    <li>Dedicated team. You have your own team of developers, working either on-site at your office, or off-site at one of our locations. It’s your call.</li>
                </ul>
                <br />
                <h4 style="font-size: 21px">We are experts at leading remote teams in web development. Regardless of whether our developers sit with us or with you, we ensure that cooperation flows smoothly. We use agile management tools that give our clients full insight into the ongoing work.</h4>
                <br />
                <h4 style="font-size: 21px">A Swedish technical project manager is always onboard at the start of a new project. This is an efficient way of minimizing the risk of misunderstandings associated with the purpose and design of the solution.</h4>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>

