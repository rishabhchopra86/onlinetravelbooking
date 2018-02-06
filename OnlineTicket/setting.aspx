<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="setting.aspx.cs" Inherits="WebSite.setting" %>
asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
                    <div class="row">
                        <div class="col-md-5">
                            <form action="#">
                                <h4>Personal Infomation</h4>
                                <div class="form-group form-group-icon-left"><i class="fa fa-user input-icon"></i>
                                    <label>First Name</label>
                                    <input class="form-control" value="John" type="text" />
                                </div>
                                <div class="form-group form-group-icon-left"><i class="fa fa-user input-icon"></i>
                                    <label>Last Name</label>
                                    <input class="form-control" value="Doe" type="text" />
                                </div>
                                <div class="form-group form-group-icon-left"><i class="fa fa-envelope input-icon"></i>
                                    <label>E-mail</label>
                                    <input class="form-control" value="johndoe@gmail.com" type="text" />
                                </div>
                                <div class="form-group form-group-icon-left"><i class="fa fa-phone input-icon"></i>
                                    <label>Phone Number</label>
                                    <input class="form-control" value="+1 202 555 0113" type="text" />
                                </div>
                                <div class="gap gap-small"></div>
                                <h4>Location</h4>
                                <div class="form-group form-group-icon-left"><i class="fa fa-plane input-icon"></i>
                                    <label>Home Airport</label>
                                    <input class="form-control" value="London Heathrow Airport (LHR)" type="text" />
                                </div>
                                <div class="form-group">
                                    <label>Street Address</label>
                                    <input class="form-control" value="46 Gray's Inn Rd, London, WC1X 8LP" type="text" />
                                </div>
                                <div class="form-group">
                                    <label>City</label>
                                    <input class="form-control" value="London" type="text" />
                                </div>
                                <div class="form-group">
                                    <label>State/Province/Region</label>
                                    <input class="form-control" value="London" type="text" />
                                </div>
                                <div class="form-group">
                                    <label>ZIP code/Postal code</label>
                                    <input class="form-control" value="4115523" type="text" />
                                </div>
                                <div class="form-group">
                                    <label>Country</label>
                                    <input class="form-control" value="United Kingdom" type="text" />
                                </div>
                                <hr>
                                <input type="submit" class="btn btn-primary" value="Save Changes">
                            </form>
                        </div>
                        <div class="col-md-4 col-md-offset-1">
                            <h4>Change Password</h4>
                            <form>
                                <div class="form-group form-group-icon-left"><i class="fa fa-lock input-icon"></i>
                                    <label>Current Password</label>
                                    <input class="form-control" type="password" />
                                </div>
                                <div class="form-group form-group-icon-left"><i class="fa fa-lock input-icon"></i>
                                    <label>New Password</label>
                                    <input class="form-control" type="password" />
                                </div>
                                <div class="form-group form-group-icon-left"><i class="fa fa-lock input-icon"></i>
                                    <label>New Password Again</label>
                                    <input class="form-control" type="password" />
                                </div>
                                <hr />
                                <input class="btn btn-primary" type="submit" value="Change Password" />
                            </form>
                        </div>
                    </div>

                </div>
            </div>
        </div>



        <div class="gap"></div>
</asp:Content>

