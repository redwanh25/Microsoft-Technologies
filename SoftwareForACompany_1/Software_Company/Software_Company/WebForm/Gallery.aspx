<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="Software_Company.WebForm.Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <link href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>
    <link href="../jquery_Bootstrap_SweetAlert_IHover/GalleryGrid/gallery-grid.css" rel="stylesheet" />
    <style>
        body{
            padding-top:50px;
        }
    </style>
    <div class="container">
        <div class="container gallery-container">

            <h1 class="text-center shadow_T">Image Gallery</h1>
            <p class="page-description text-center shadow_T">Our employees are our most valuable assets.
                Indpro has over 80 employees, skilled in various technologies and platforms.</p>

            <div class="tz-gallery">
                <div class="row">
                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/park.jpg">
                                <img src="../Image/park.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/benches.jpg">
                                <img src="../Image/benches.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/bridge.jpg">
                                <img src="../Image/bridge.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/coast.jpg">
                                <img src="../Image/coast.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/rails.jpg">
                                <img src="../Image/rails.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/rocks.jpg">
                                <img src="../Image/rocks.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/park.jpg">
                                <img src="../Image/park.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/benches.jpg">
                                <img src="../Image/benches.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/bridge.jpg">
                                <img src="../Image/bridge.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/coast.jpg">
                                <img src="../Image/coast.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/rails.jpg">
                                <img src="../Image/rails.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="card">
                            <a class="lightbox" href="../Image/rocks.jpg">
                                <img src="../Image/rocks.jpg" alt="Park" class="card-img-top">
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>
