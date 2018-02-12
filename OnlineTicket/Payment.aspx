<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="OnlineTicket.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="gap"></div>
       <div class="container">
            <div class="row row-wrap">
               

                <div class="col-md-6">
                    <div class="booking-item-payment">
                        <header class="clearfix">
                            <a class="booking-item-payment-img" href="#" id="MovieImage" runat="server">
                                <img src="img/4_strokes_of_fun_800x600.jpg" alt="Image Alternative text" title="4 Strokes of Fun" />
                            </a>
                            <h5 class="booking-item-payment-title"><a href="#" id="MovieName" runat="server"></a></h5>
                            <ul class="icon-group booking-item-rating-stars" id="rate" runat="server">
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
                        </header>
                        <ul class="booking-item-payment-details">
                            <li>
                                <h5 id="date" runat="server">April, 27 Saturday</h5>
                            </li>
                            <li>
                                <h5> Number of Person :- <span id="personno" runat="server"></span></h5>
                                <ul class="booking-item-payment-price">
                                    <li>
                                       
                                        <p class="booking-item-payment-price-amount">Amount :- <span id="perpersonamt" runat="server"></span><small>/per Person</small>
                                        </p>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <p class="booking-item-payment-total">Total Amount: <span><span id="totalamt" runat="server"></span></span>
                            <asp:Button ID="Button1" CssClass="btn btn-primary pull-right" runat="server" Text="Click to Payment" OnClick="Button1_Click" />
                        </p>
                       
                    </div>
                </div>
            </div>
            <div class="gap"></div>
        </div>
</asp:Content>
