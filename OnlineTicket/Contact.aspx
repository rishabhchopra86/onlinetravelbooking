<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebSite.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <div class="container">
            <h1 class="page-title">Contact Us</h1>
        </div>
  <div class="container">
        </div>
        <div class="container">
          <div class="row">
                <div class="col-md-6">
                    <h1>Feel free to fill..!</h1>
                     <div class="row">
                          <div class="form-group">
                                    <label>Name</label>
                                    <input class="form-control" runat="server" id="txtname" type="text" />
                                </div>
                         <div class="form-group">
                                    <label>E-mail</label>
                                    <input class="form-control" runat="server" id="txtemail" type="text" />
                                </div>
                         <div class="form-group">
                            <label>Message</label>
                            <textarea class="form-control" runat="server" id="txtmessage"></textarea>
                        </div>
                        <div class="form-group">
                            <label>Phone No</label>
                             <input class="form-control" type="text" runat="server" id="txtno"/>
                        </div>
                     <asp:Button ID="btnmsg"  cssClass="btn btn-primary" runat="server" Text="Send Message" OnClick="btnmsg_Click" />
                  
                </div>
              </div>
        
                <div class="col-md-6">
                    <aside class="sidebar-right">
                        <ul class="address-list list">
                            <li>
                                <h5>Email</h5><a href="#">journey.com</a>
                            </li>
                            <li>
                                <h5>Phone Number</h5><a href="#">+91-9998889997</a>
                            </li>
                            <li>
                                <h5>Skype</h5><a href="#">journey_traveller</a>
                            </li>
                            <li>
                                <h5>Address</h5><address>Journey Ltd.<br />405,406 Luxuria Business Hub<br />Surat-395010, Gujarat<br />India<br /></address>
                            </li>
                        </ul>
                    </aside>
                </div>
            </div>
            <div class="gap"></div>
        </div>
</asp:Content>

