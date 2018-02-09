<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="cinemasdetail.aspx.cs" Inherits="WebSite.cinemasdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
  
        <div class="booking-item-details" >
            <header class="booking-item-header">
                <div class="row">
                    <div class="col-md-9">
                        <h2 class="lh1em"  id="cinemaName" runat="server">InterContinental New York Barclay</h2>
                        <p class="lh1em text-small"  id="cinemaAddress" runat="server"><i class="fa fa-map-marker"></i>6782 Sarasea Circle, Siesta Key, FL 34242</p>
                        <ul class="list list-inline text-small">
                            <li><a href="#"  id="cinemaemail" runat="server"><i class="fa fa-envelope"></i>Hotel E-mail</a>
                            </li>
                            <li><a href="#"  id="cinemaWebsite" runat="server"><i class="fa fa-home" ></i>Hotel Website</a>
                            </li>
                            <li><i class="fa fa-phone"></i><span  id="cinemaPhone" runat="server">+1 (543) 461-7550</span></li>
                        </ul>
                    </div>
                  
                </div>
            </header>
            <div class="row">
                <div class="col-md-6">
                    <div class="tabbable booking-details-tabbable">
                        <ul class="nav nav-tabs" id="myTab">
                            <li class="active"><a href="#tab-1" data-toggle="tab"><i class="fa fa-camera"></i>Photos</a>
                            </li>
                            <li><a href="#google-map-tab" data-toggle="tab"><i class="fa fa-map-marker"></i>On the Map</a>
                            </li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane fade in active" id="tab-1">
                                <div class="fotorama" data-allowfullscreen="true" data-nav="thumbs" id="cinemaimage" runat="server">
                                  
                                </div>
                            </div>
                            <div class="tab-pane fade" id="google-map-tab">
                                <div id="map-canvas" style="width: 100%; height: 500px;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="booking-item-meta">
                        <h2 class="lh1em mt40">Exeptional!</h2>
                        <h3>97% <small>of guests recommend</small></h3>
                        <div class="booking-item-rating">
                            <ul class="icon-list icon-group booking-item-rating-stars">
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
                            <span class="booking-item-rating-number"><b>4.7</b> of 5 <small class="text-smaller">guest rating</small></span>
                            <p>
                                <a class="text-default" href="#">based on 1535 reviews</a>
                            </p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-8">
                            <h4 class="lh1em">Traveler raiting</h4>
                            <ul class="list booking-item-raiting-list">
                                <li>
                                    <div class="booking-item-raiting-list-title">Exellent</div>
                                    <div class="booking-item-raiting-list-bar">
                                        <div style="width: 89%;"></div>
                                    </div>
                                    <div class="booking-item-raiting-list-number">1231</div>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Very Good</div>
                                    <div class="booking-item-raiting-list-bar">
                                        <div style="width: 5%;"></div>
                                    </div>
                                    <div class="booking-item-raiting-list-number">76</div>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Average</div>
                                    <div class="booking-item-raiting-list-bar">
                                        <div style="width: 4%;"></div>
                                    </div>
                                    <div class="booking-item-raiting-list-number">40</div>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Poor</div>
                                    <div class="booking-item-raiting-list-bar">
                                        <div style="width: 2%;"></div>
                                    </div>
                                    <div class="booking-item-raiting-list-number">13</div>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Terrible</div>
                                    <div class="booking-item-raiting-list-bar">
                                        <div style="width: 1%;"></div>
                                    </div>
                                    <div class="booking-item-raiting-list-number">7</div>
                                </li>
                            </ul>
                        </div>
                        <div class="col-md-4">
                            <h4 class="lh1em">Summary</h4>
                            <ul class="list booking-item-raiting-summary-list">
                                <li>
                                    <div class="booking-item-raiting-list-title">Sleep</div>
                                    <ul class="icon-group booking-item-rating-stars">
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Location</div>
                                    <ul class="icon-group booking-item-rating-stars">
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o text-gray"></i>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Service</div>
                                    <ul class="icon-group booking-item-rating-stars">
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Clearness</div>
                                    <ul class="icon-group booking-item-rating-stars">
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <div class="booking-item-raiting-list-title">Rooms</div>
                                    <ul class="icon-group booking-item-rating-stars">
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                        <li><i class="fa fa-smile-o"></i>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <a href="#" class="btn btn-primary">Write a Review</a>
                </div>
            </div>
           
           <div class="gap"></div>
                <div class="row">
                             <div class="col-md-12">
                                 <div class="tabbable booking-details-tabbable">
                            <ul class="nav nav-tabs" id="myTab1" runat="server">
                                
                            </ul>
                            <div class="tab-content" id="cinemadatedetail" runat="server">
                             
                            </div>
                        </div>
                       <!-- <div class="tabbable booking-details-tabbable">
                            <ul class="nav nav-tabs" id="myTab1">
                                <li class="active"><a href="#tab-11" data-toggle="tab"><i class="fa fa-camera"></i>8-feb</a>
                                </li>
                             <li><a href="#tab-13" data-toggle="tab"><i class="fa fa-camera"></i>9-feb</a>
                                </li>
                            </ul>
                            <div class="tab-content">
                                <div class="tab-pane fade in active" id="tab-12">
                               
                                    <div class="col-md-12">
                                             <div class="gap"></div>
                                         <div class="col-md-4"><span class="fa fa-heart-o"></span> Cinema Names</div>
                                           <div class="col-md-6">
                                               <div class="col-md-2">
                                                   <a href="movieseats.aspx" class="btn btn-default" data-toggle="tooltip" data-html="true" title="Avaiable : 100 seats">
                                                    6:00 p.m</a>
                                                   </div>
                                                <div class="col-md-2">
                                                  <a href="movieseats.aspx" class="btn btn-default" data-toggle="tooltip" data-html="true" title="Avaiable : 100 seats">
                                                    7:00 p.m</a>
                                               </div>
                                           </div>
                                        </div>
                                    
                                    <div class="col-md-12">
                                             <div class="gap"></div>
                                         <div class="col-md-4"><span class="fa fa-heart-o"></span> Cinema Names</div>
                                           <div class="col-md-6">
                                               <div class="col-md-2">
                                                   <a href="movieseats.aspx" class="btn btn-default" data-toggle="tooltip" data-html="true" title="Avaiable : 100 seats">
                                                    6:00 p.m</a>
                                                   </div>
                                                <div class="col-md-2">
                                                  <a href="movieseats.aspx" class="btn btn-default" data-toggle="tooltip" data-html="true" title="Avaiable : 100 seats">
                                                    7:00 p.m</a>
                                               </div>
                                           </div>
                                        </div>
                                    </div>
                                </div>
                             <div class="tab-pane fade" id="tab-13">
                                   <div class="col-md-12">
                                             <div class="gap"></div>
                                         <div class="col-md-4"><span class="fa fa-heart-o"></span> Cinema Names</div>
                                           <div class="col-md-6">
                                               <div class="col-md-2">
                                                   <a href="movieseats.aspx" class="btn btn-default" data-toggle="tooltip" data-html="true" title="Avaiable : 100 seats">
                                                    6:00 p.m</a>
                                                   </div>
                                                <div class="col-md-2">
                                                  <a href="movieseats.aspx" class="btn btn-default" data-toggle="tooltip" data-html="true" title="Avaiable : 100 seats">
                                                    7:00 p.m</a>
                                               </div>
                                           </div>
                                        </div>
                                </div>
                            </div>-->
                        </div>
                    </div>
        </div>
        <div class="gap gap-small"></div>
    </div>
</asp:Content>
