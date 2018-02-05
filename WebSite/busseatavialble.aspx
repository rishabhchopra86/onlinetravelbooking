<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="busseatavialble.aspx.cs" Inherits="WebSite.busseatavialble" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div class="gap"></div>
    <div class="container">
        <div class="row">

            <div class="col-md-12">
                 <h3 >Accommodation Availability Enquiry on Trains till Departure</h3>
                <hr>
                <div class="row row-wrap">
                    <div class="col-md-2 ">

                           <div class="form-group form-group">
                                    <label>Enter Seat Number</label>
                                    <input class="form-control" type="email" placeholder="Enter Seat Number" />
                                </div>
                        </div>
                     <div class="col-md-2 ">
                      <div class="input-daterange">
                                
                                        <div class="form-group">
                                            <label>Start Date</label>
                                            <input class="form-control" name="start" type="text" />
                                        </div>
                            </div>
                        </div>
                     <div class="col-md-2 ">
                 <div class="form-group form-group">
                                    <label>Enter Source</label>
                                    <input class="form-control" type="email" placeholder="Enter Source" />
                                </div>
                        </div>
             <div class="col-md-2 ">
             <div class="form-group form-group">
                                    <label>Enter Destination</label>
                                    <input class="form-control" type="email" placeholder="Enter Destination" />
                                </div>
                        </div>
                 <div class="col-md-2 ">
             <div class="form-group form-group">
                                    <label>Enter Class</label>
                                    <input class="form-control" type="email" placeholder="Enter Class" />
                                </div>
                        </div>
                </div>
                  <div class="col-md-12">
                  
                       <div class="form-group ">
                      <asp:Button ID="btnGetAvailble" runat="server" Text="Get Availability" CssClass="btn btn-primary pull-right"/>
                     </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>


