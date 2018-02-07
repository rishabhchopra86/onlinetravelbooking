<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="movies.aspx.cs" Inherits="WebSite.movies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
            <h1 >Search for Movies</h1>
        </div>




        <div class="container">
           
                <div class="row">
                    <div class="col-md-12">
                    <div class="col-md-4">
                       
                                    <div class="form-group form-group-icon-left"><i class="fa fa-film input-icon input-icon-hightlight"></i>
                                        <label>Movie Name</label>
                                       <asp:TextBox ID="MovieName" runat="server" CssClass="form-control"></asp:TextBox>
                               
                    </div>
                          <asp:Button ID="Button1" runat="server" Text="Search for Movie" CssClass="btn btn-primary mt10" OnClick="Button1_Click" />
            </div>
                </div>
                  </div> 
         
               <div class="gap gap-small"></div>
            <div class="row">
            <div class="col-md-12">
              
          <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
           <div class="col-md-3">
                    
                    <aside class="booking-filters text-white">
                        <h3>Filter By:</h3>
                       
                        <ul class="list booking-filters-list">
                            <li id="listcheckboxLanguage" runat="server">
                                <h5 class="booking-filters-title">Language</h5>
                               
                            </li>
                            <li  id="listcheckboxType" runat="server">
                                <h5 class="booking-filters-title">Type</h5>
                              
                            </li>
                            
                        </ul>
                    </aside>
                </div>
         
         <div class="col-md-9">

            <h3 class="mb20">Top Movie</h3>
            <div class="row row-wrap" id="display" runat="server">
               
            </div>
             </div>
            <div class="gap gap-small"></div>

                                                            </ContentTemplate>
            
                <Triggers>
<asp:AsyncPostBackTrigger ControlID="Button1" EventName="click"/>

</Triggers>
          </asp:UpdatePanel>
                 
          </div>
        </div>
             </div>
   
</asp:Content>
