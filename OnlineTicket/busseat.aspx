<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="busseat.aspx.cs" Inherits="WebSite.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
 <div class="gap"></div>
    <div class="container">
        <div class="row">

            <div class="col-md-12">
                 <h3 >BUS SEAT STATUS</h3>
                <hr>
                <div class="row row-wrap">
                    <div class="col-md-4 col-lg-offset-4">


                        <div class="input-group">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="PNR Number" ></asp:TextBox>
                              <span class="input-group-btn">
                            <asp:Button ID="Button1" runat="server" Text="Get Status" CssClass="btn btn-primary"/>
                                  </span>
                        </div>


                    </div>

                </div>




            </div>
        </div>
    </div>
</asp:Content>



