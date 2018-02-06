<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="passwordverfiy.aspx.cs" Inherits="OnlineTicket.passwordverfiy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <h1 align="center">Recover Password</h1>
        <div class="col-md-12">
           
       
       
                  <div class="col-md-4 col-lg-offset-4 " id="usernamediv" runat="server">
                 <div class="form-group">
                     <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Doesn't Match" ControlToCompare="Password" ControlToValidate="CPassword"></asp:CompareValidator>
                    <label> New Password </label>
                     <asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                     </div>
                      <div class="form-group">
                     <span id="Span1" runat="server"></span>
                    <label> Confirm Password </label>
                     <asp:TextBox ID="CPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                     </div>
                  <div class="form-group center-block">
                      <asp:Button ID="Button1" runat="server" Text="Find" CssClass="btn btn-primary" OnClick="Button1_Click" />
                     </div>
        </div>
                
           
             </div>
    </div>
</asp:Content>
