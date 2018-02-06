<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="forgetpassword.aspx.cs" Inherits="OnlineTicket.forgetpassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 align="center">Recover Password</h1>
        <div class="col-md-12">
           
       
       
                  <div class="col-md-4 col-lg-offset-4 " id="usernamediv" runat="server">
                 <div class="form-group">
                     <span id="errormessage" runat="server"></span>
                    <label> User Name </label>
                     <asp:TextBox ID="UserName" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                     </div>
                  <div class="form-group center-block">
                      <asp:Button ID="Button1" runat="server" Text="Find" CssClass="btn btn-primary" OnClick="Button1_Click" />
                     </div>
        </div>
                
           
             </div>
    </div>
</asp:Content>
