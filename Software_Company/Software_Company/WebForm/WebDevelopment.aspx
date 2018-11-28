<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="WebDevelopment.aspx.cs" Inherits="Software_Company.WebForm.WebDevelopment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <style>
        .affix {
            top: 55px;
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
                <div class="col-sm-3 hidden-xs">
                    <nav id="mainNavbar">
                        <ul id="nav" style="width: 160px" class="nav nav-pills nav-stacked h4" data-spy="affix" data-offset-top="440" data-offset-bottom="740">
                            <%-- data-offset-bottom="500"--%>
                            <li class="h3">IT Solution</li>
                            <li><a href="#divDesert">Desert</a></li>
                            <li><a href="#divJellyFish">JellyFish</a></li>
                            <li><a href="#divLightHouse">LightHouse</a></li>
                            <li><a href="#divTulips">Tulips</a></li>
                            <li><a href="#divPenguins">Penguins</a></li>
                            <li><a href="#divRedwan">Redwan</a></li>
                            <li><a href="#divHossain">Hossain</a></li>
                            <li><a href="#divWhat">What</a></li>
                            <li><a href="#divThe">The</a></li>
                            <li><a href="#divHell">Hell</a></li>
                            <li><a href="#divIs">Is</a></li>
                            <li><a href="#divGoingOn">GoingOn</a></li>
                            <li>
                                <br />
                                <br />
                            </li>
                            <li class="col-md-12 col-sm-6 col-xs-6 h4">
                                <b>You want to know more? </b>
                                <br />
                                <asp:Button Style="margin-top: 10px" ID="Button1" runat="server" Text="Click here" class="btn btn-danger btn-sm" />
                            </li>
                        </ul>
                    </nav>
                </div>
                <div class="col-sm-9 col-xs-12">
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
                    <div class="jumbotron" id="divDesert">
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
                    <div class="jumbotron" id="divJellyFish">
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
                    <div class="jumbotron" id="divLightHouse">
                        <h3>LightHouse </h3>
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
                    <div class="jumbotron" id="divTulips">
                        <h3>Tulips </h3>
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
                    <div class="jumbotron" id="divPenguins">
                        <h3>Penguins </h3>
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
                    <div class="jumbotron" id="divRedwan">
                        <h3>Redwan </h3>
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
                    <div class="jumbotron" id="divHossain">
                        <h3>Hossain </h3>
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
                    <div class="jumbotron" id="divWhat">
                        <h3>What </h3>
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
                    <div class="jumbotron" id="divThe">
                        <h3>The </h3>
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
                    <div class="jumbotron" id="divHell">
                        <h3>Hell </h3>
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
                    <div class="jumbotron" id="divIs">
                        <h3>Is </h3>
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
                    <div class="jumbotron" id="divGoingOn">
                        <h3>GoingOn </h3>
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
</asp:Content>
