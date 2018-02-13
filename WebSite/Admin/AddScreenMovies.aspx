<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="AddScreenMovies.aspx.cs" Inherits="WebSite.Admin.AddScreenMovies" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/jquery.js"></script>
    <script type="text/javascript">


        function showMessage(message, messagetype) {
            debugger;
            var cssclass;
            switch (messagetype) {
                case 'Success':
                    cssclass = 'alert-success'
                    break;
                case 'Error':
                    cssclass = 'alert-danger'
                    break;
                case 'Warning':
                    cssclass = 'alert-warning'
                    break;
                default:
                    cssclass = 'alert-info'
            }
            $('#alert_container').append('<div id="alert_div" style="margin: 0 0.5%;width:250px; -webkit-box-shadow: 3px 4px 6px #999;" class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
            setTimeout(function () {
                $("#alert_div").remove();
            }, 5000);
        }

        $(document).ready(function () {
            $("#addData").hide();
            $("#dispGrid").click(function () {
                $("#addData").hide();
                $("#gridData").show();

            });

            $("#dispAdd").click(function () {
                $("#gridData").hide();
                $("#addData").show();
            });

            $("#AddButtonRate").click(function () {
                $("#gridData").hide();
            });
        });


    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="app-content content container-fluid">
        <div class="content-wrapper">
            <div class="content-header row">
                <div class="content-header-left col-md-6 col-xs-12">
                    <%--  <h2 class="content-header-title mb-0">Add Theatres</h2>--%>

                    <button type="button" id="dispGrid" class="btn btn-black">
                        <strong>View Screen Movie List</strong>
                    </button>

                    <button type="button" id="dispAdd" class="btn btn-black">
                        <strong>Add Screen Movie</strong>
                    </button>

                </div>
                <div class="content-header-right col-md-6 col-xs-12">
                    <div class="media width-250 float-xs-right">
                    </div>
                </div>

            </div>
            <br />
            <div class="content-body">

                <!-- Basic form layout section start -->
                <section id="horizontal-form-layouts">

                    <div class="row">
                        <div class="col-md-12">
                            <div class="card">
                                <div class="card-header">
                                    <%--  <h4 class="card-title" id="horz-layout-basic">Project Info</h4>--%>
                                    <a class="heading-elements-toggle"><i class="icon-ellipsis font-medium-3"></i></a>
                                    <div class="heading-elements">
                                        <ul class="list-inline mb-0">
                                            <li><a data-action="collapse"><i class="icon-minus4"></i></a></li>
                                            <li><a data-action="reload"><i class="icon-reload"></i></a></li>
                                            <li><a data-action="expand"><i class="icon-expand2"></i></a></li>
                                            <li><a data-action="close"><i class="icon-cross2"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="card-body collapse in" id="addData">

                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>

                                            <div class="card-block" id="">

                                                <div class="form-body row">
                                                    <h5 class="form-section"><i class="icon-film"></i>Screen Movie Info</h5>
                                                    <div class="form-group col-sm-6">
                                                        <label class="col-md-3 label-control" for="ddlmovies">Cinemas</label>
                                                        <div class="col-md-9">
                                                            <asp:DropDownList ID="ddlCinemas" class="form-control" runat="server"></asp:DropDownList>
                                                        </div>
                                                    </div>

                                                    <div class="form-group col-sm-6">
                                                        <label class="col-md-3 label-control" for="ddlmovies">Movies</label>
                                                        <div class="col-md-9">
                                                            <asp:DropDownList ID="ddlmovies" class="form-control" runat="server"></asp:DropDownList>
                                                        </div>
                                                    </div>

                                                    <div class="form-group  col-sm-6">
                                                        <label class="col-md-3 label-control" for="ddlscreen">Screen</label>
                                                        <div class="col-md-9">
                                                            <asp:DropDownList ID="ddlscreen" CssClass="form-control" runat="server"></asp:DropDownList>
                                                        </div>
                                                    </div>

                                                    <div class="form-group col-sm-6">
                                                        <label class="col-md-3 label-control" for="txtMovieDate">Date</label>
                                                        <div class="col-md-9">
                                                            <div class="input-group">
                                                                <span class="input-group-addon"><i class="icon-calendar3"></i></span>
                                                                <asp:TextBox CssClass="form-control" runat="server" ID="txtMovieDate"></asp:TextBox>
                                                                <ajax:CalendarExtender ID="Calendarextender1" runat="server" CssClass="cal_Theme1" TargetControlID="txtMovieDate" Animated="true" DefaultView="Days" Format="MM/dd/yyyy"></ajax:CalendarExtender>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="form-group col-sm-6">
                                                        <label class="col-md-3 label-control" for="txtStartTime">Start Time</label>
                                                        <div class="col-md-9">
                                                            <div class="input-group">
                                                                <asp:TextBox ID="txtStartTime" CssClass="form-control" runat="server" placeholder="hh:mm:ss (eg:12:45:12)" />
                                                                <ajax:MaskedEditExtender ID="MaskedEditExtender3" runat="server"
                                                                    TargetControlID="txtStartTime"
                                                                    Mask="99:99:99"
                                                                    MessageValidatorTip="true"
                                                                    OnFocusCssClass="MaskedEditFocus"
                                                                    OnInvalidCssClass="MaskedEditError"
                                                                    MaskType="Time"
                                                                    AcceptAMPM="True"
                                                                    ErrorTooltipEnabled="True" />
                                                                <br />
                                                                <em><span style="font-size: 8pt">Tip: Type 'A' or 'P' to switch AM/PM</span></em>
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>


                                                    <div class="form-group col-sm-6">
                                                        <label class="col-md-3 label-control" for="txtEndTime">End Time</label>
                                                        <div class="col-md-9">
                                                            <div class="input-group">
                                                                <asp:TextBox ID="txtEndTime" CssClass="form-control" runat="server" placeholder="hh:mm:ss (eg:12:45:12)" />
                                                                <ajax:MaskedEditExtender ID="MaskedEditExtender1" runat="server"
                                                                    TargetControlID="txtEndTime"
                                                                    Mask="99:99:99"
                                                                    MessageValidatorTip="true"
                                                                    OnFocusCssClass="MaskedEditFocus"
                                                                    OnInvalidCssClass="MaskedEditError"
                                                                    MaskType="Time"
                                                                    AcceptAMPM="True"
                                                                    ErrorTooltipEnabled="True" />
                                                                <br />
                                                                <em><span style="font-size: 8pt">Tip: Type 'A' or 'P' to switch AM/PM</span></em>
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="form-group col-sm-6">
                                                        <label class="col-md-3 label-control" for="txtAvailableSeat">Available Seat</label>
                                                        <div class="col-md-9">
                                                            <div class="input-group">
                                                                <asp:TextBox CssClass="form-control" runat="server" ID="txtAvailableSeat"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="form-group col-sm-6">
                                                        <label class="col-md-3 label-control" for="projectinput6">2D/3D</label>
                                                        <div class="col-md-9">
                                                            <div class="input-group custom-radio">
                                                                <asp:RadioButton CssClass="custom-radio" Checked="true" GroupName="dimension" runat="server" Text="2D" ID="rdb2d"></asp:RadioButton>
                                                                <br />
                                                                <asp:RadioButton CssClass="custom-radio" GroupName="dimension" runat="server" Text="3D" ID="rdb3d"></asp:RadioButton>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="form-group col-sm-12">

                                                        <div class="col-md-3">
                                                            <label class="label-control" for="ddlmovies">Fare Type</label>
                                                            <asp:DropDownList ID="ddlScreenFare" class="form-control" runat="server"></asp:DropDownList>
                                                        </div>
                                                        <div class="col-md-3">
                                                            <label class="label-control" for="txtAvailableSeat">Rate</label>
                                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtRate" pattern="^[0-9]$"></asp:TextBox>
                                                        </div>

                                                        <div class="col-md-2">
                                                            <label class="label-control" for="txtAvailableSeat">Add More Fare For this Screen</label>
                                                            <asp:LinkButton ID="AddButtonRate" CssClass="btn btn-danger" runat="server" OnClick="AddButtonRate_Click"><i class="icon-plus" style="font-size:20px;"></i></asp:LinkButton>
                                                        </div>


                                                    </div>

                                                    <div id="FareRate" class="form-group col-sm-6" runat="server">
                                                    </div>


                                                </div>

                                                <div class="form-actions">
                                                    <button type="button" class="btn btn-warning mr-1">
                                                        <i class="icon-cross2"></i>Cancel
                                                    </button>
                                                    <asp:LinkButton ID="btn_save" runat="server" CssClass="btn btn-primary" OnClick="btn_save_Click">   <i class="icon-check"></i>Save</asp:LinkButton>

                                                </div>
                                                <div class="messagealert" id="alert_container">
                                                </div>
                                            </div>




                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>

                                <div class="card-body collapse in" id="gridData">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>

                                            <div class="card-block">
                                                <div class="form-body">
                                                    <h5 class="form-section"><i class="icon-film"></i>Screen Movie Info</h5>
                                                    <asp:TextBox ID="TextBox1" CssClass="col-sm-2" runat="server"></asp:TextBox>
                                                    <br /><br />
                                                    <asp:GridView Width="100%" CssClass="table table-responsive" ID="GreedScreenMovie" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowDataBound="GreedScreenMovie_RowDataBound" OnRowDeleting="GreedScreenMovie_RowDeleting" OnRowUpdating="GreedScreenMovie_RowUpdating" OnRowEditing="GreedScreenMovie_RowEditing" OnPageIndexChanging="GreedScreenMovie_PageIndexChanging" OnRowCancelingEdit="GreedScreenMovie_RowCancelingEdit" AllowPaging="true" OnDataBound="GreedScreenMovie_DataBound" AllowSorting="true" OnSorting="GreedScreenMovie_Sorting1">
                                                        <Columns>
                                                            <asp:TemplateField>
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="btn_delete" runat="server" CssClass="btn btn-danger btn-sm" CommandName="Delete"><i class="icon-remove"></i></asp:LinkButton>
                                                                    <asp:LinkButton ID="btn_Edit" CssClass="btn btn-success btn-sm" runat="server" CommandName="Edit"><i class="icon-edit"></i></asp:LinkButton>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:LinkButton ID="btn_Update" runat="server" CommandName="Update" CssClass="btn btn-info btn-sm"><i class="icon-save"></i></asp:LinkButton>
                                                                    <asp:LinkButton ID="btn_Cancel" runat="server" CommandName="Cancel" CssClass="btn btn-danger btn-sm"><i class="icon-remove"></i></asp:LinkButton>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>

                                                            <asp:TemplateField HeaderText="Cinemas" SortExpression="CinemaName">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" Text='<%#Eval("CinemaName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:DropDownList ID="updateCinemaName" CssClass="form-control" runat="server"></asp:DropDownList>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Movies" SortExpression="MovieName">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" Text='<%#Eval("MovieName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:DropDownList ID="updateMovieName" CssClass="form-control" runat="server"></asp:DropDownList>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Screens" SortExpression="ScreenName">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" Text='<%#Eval("ScreenName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:DropDownList ID="updateScreenName" CssClass="form-control" runat="server"></asp:DropDownList>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Total Seats" SortExpression="AvailableSeat">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" Text='<%#Eval("AvailableSeat") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="updateAvlblSeat" CssClass="form-control" runat="server" Text='<%#Eval("AvailableSeat") %>'></asp:TextBox>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Date" SortExpression="Date">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" Text='<%#Eval("Date") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtDate" CssClass="form-control" runat="server" Text='<%#Convert.ToDateTime(Eval("Date")).Date %>'></asp:TextBox>
                                                                    <ajax:CalendarExtender runat="server" ID="UpdateCalExt" CssClass="cal_Theme1" TargetControlID="txtDate" Animated="true" DefaultView="Days" Format="MM/dd/yyyy"></ajax:CalendarExtender>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Start Time" SortExpression="StartTime">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" Text='<%#Eval("StartTime") %>'></asp:Label>

                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="UpdatetxtStartTime" CssClass="form-control" runat="server" Text='<%#Eval("StartTime") %>'></asp:TextBox>
                                                                    <ajax:MaskedEditExtender ID="maskStartTime" runat="server"
                                                                        TargetControlID="UpdatetxtStartTime"
                                                                        Mask="99:99:99"
                                                                        MessageValidatorTip="true"
                                                                        OnFocusCssClass="MaskedEditFocus"
                                                                        OnInvalidCssClass="MaskedEditError"
                                                                        MaskType="Time"
                                                                        AcceptAMPM="True"
                                                                        ErrorTooltipEnabled="True" />
                                                                    <br />
                                                                    <em><span style="font-size: 8pt">Tip: Type 'A' or 'P' to switch AM/PM</span></em>
                                                                    <br />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Start Time" SortExpression="EndTime">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" Text='<%#Eval("EndTime") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="UpdatetxtEndTime" CssClass="form-control" runat="server" Text='<%#Eval("EndTime") %>'></asp:TextBox>
                                                                    <ajax:MaskedEditExtender ID="maskEndTime" runat="server"
                                                                        TargetControlID="UpdatetxtEndTime"
                                                                        Mask="99:99:99"
                                                                        MessageValidatorTip="true"
                                                                        OnFocusCssClass="MaskedEditFocus"
                                                                        OnInvalidCssClass="MaskedEditError"
                                                                        MaskType="Time"
                                                                        AcceptAMPM="True"
                                                                        ErrorTooltipEnabled="True" />
                                                                    <br />
                                                                    <em><span style="font-size: 8pt">Tip: Type 'A' or 'P' to switch AM/PM</span></em>
                                                                    <br />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="2D/3D">
                                                                <ItemTemplate>
                                                                    <asp:HiddenField ID="H2d3d" runat="server" Value='<%#Eval("C2D3D") %>'></asp:HiddenField>
                                                                    <asp:RadioButton CssClass="custom-radio" GroupName="dimension" runat="server" Text="2D" ID="rdb2d"></asp:RadioButton>
                                                                    <br />
                                                                    <asp:RadioButton CssClass="custom-radio" GroupName="dimension" runat="server" Text="3D" ID="rdb3d"></asp:RadioButton>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:HiddenField ID="UH2d3d" runat="server" Value='<%#Eval("C2D3D") %>'></asp:HiddenField>
                                                                    <asp:RadioButton CssClass="custom-radio" GroupName="dimension" runat="server" Text="2D" ID="updaterdb2d"></asp:RadioButton>
                                                                    <br />
                                                                    <asp:RadioButton CssClass="custom-radio" GroupName="dimension" runat="server" Text="3D" ID="updaterdb3d"></asp:RadioButton>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="AM/PM">
                                                                <ItemTemplate>
                                                                    <asp:HiddenField ID="Hampm" runat="server" Value='<%#Eval("AM_PM") %>'></asp:HiddenField>
                                                                    <asp:RadioButton ID="chkAm" GroupName="ampm" runat="server" Text="AM"></asp:RadioButton>
                                                                    <asp:RadioButton ID="chkPm" GroupName="ampm" runat="server" Text="PM"></asp:RadioButton>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:HiddenField ID="Hampm1" runat="server" Value='<%#Eval("AM_PM") %>'></asp:HiddenField>
                                                                    <asp:RadioButton ID="UpchkAm" GroupName="uampm" runat="server" Text="AM"></asp:RadioButton>
                                                                    <asp:RadioButton ID="UpchkPm" runat="server" GroupName="uampm" Text="PM"></asp:RadioButton>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>

                                                        </Columns>
                                                    </asp:GridView>

                                                </div>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
                <!-- // Basic form layout section end -->
            </div>
        </div>
    </div>
  

   
</asp:Content>
