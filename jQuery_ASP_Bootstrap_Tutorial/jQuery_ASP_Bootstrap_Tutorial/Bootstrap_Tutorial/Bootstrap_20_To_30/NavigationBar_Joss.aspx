<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavigationBar_Joss.aspx.cs" Inherits="jQuery_ASP_Bootstrap_Tutorial.Bootstrap_Tutorial.Bootstrap_20_To_30.NavigationBar_Joss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../jquery_Bootstrap_SweetAlert/jQuery/uncompressed/jquery-3.3.1.js"></script>
    <script src="../../jquery_Bootstrap_SweetAlert/Bootstrap/js/bootstrap.min.js"></script>
    <link href="../../jquery_Bootstrap_SweetAlert/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        body {
            padding-top: 150px;
        }

        #global-nav {
            position: fixed;
            top: 0;
            z-index: 9999;
            opacity: .9;
            height: 150px;
            width: 100%;
            background: #324c5f;
            color: #fff;
            line-height: 150px;
            -webkit-transition: height .5s, line-height .5s; /* Safari */
            transition: height .5s, line-height .5s;
        }

        .site-title {
            display: inline-block;
            -webkit-transition: all .5s;
            transition: all .5s;
        }

        .scrolled-nav .site-title {
            font-size: 16px;
        }

        .nav-list {
            list-style: none;
        }

            .nav-list li {
                list-style: none;
                display: inline-block;
                padding-left: 20px;
            }

        .scrolled-nav {
            height: 60px !important;
            line-height: 60px !important;
        }

        .counter {
            width: 20px;
            height: 20px;
            background: black;
            color: #fff;
            position: fixed;
            top: 120px;
            right: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav id="global-nav" class="nav">
            <div class="container">
                <div class="pull-left">
                    <h1 class="site-title">
                    Site Title </h1>
                </div>
                <div class="pull-right">
                    <ul class="nav-list">
                        <li>Link One</li>
                        <li>Link Two</li>
                        <li>Link Three</li>
                    </ul>
                </div>
            </div>
        </nav>

        <div class="hero-section">
            <div class="container">
                <div class="hero-text">
                    <h1>Hero Section!</h1>
                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                </div>
            </div>
        </div>

        <div class="content-section">
            <div class="container">
                <div class="content-text">
                    <h1>Content Section!</h1>
                    <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life.</p>
                </div>
            </div>
        </div>

        <div class="hero-section">
            <div class="container">
                <div class="hero-text">
                    <h1>Hero Section!</h1>
                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                </div>
            </div>
        </div>

        <div class="content-section">
            <div class="container">
                <div class="content-text">
                    <h1>Content Section!</h1>
                    <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life.</p>
                </div>
            </div>
        </div>

        <div class="hero-section">
            <div class="container">
                <div class="hero-text">
                    <h1>Hero Section!</h1>
                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                </div>
            </div>
        </div>

        <div class="content-section">
            <div class="container">
                <div class="content-text">
                    <h1>Content Section!</h1>
                    <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life.</p>
                </div>
            </div>
        </div>

        <div class="hero-section">
            <div class="container">
                <div class="hero-text">
                    <h1>Hero Section!</h1>
                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                </div>
            </div>
        </div>

        <div class="content-section">
            <div class="container">
                <div class="content-text">
                    <h1>Content Section!</h1>
                    <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life.</p>
                </div>
            </div>
        </div>

        <div class="hero-section">
            <div class="container">
                <div class="hero-text">
                    <h1>Hero Section!</h1>
                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                </div>
            </div>
        </div>

        <div class="content-section">
            <div class="container">
                <div class="content-text">
                    <h1>Content Section!</h1>
                    <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life.</p>
                </div>
            </div>
        </div>


    </form>
</body>
</html>

<script>
    $(document).ready(function () {
        var scrollTop = 0;
        $(window).scroll(function () {
            scrollTop = $(window).scrollTop();
            $('.counter').html(scrollTop);

            if (scrollTop >= 100) {
                $('#global-nav').addClass('scrolled-nav');
            } else if (scrollTop < 100) {
                $('#global-nav').removeClass('scrolled-nav');
            }

        });

    });
</script>
