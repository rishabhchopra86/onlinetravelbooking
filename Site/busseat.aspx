<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="busseat.aspx.cs" Inherits="busseat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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


