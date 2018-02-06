<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="booknow.aspx.cs" Inherits="WebSite.booknow" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/jquery.js"></script>
    <script>
        $(document).ready(function () {
            $('#popup .per .lbl ').change(function () {
                var radioValue = $("input[name='options']:checked").val();

                for (var i = 0; i < radioValue; i++) {
                    $('.dyn').append("<input class='form-control' type='text' name='txtDyn' id='txt'" + i + " placeholder='fullname'/><br>");
                    $('.dyn').append("<input class='form-control' type='text' name='txtDyn' id='txt'" + i + " placeholder='Age'/><br>");
                    $('.dyn').append("<input type='radio' name='txtDyn' id='txt'" + i + " value='Male'/>Male");
                    $('.dyn').append("<input type='radio' name='txtDyn' id='txt'" + i + " value='Female'/>Female");
                }
                $('.dyn').append("<input type='submit'  class='btn btn- primary btn- lg' name='submit' id='txt'" + i + " value='submit' /><br>");
            });

            $('.sel').change(function () {
                var radioValue = $(this).val();
                $('.dyn').empty();
                for (var i = 0; i < radioValue; i++) {
                    $('.dyn').append("<input class='form-control' type='text' name='txtDyn' id='txt'" + i + " placeholder='fullname'/><br>");
                    $('.dyn').append("<input class='form-control' type='text' name='txtDyn' id='txt'" + i + " placeholder='Age'/><br>");
                    $('.dyn').append("<input type='radio' name='txtDyn' id='txt'" + i + " value='Male'/>Male");
                    $('.dyn').append("<input type='radio' name='txtDyn' id='txt'" + i + " value='Female'/>Female");
                }
                $('.dyn').append("<input type='submit'  class='btn btn- primary btn- lg' name='submit' id='txt'" + i + " value='submit' /><br>");
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .modalBackground {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }

        .modalPopup {
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
        BackgroundCssClass="modalBackground" TargetControlID="LinkButton1" CancelControlID="btnClose">
    </ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" Style="display: none">
        <div class="form-group form-group-select-plus" id="popup">
            <input type="hidden" id="hidVal" runat="server" />
            <h3>Persons</h3>
            <div class="btn-group btn-group-select-num per" data-toggle="buttons" onclick="">
                <label class="btn btn-primary active lbl" id="1">
                    <input type="radio" name="options" class="rdb" value="1" />1
                </label>
                <label class="btn btn-primary lbl" id="2">
                    <input type="radio" name="options" class="rdb" value="2" />2</label>
                <label class="btn btn-primary lbl" id="3">
                    <input type="radio" name="options" class="rdb" value="3" />3</label>
                <label class="btn btn-primary lbl" id="4">
                    <input type="radio" name="options" class="rdb" value="4" />4</label>
                <label class="btn btn-primary lbl" id="5">
                    <input type="radio" name="options" class="rdb" value="4+" />4+</label>
            </div>

            <select class="form-control hidden sel" name="sel">
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">3</option>
                <option value="4">4</option>
                <option value="5" selected="selected">5</option>
                <option value="6">6</option>
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
                <option value="10">10</option>
                <option value="11">11</option>
                <option value="12">12</option>
                <option value="13">13</option>
                <option value="14">14</option>
            </select>
        </div>
        <asp:Button ID="btnClose" runat="server" Text="Close" />

    </asp:Panel>

    <div class="container">
        <div class="row">

            <div class="col-md-8">
               <div class="dyn tab-pane">
               </div>
            </div>

        </div>
    </div>


</asp:Content>
