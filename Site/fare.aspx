<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="fare.aspx.cs" Inherits="fare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="gap"></div>
    <div class="container">
        <div class="row">

            <div class="col-md-12">
                 <h3 >Fare Enquiry</h3>
                <hr>
                <div class="row row-wrap">
                    <div class="col-md-2 ">

                           <div class="form-group form-group">
                                    <label>Enter Train Number</label>
                                    <input class="form-control" type="email" placeholder="Enter Train Number" />
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
                                    <label>Enter Source Station</label>
                                    <input class="form-control" type="email" placeholder="Enter Source Station" />
                                </div>
                        </div>
             <div class="col-md-2 ">
             <div class="form-group form-group">
                                    <label>Enter Destination Station</label>
                                    <input class="form-control" type="email" placeholder="Enter Destination Station" />
                                </div>
                        </div>
                 <div class="col-md-2 ">
             <div class="form-group form-group">
                                    <label>Enter Class</label>
                                    <input class="form-control" type="email" placeholder="Enter Destination Station" />
                                </div>
                        </div>
                     <div class="col-md-2 ">
             <div class="form-group form-group">
                                    <label>Enter Quota</label>
                                    <input class="form-control" type="email" placeholder="Enter Destination Station" />
                                </div>
                        </div>
                  

                </div>
                  <div class="col-md-12">
                               

                       <div class="form-group ">
                           
                            <asp:Button ID="Button1" runat="server" Text="Get Fare" CssClass="btn btn-primary pull-right"/>
                                
                        </div>


                    </div>



            </div>
        </div>
    </div>
</asp:Content>

