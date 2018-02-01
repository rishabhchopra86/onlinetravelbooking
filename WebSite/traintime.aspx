<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="traintime.aspx.cs" Inherits="WebSite.traintime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="gap"></div>
    <div class="container">
        <div class="row">

            <div class="col-md-12">
                 <h3 >Train Schedule</h3>
                <hr>
                 Please enter few characters of Train Name OR few digits of Train Number.
e.g. To get the train schedule for Himachal Express i.e. Train No. 14553 -- either enter himachal or 145

                <div class="row row-wrap">
                    <div class="col-md-4 col-lg-offset-4">
                       
                        <div class="input-group">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Enter Train Number" ></asp:TextBox>
                              <span class="input-group-btn">
                            <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn btn-primary"/>
                                  </span>
                        </div>


                    </div>

                </div>




            </div>
        </div>
    </div>
</asp:Content>


