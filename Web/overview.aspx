<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="overview.aspx.cs" Inherits="overview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="gap"></div>
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <aside class="user-profile-sidebar">
                        <div class="user-profile-avatar text-center">
                            <img src="img/amaze_300x300.jpg" alt="Image Alternative text" title="AMaze" />
                            <h5>John Doe</h5>
                            <p>Member Since May 2012</p>
                        </div>
                        <ul class="list user-profile-nav">
                           <li><a href="overview.aspx"><span class="fa fa-balance-scale"></span> Overvirew</a>
                                   
                                </li>
                                <li><a href="setting.aspx"><span class="fa fa-gears"></span> Settings</a>
                                   
                                </li>
                            <li><a href="history.aspx"><span class="fa fa-files-o "></span> Booking History</a>
                                   
                                </li>
                            <li><a href="profile.aspx"><span class="fa fa-user"></span> My Profile</a>
                                   
                                </li>
                            <li><a href="logout.aspx"><span class="fa fa-sign-out"></span> Logout</a>
                                   
                                </li>
                        </ul>
                    </aside>
                </div>
                  <div class="col-md-9">
                    <h4>Total Traveled</h4>
                    <ul class="list list-inline user-profile-statictics mb30">
                        <li><i class="fa fa-dashboard user-profile-statictics-icon"></i>
                            <h5>12540</h5>
                            <p>Miles</p>
                        </li>
                        <li><i class="fa fa-globe user-profile-statictics-icon"></i>
                            <h5>2%</h5>
                            <p>World</p>
                        </li>
                        <li><i class="fa fa-building-o user-profile-statictics-icon"></i>
                            <h5>15</h5>
                            <p>Cityes</p>
                        </li>
                        <li><i class="fa fa-flag-o user-profile-statictics-icon"></i>
                            <h5>3</h5>
                            <p>Countries</p>
                        </li>
                        <li><i class="fa fa-plane user-profile-statictics-icon"></i>
                            <h5>20</h5>
                            <p>Trips</p>
                        </li>
                    </ul>
                    <div id="map-canvas" style="width:100%; height:400px;"></div>
                </div>
            </div>
        </div>



        <div class="gap"></div>
</asp:Content>
