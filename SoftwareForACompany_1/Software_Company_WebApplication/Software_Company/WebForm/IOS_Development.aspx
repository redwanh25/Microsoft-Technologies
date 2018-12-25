<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="IOS_Development.aspx.cs" Inherits="Software_Company.WebForm.IOS_Development" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>
    <style>
        .affix {
            top: 80px;
            /*background-color:#F5F2F0;
            padding-right:115px;
            padding-left:30px;*/
        }
        /*affix-bottom position absolute na dile pin ta thik moto hoye thake na. aita dite hobe.*/
        .affix-bottom {
            position: absolute;
        }
    </style>
    <div class="container">
        <div class="row">
            <div id="scrl">
                <div class="col-sm-4 col-lg-3 hidden-xs">
                    <br />
                    <nav id="mainNavbar">
                        <ul id="nav" style="width: 230px" class="nav nav-pills nav-stacked h4" data-spy="affix" data-offset-top="440" data-offset-bottom="740">
                            <%-- data-offset-bottom="500"--%>
                            <li style="font-size: 21px">IOS Development</li>
                            <li><a href="#WhoWeAre">Who we are</a></li>
                            <li>
                                <br />
                                <br />
                            </li>
                            <li style="font-size: 21px">What we offer</li>
                            <li><a href="#TheLatestTechnology">The latest technology</a></li>
                            <li><a href="#Growth">Growth</a></li>
                            <li><a href="#Responsibility">Responsibility</a></li>
                            <li><a href="#PrimeLocation">Prime location</a></li>
                            <li><a href="#InternationalExposure">International exposure</a></li>
                            <li><a href="#LotsOfFun">Lots of Fun</a></li>
                            <li>
                                <br />
                                <br />
                            </li>
                            <li style="font-size: 21px">What we want</li>
                            <li><a href="#IOSDeveloper">IOS Developer</a></li>

                            <%--<li class="col-md-12 col-sm-6 col-xs-6 h4">
                                <b>You want to know more? </b>
                                <br />
                                <asp:Button Style="margin-top: 10px" ID="Button1" runat="server" Text="Click here" class="btn btn-danger btn-sm" />
                            </li>--%>
                        </ul>
                    </nav>
                </div>
                <div class="col-sm-9 col-xs-12">
                    <div class="tz-gallery">
                        <div class="row">
                            <a class="lightbox" href="../Image/ios_logo.png">
                                <img src="../Image/ios_logo.png" class="img-responsive" />
                            </a>
                        </div>
                    </div>

                    <div class="well" id="WhoWeAre">
                        <h2 style="font-family: Impact">Who We Are </h2>
                        <p style="font-size: 19px">
                            Indpro is a vibrant, Swedish based software development company founded in 2005.  We have offices on three continents. Our headquarter is in Stockholm, Sweden. Our biggest delivery centre is in World Trade Centre, Bangalore, India, and we are close to 100 employees in the organization. We deliver high quality IT solutions through blended sourcing, combining Scandinavian management with Indian skills.
                        </p>
                    </div>
                    <div class="well" id="TheLatestTechnology">
                        <h2 style="font-family: Impact">The Latest Technology </h2>
                        <p style="font-size: 19px">
                            Sweden is one of the highest developed IT countries in the world and the birthplace of IT successes such as Skype, Minecraft and Spotify. Our clients are progressive Scandinavian e-commerce and IT product companies. Working with them means that you will be working with cutting edge technology.
                        </p>
                    </div>
                    <div class="well" id="Growth">
                        <h2 style="font-family: Impact">Growth </h2>
                        <p style="font-size: 19px">
                            Indpro makes you grow – that’s our motto. We are a growing company and we like to help our clients grow, but it’s equally important that our staff grows. We recognize that our staff is our greatest asset and offer long term career growth and opportunities. In return, we expect you to develop and learn continuously.
                        </p>
                    </div>
                    <div class="well" id="Responsibility">
                        <h2 style="font-family: Impact">Responsibility </h2>
                        <p style="font-size: 19px">
                            We have a flat hierarchy and expect our staff to take responsibility for their own work. We don’t mind if your chai break is 10 minutes longer than usual, if that helps you deliver better code. The flexibility we offer gives you a lot of influence on your work situation, as well as the ability to work from home.
                        </p>
                    </div>
                    <div class="well" id="PrimeLocation">
                        <h2 style="font-family: Impact">Prime Location </h2>
                        <p style="font-size: 19px">
                            Our Bangalore office is beautifully located in the top modern World Trade Center. Here you will not only find office neighbors such as Amazon, but also great facilities including restaurants and shopping.
                        </p>
                    </div>
                    <div class="well" id="InternationalExposure">
                        <h2 style="font-family: Impact">International Exposure </h2>
                        <p style="font-size: 19px">
                            At Indpro, we are a global family. Working with us will give you exposure to international clients. Our developers communicate directly with clients, regardless of experience level. We also offer the opportunity to travel and work abroad.
                        </p>
                    </div>
                    <div class="well" id="LotsOfFun">
                        <h2 style="font-family: Impact">Lots Of Fun </h2>
                        <p style="font-size: 19px">
                            Last but not the least, we have fun! Employee well-being is high on our list of priorities and we engage in fun company activities, outings, hackatons and conferences as often as we can.
                        </p>
                    </div>
                    <div class="well" id="IOSDeveloper">
                        <h2 style="font-family: Impact">IOS Developer </h2>
                        <h3>Requirements:</h3>
                        <ul style="font-size: 19px">
                            <li>Minimum 2 years of experience with iOS, OSX.</li>
                            <li>Knowledge of Swift and Objective-C is a must.</li>
                            <li>Should have worked with webservices, databases (SQLite with Core Data).</li>
                            <li>Experience with Location Manager.</li>
                            <li>Good code quality.</li>
                            <li>Good capability of understanding requirements.</li>
                            <li>Ability to cope with stress and pressure.</li>
                        </ul>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <%--Smooth Scroll with jQuery--%>
    <script type="text/javascript">

        //$(document).ready(function () {
        //    $('#scrl').scrollspy({
        //        target: '#mainNavbar',
        //        offset: 60
        //    });
        //});
        $('a[href*="#"]')
            // Remove links that don't actually link to anything
            .not('[href="#"]')
            .not('[href="#0"]')
            .click(function (event) {
                // On-page links
                if (
                    location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '')
                    &&
                    location.hostname == this.hostname
                ) {
                    // Figure out element to scroll to
                    var target = $(this.hash);
                    target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
                    // Does a scroll target exist?
                    if (target.length) {
                        // Only prevent default if animation is actually gonna happen
                        event.preventDefault();
                        $('html, body').animate({
                            scrollTop: target.offset().top
                        }, 1000, function () {
                            // Callback after animation
                            // Must change focus!
                            var $target = $(target);
                            $target.focus();
                            if ($target.is(":focus")) { // Checking if the target was focused
                                return false;
                            } else {
                                $target.attr('tabindex', '-1'); // Adding tabindex for elements not focusable
                                $target.focus(); // Set focus again
                            };
                        });
                    }
                }
            });
    </script>

    <script type="text/javascript">
        baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>
