<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="movies.aspx.cs" Inherits="WebSite.movies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
            <h1 class="page-title">Search for Movies</h1>
        </div>




        <div class="container">
           
                <div class="row">
                    <div class="col-md-4">
                        <div class="form-group form-group-icon-left"><i class="fa fa-map-marker input-icon input-icon-hightlight"></i>
                            <label>Where</label>
                            <input class="typeahead form-control" placeholder="City, Hotel Name or U.S. Zip Code" type="text" id="city" runat="server" />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="input-daterange" data-date-format="MM d, D">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group form-group-icon-left"><i class="fa fa-calendar input-icon input-icon-hightlight"></i>
                                        <label>Movie Name</label>
                                       <asp:TextBox ID="MovieName" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                               
                            </div>
                        </div>
                    </div>
            
                </div>
            <asp:Button ID="Button1" runat="server" Text="Search for Movie" CssClass="btn btn-primary mt10" OnClick="Button1_Click" />
          <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
                <div class="gap gap-small"></div>
            <h3 class="mb20"><span id="movie" runat="server"></span></h3>
            
            <div class="gap"></div>
            <h3 class="mb20">Top Deals</h3>
            <div class="row row-wrap">
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/hotel_porto_bay_serra_golf_suite_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY SERRA GOLF suite" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">The Kimberly Hotel</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> East Elmhurst, NY (LaGuardia Airport (LGA))</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$499</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/hotel_1_800x600.jpg" alt="Image Alternative text" title="hotel 1" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">InterContinental New York B...</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> Ozone Park, NY (Kennedy Airport (JFK))</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$212</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/hotel_porto_bay_serra_golf_library_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY SERRA GOLF library" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                                <li><i class="fa fa-star-half-empty"></i>
                                </li>
                                <li><i class="fa fa-star-o"></i>
                                </li>
                            </ul>
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">The Benjamin</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> Bronx (Bronx)</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$399</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/hotel_porto_bay_serra_golf_living_room_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY SERRA GOLF living room" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">Waldorf Astoria New York</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Upper West Side)</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$413</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/hotel_porto_bay_rio_internacional_de_luxe_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY RIO INTERNACIONAL de luxe" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">The London NYC</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Times Square)</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$441</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/hotel_the_cliff_bay_spa_suite_800x600.jpg" alt="Image Alternative text" title="hotel THE CLIFF BAY spa suite" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">Wellington Hotel</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Downtown - Wall Street)</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$438</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/hotel_porto_bay_serra_golf_suite2_800x600.jpg" alt="Image Alternative text" title="hotel PORTO BAY SERRA GOLF suite2" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">Affinia Shelburne</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> Jamaica, NY (Kennedy Airport (JFK))</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$399</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="thumb">
                        <header class="thumb-header">
                            <a class="hover-img" href="moviecity.aspx">
                                <img src="img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg" alt="Image Alternative text" title="LHOTEL PORTO BAY SAO PAULO lobby" />
                                <h5 class="hover-title-center">Book Now</h5>
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
                            <h5 class="thumb-title"><a class="text-darken" href="moviecity.aspx">JFK Inn</a></h5>
                            <p class="mb0"><small><i class="fa fa-map-marker"></i> New York, NY (Midtown East)</small>
                            </p>
                            <p class="mb0 text-darken"><span class="text-lg lh1em text-color">$306</span><small> avg/night</small>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="gap gap-small"></div>

                                                            </ContentTemplate>
            
                <Triggers>
<asp:AsyncPostBackTrigger ControlID="Button1" EventName="click"/>
</Triggers>
          </asp:UpdatePanel>
          
        </div>
</asp:Content>
