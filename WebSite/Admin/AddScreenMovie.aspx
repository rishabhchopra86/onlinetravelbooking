<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AddScreenMovie.aspx.cs" Inherits="Admin_AddScreenMovie" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="app-content content container-fluid">
        <div class="content-wrapper">
            <div class="content-header row">
                <div class="content-header-left col-md-6 col-xs-12">
                    <%--  <h2 class="content-header-title mb-0">Add Theatres</h2>--%>

                    <button type="submit" class="btn btn-black">
                        <strong>View Screen Movie List</strong>
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
                                <div class="card-body collapse in">
                                    <div class="card-block">

                                        <form class="form form-horizontal">
                                            <div class="form-body">
                                                <h5 class="form-section"><i class="icon-film"></i>Screen Movie Info</h5>
                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput1">Movies</label>
                                                    <div class="col-md-9">
                                                        <select id="projectinput6" name="interested" class="form-control">
                                                            <option value="none" selected="" disabled="">--Select Movies--</option>
                                                            <option value="design">Padmavati</option>
                                                            <option value="development">Mukkabaz</option>
                                                        </select>
                                                    </div>
                                                </div>

                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">Screen</label>
                                                    <div class="col-md-9">
                                                        <select id="projectinput6" name="interested" class="form-control">
                                                            <option value="none" selected="" disabled="">--Select Screen--</option>
                                                            <option value="design">Screen1</option>
                                                            <option value="development">Screen2</option>
                                                        </select>
                                                    </div>
                                                </div>

                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">Date</label>
                                                    <div class="col-md-9">
                                                        <div class="input-group">
                                                            <span class="input-group-addon"><i class="icon-calendar3"></i></span>
                                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtMovieDate"></asp:TextBox>
                                                            <ajax:CalendarExtender ID="Calendarextender1" runat="server" CssClass="cal_Theme1" TargetControlID="txtMovieDate" Animated="true" DefaultView="Days" Format="dd/MM/yyyy"></ajax:CalendarExtender>
                                                        </div>
                                                    </div>
                                                </div>


                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">Start Time</label>
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

                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">End Time</label>
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

                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">Available Seat</label>
                                                    <div class="col-md-9">
                                                        <div class="input-group">
                                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtAvailableSeat"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">2D/3D</label>
                                                    <div class="col-md-9">
                                                        <div class="input-group custom-radio">
                                                            <asp:RadioButton CssClass="custom-radio" Checked="true" GroupName="dimension" runat="server" Text="2D" ID="rdb2d"></asp:RadioButton>
                                                            <br />
                                                            <asp:RadioButton CssClass="custom-radio" GroupName="dimension" runat="server" Text="3D" ID="rdb3d"></asp:RadioButton>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>

                                            <div class="form-actions">
                                                <button type="button" class="btn btn-warning mr-1">
                                                    <i class="icon-cross2"></i>Cancel
                                                </button>
                                                <button type="submit" class="btn btn-primary">
                                                    <i class="icon-check2"></i>Save
                                                </button>
                                            </div>
                                        </form>
                                    </div>
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

