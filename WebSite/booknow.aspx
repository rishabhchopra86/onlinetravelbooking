<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="booknow.aspx.cs" Inherits="WebSite.booknow" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/jquery.js"></script>
    <script src="js/easyAutoComplete-min.js"></script>
    <script src="js/easyAutoComplete.js"></script>
    <script>
        $(document).ready(function () {
            $('#popup .per .lbl ').change(function () {
             var q = GetParameterValues('q');
               alert(q);
                if (q == "hotel")
                {
                   var radioValue = $("input[name='options']:checked").val();
                    $('.dyn').empty();
                    for (var i = 0; i < radioValue; i++) {
                        $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality" /></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');
                      
                    }

                    $('.sel').change(function () {
                        var selectedvalue = $(this).val();
                        $('.dyn').empty();
                        for (var i = 0; i < selectedvalue; i++) {
                            $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality"/></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');
                        }

                    });
                }
                if (q == "flights")
                {
                    alert(q);
                    var radioValue = $("input[name='options']:checked").val();
                    $('.dyn').empty();
                    for (var i = 0; i < radioValue; i++) {
                        $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality"/></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');

                    }

                    $('.sel').change(function () {
                        var selectedvalue = $(this).val();
                        $('.dyn').empty();
                        for (var i = 0; i < selectedvalue; i++) {
                            $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality"/></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');
                        }

                    });
                }
                if (q == "train") {
                    var radioValue = $("input[name='options']:checked").val();
                    $('.dyn').empty();
                    for (var i = 0; i < radioValue; i++) {
                        $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality"/></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');

                    }

                    $('.sel').change(function () {
                        var selectedvalue = $(this).val();
                        $('.dyn').empty();
                        for (var i = 0; i < selectedvalue; i++) {
                            $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2 nationality" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality"/></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');
                        }

                    });
                }
                if (q == "bus") {
                    var radioValue = $("input[name='options']:checked").val();
                    $('.dyn').empty();
                    for (var i = 0; i < radioValue; i++) {
                        $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality"/></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');

                    }

                    $('.sel').change(function () {
                        var selectedvalue = $(this).val();
                        $('.dyn').empty();
                        for (var i = 0; i < selectedvalue; i++) {
                            $(".dyn").append('<div style="border:1px solid orange;margin:10px;" class="col-md-12 box "><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Full Name" type="text" /></div ><div  class="form-group form-group-lg  col-md-2"><span style="margin-left:10px"></span><input class="form-control" placeholder="Age" type="text" /></div ><div  class="form-group form-group-lg  col-md-2" style="margin-top:35px;"><input type="radio" name="txtDyn" id="txt"' + i + '" value="Male" />Male <input type="radio" name="txtDyn" id="txt"' + i + '" value="Female"/>Female</div><div  class="form-group form-group-lg  col-md-2" style="margin-left:0px;"><span style="margin-left:10px"></span><select class="form-control col-md-2"><option>---Select Any---</option><option>Adult</option><option>Child</option><option>Senior Citizen</option></select></div><div  class="form-group form-group-lg  col-md-3"><span style="margin-left:10px"></span><input class="typeahead form-control col-md-2" type="text" name="txtDyn" id="txt"' + i + '" placeholder="Nationality"/></div><div class="col-md-1"><p style="margin-top:35px"><i class="fa fa-trash" style="font-size:28px;color:red"></i></span></div></div> ');
                        }

                    });
                }
           });
        });
        function GetParameterValues(param) {
            var url = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < url.length; i++) {
                var urlparam = url[i].split('=');
                if (urlparam[0] == param) {
                    return urlparam[1];
                }
            }
        }

        //var options = {
        //    url: "json/Nationality.json",
        //    getValue: "nationality",
        //      list: {
        //        match: {
        //            enabled: true
        //        }
        //    },

        //    theme: "plate-dark"
        //};
        //alert(options);
        //debugger;
        //$(".nationality").easyAutocomplete(options);
        //alert(options);

        //$(document).ready(function () {
        //    $("#search-box").keyup(function () {
        //        $.ajax({
        //            type: "POST",
        //            url: "json/Nationality.json",
        //            data: 'keyword=' + $(this).val(),
        //            beforeSend: function () {
        //                $("#search-box").css("background", "#FFF url(LoaderIcon.gif) no-repeat 165px");
        //            },
        //            success: function (data) {
        //                $("#suggesstion-box").show();
        //                $("#suggesstion-box").html(data);
        //                $("#search-box").css("background", "#FFF");
        //            }
        //        });
        //    });
        //});
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
        .btnlink
        {
            margin-left:700px;
        }
    </style>

 <br />   <asp:LinkButton ID="LinkButton1"  runat="server" CssClass="btnlink">Change Person</asp:LinkButton>
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
            
                <div class="dyn tab-pane">
                   
                </div>
           
        </div>
    </div>

</asp:Content>
