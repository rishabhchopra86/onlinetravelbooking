<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="moviecity.aspx.cs" Inherits="WebSite.moviecity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <ul class="breadcrumb">
                <li><a href="index-2.html">Home</a>
                </li>
                <li><a href="#">United States</a>
                </li>
                <li><a href="#">New York (NY)</a>
                </li>
                <li><a href="#">New York City</a>
                </li>
                <li><a href="#">New York City Hotels</a>
                </li>
                <li class="active">InterContinental New York Barclay</li>
            </ul>
            <div class="booking-item-details">
                <header class="booking-item-header">
                    <div class="row">
                        <div class="col-md-9">
                            <h2 class="lh1em" id="movieName" runat="server">InterContinental New York Barclay</h2>
                            <p class="lh1em text-small"><i class="fa fa-clock-o"></i>  <span  id="movieDuration" runat="server"></span></p>
                            <ul class="list list-inline text-small">
                                <li><a href="#"><i class="fa fa-language"></i> <span  id="movieLanguage" runat="server"></span></a>
                                </li>
                                <li><a href="#"><i class="fa fa-language"></i> <span  id="movieType" runat="server"></span></a>
                                </li>
                               
                            </ul>
                        </div>
                        <div class="col-md-3">
                            <p class="booking-item-header-price"><small>price from</small>  <span class="text-lg">$350</span>/night</p>
                        </div>
                    </div>
                </header>
                <div class="row">
                    <div class="col-md-6">
                        <div class="tabbable booking-details-tabbable">
                            <ul class="nav nav-tabs" id="myTab">
                                <li class="active"><a href="#tab-1" data-toggle="tab"><i class="fa fa-camera"></i>Photos</a>
                                </li>
                             
                            </ul>
                            <div class="tab-content">
                                <div class="tab-pane fade in active" id="tab-1">
                                <div class="fotorama" data-allowfullscreen="true" data-nav="thumbs" id="movieimage" runat="server">
                                  
                                </div>
                            </div>
                                <div class="tab-pane fade" id="google-map-tab">
                                    <div id="map-canvas" style="width:100%; height:500px;"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="booking-item-meta">
                            <h2 class="lh1em mt40">Exeptional!</h2>
                            <h3>97% <small >of guests recommend</small></h3>
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
                                </ul><span class="booking-item-rating-number"><b >4.7</b> of 5 <small class="text-smaller">guest rating</small></span>
                                <p><a class="text-default" href="#">based on 1535 reviews</a>
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
                                            <div style="width:89%;"></div>
                                        </div>
                                        <div class="booking-item-raiting-list-number">1231</div>
                                    </li>
                                    <li>
                                        <div class="booking-item-raiting-list-title">Very Good</div>
                                        <div class="booking-item-raiting-list-bar">
                                            <div style="width:5%;"></div>
                                        </div>
                                        <div class="booking-item-raiting-list-number">76</div>
                                    </li>
                                    <li>
                                        <div class="booking-item-raiting-list-title">Average</div>
                                        <div class="booking-item-raiting-list-bar">
                                            <div style="width:4%;"></div>
                                        </div>
                                        <div class="booking-item-raiting-list-number">40</div>
                                    </li>
                                    <li>
                                        <div class="booking-item-raiting-list-title">Poor</div>
                                        <div class="booking-item-raiting-list-bar">
                                            <div style="width:2%;"></div>
                                        </div>
                                        <div class="booking-item-raiting-list-number">13</div>
                                    </li>
                                    <li>
                                        <div class="booking-item-raiting-list-title">Terrible</div>
                                        <div class="booking-item-raiting-list-bar">
                                            <div style="width:1%;"></div>
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
                            <div class="tab-content" id="tabs" runat="server">
                              
                            </div>
                        </div>
                     
                        </div>
                    </div>
                </div>
                
            </div>
            <div class="gap gap-small"></div>
   <script>
       $(document).ready(function () {
           $('[data-toggle="tooltip"]').tooltip();
       });
</script>




</asp:Content>
