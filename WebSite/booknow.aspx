<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="booknow.aspx.cs" Inherits="WebSite.booknow" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
 <style type="text/css">
    .modalBackground
    {
        background-color: Black;
        filter: alpha(opacity=90);
        opacity: 0.8;
    }
    .modalPopup
    {
        background-color: #FFFFFF;
        border-width: 3px;
        border-style: solid;
        border-color: black;
        padding-top: 10px;
        padding-left: 10px;
        width: 500px;
        height: 200px;
    }
</style>
    <asp:LinkButton ID="LinkButton1" runat="server"></asp:LinkButton>
 <ajaxToolkit:ModalPopupExtender PopupControlID="Panel1" ID="ModalPopupExtender1" runat="server" 
        BackgroundCssClass="modalBackground" TargetControlID="LinkButton1" CancelControlID="btnClose"></ajaxToolkit:ModalPopupExtender>
<asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" style = "display:none">
     <div class="form-group form-group-select-plus" id="popup">
             <input type="hidden" id="hidVal" runat="server" />
        <h3>Persons</h3>
            <div class="btn-group btn-group-select-num" data-toggle="buttons">
                <label class="btn btn-primary active">
                    <input type="radio" name="options" />1</label>
                <label class="btn btn-primary">
                    <input type="radio" name="options" />2</label>
                <label class="btn btn-primary">
                    <input type="radio" name="options" />3</label>
                <label class="btn btn-primary">
                    <input type="radio" name="options" />4</label>
                <label class="btn btn-primary">
                    <input type="radio" name="options" />4+</label>
            </div>
            <select class="form-control hidden">
                <option>1</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
                <option selected="selected">5</option>
                <option>6</option>
                <option>7</option>
                <option>8</option>
                <option>9</option>
                <option>10</option>
                <option>11</option>
                <option>12</option>
                <option>13</option>
                <option>14</option>
            </select>
        </div>
    <asp:Button ID="btnClose" runat="server" Text="Close"/>
</asp:Panel>
    <asp:Panel ID="Panel2" runat="server"></asp:Panel>
     <!--<div class="container">
                <h3>Search for Flight</h3>
               
                    <div class="tabbable">
                      <div class="tab-content">
                            <div class="tab-pane fade in active">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group form-group-lg form-group-icon-left"><i class="fa fa-font input-icon input-icon-highlight"></i>
                                            <label>Full Name</label>
                                            <input class="typeahead form-control" placeholder="Full Name" type="text" />
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group form-group-lg form-group-icon-left"><i class="fa fa-font input-icon input-icon-highlight"></i>
                                            <label>Age</label>
                                            <input class="typeahead form-control" placeholder="Age" type="text" />
                                        </div>
                                    </div>
                                </div>
                              
                                </div>
                </div>
                    <button class="btn btn-primary btn-lg" type="submit">Submit</button>
             
            </div>-->
      </asp:Content>
