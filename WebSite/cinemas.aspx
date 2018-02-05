<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="cinemas.aspx.cs" Inherits="WebSite.cinemas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
            <h1 class="page-title">Search for Cinemas</h1>
        </div>




        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <aside class="sidebar-left">
                        
                            <div class="form-group form-group-icon-left"><i class="fa fa-map-marker input-icon input-icon-hightlight"></i>
                                <label>Where</label>
                                <input class="typeahead form-control" placeholder="City, Hotel Name or U.S. Zip Code" type="text" id="city" runat="server" />
                            </div>
                  <asp:Button ID="Button1" runat="server" Text="Search for Cinemas" CssClass="btn btn-primary mt10" OnClick="Button1_Click" />
                    </aside>
                </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <Triggers>
<asp:AsyncPostBackTrigger ControlID="Button1" EventName="click"/>
</Triggers>
                <ContentTemplate>

                  <div class="col-md-9">
                    <h3 class="mb20">Cinemas in <span id="cityname" runat="server"></span></h3>
                   
                    <div class="gap"></div>
                    <h3 class="mb20">Top Deals</h3>
                    <div class="row row-wrap">
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/hotel_2_800x600.jpg" alt="Image Alternative text" title="hotel 2" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star-o"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">New York Hilton Midtown</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> Flushing, NY (LaGuardia Airport (LGA))</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$164</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg" alt="Image Alternative text" title="LHOTEL PORTO BAY SAO PAULO lobby" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star-half-empty"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">JFK Inn</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Chelsea)</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$187</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/hotel_porto_bay_serra_golf_library_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY SERRA GOLF library" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star-half-empty"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">The Benjamin</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> East Elmhurst, NY (LaGuardia Airport (LGA))</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$432</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/hotel_eden_mar_suite_800x600.jpg" alt="Image Alternative text" title="hotel EDEN MAR suite" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">Club Quarters Grand Central</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Downtown - Wall Street)</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$377</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/hotel_porto_bay_serra_golf_suite2_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY SERRA GOLF suite2" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">Affinia Shelburne</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> Jamaica, NY (Kennedy Airport (JFK))</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$391</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/hotel_porto_bay_liberdade_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY LIBERDADE" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star-half-empty"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">Holiday Inn Express Kennedy</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Midtown East)</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$340</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/the_pool_800x600.jpg" alt="Image Alternative text" title="The pool" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star-o"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">Grand Hyatt New York</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> Jamaica, NY (Kennedy Airport (JFK))</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$337</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/lhotel_porto_bay_sao_paulo_suite_lhotel_living_room_800x600.jpg" alt="Image Alternative text" title="LHOTEL PORTO BAY SAO PAULO suite lhotel living room" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star-o"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">Bryant Park Hotel</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> Ozone Park, NY (Kennedy Airport (JFK))</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$246</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="thumb">
                                <header class="thumb-header">
                                    <a class="hover-img" href="#">
                                        <img src="img/hotel_the_cliff_bay_spa_suite_800x600.jpg" alt="Image Alternative text" title="hotel THE CLIFF BAY spa suite" />
                                        <h5 class="hover-title-center">See Detail</h5>
                                    </a>
                                </header>
                                <div class="thumb-caption">
                                    <ul class="icon-group text-tiny text-color">
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                        <li><i class="fa fa-star"></i>
                                        </li>
                                    </ul>
                                    <h5 class="thumb-title"><a class="text-darken" href="#">Wellington Hotel</a></h5>
                                    <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Downtown - Wall Street)</small>
                                    </p>
                                    <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$373</span><small> avg/night</small>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="gap gap-small"></div>
                </div>
                                                              </ContentTemplate></asp:UpdatePanel>
              
            </div>
        </div>

</asp:Content>
