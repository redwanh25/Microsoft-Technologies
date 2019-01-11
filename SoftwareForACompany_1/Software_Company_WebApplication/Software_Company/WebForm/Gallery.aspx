<%@ Page Title="" Language="C#" MasterPageFile="~/WebForm/Site.Master" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="Software_Company.WebForm.Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

<%--    <style>
        body {
            padding-top: 50px;
        }
    </style>--%>

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
            if (width > 0 && width <= 540 && ratio != "540" && $("[id*=hfColumnRepeat]").val() != "1") {
                $("[id*=hfColumnRepeat]").val(1);
                $("[id*=btnfake]").click();
            }
            if (width > 540 && width <= 768 && ratio != "768" && $("[id*=hfColumnRepeat]").val() != "2") {
                $("[id*=hfColumnRepeat]").val(2);
                $("[id*=btnfake]").click();
            }
            else if (width > 768 && width <= 980 && ratio != "980" && $("[id*=hfColumnRepeat]").val() != "3") {
                $("[id*=hfColumnRepeat]").val(3);
                $("[id*=btnfake]").click();
            }
            else if (width > 980 && ratio != "981" && $("[id*=hfColumnRepeat]").val() != "4") {
                $("[id*=hfColumnRepeat]").val(4);
                $("[id*=btnfake]").click();
            }
        }
    </script>

    <%-- Fake button just for call onClick of button event using jquery function--%>
    <asp:Button ID="btnfake" runat="server" OnClick="OnClick" Style="display: none" />
    <%-- Hidden filed to set the ratio value--%>
    <asp:HiddenField ID="hfColumnRepeat" runat="server" Value="3" />

    <div class="container">
        <div class="container gallery-container">

            <h2 class="text-center" style="font-family:Impact">Image Gallery</h2>
            <h3 class="page-description text-center shadow_T">
                Our employees are our most valuable assets.
                Indpro has over 80 employees, skilled in various technologies and platforms.
            </h3>

            <%--<div class="tz-gallery">
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
            </div>--%>

            <div class="tz-gallery">
                <div class="row">
                    <asp:DataList ID="DataList2" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-xs-11 col-sm-11 col-md-11 col-lg-11">
                                    <div class="card">
                                        <%#GetImage2(Container.DataItem)%>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>

        </div>
    </div>
    <script type="text/javascript">
        baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>
