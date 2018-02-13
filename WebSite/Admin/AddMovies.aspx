<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="AddMovies.aspx.cs" Inherits="WebSite.Admin.AddMovies" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="app-content content container-fluid">
        <div class="content-wrapper">
            <div class="content-header row">
                <div class="content-header-left col-md-6 col-xs-12">
                    <%--  <h2 class="content-header-title mb-0">Add Theatres</h2>--%>

                    <button type="submit" class="btn btn-black">
                        <strong>View Movie List</strong>
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


                                        <div class="form-body">
                                            <h5 class="form-section"><i class="icon-head"></i>Movie Info</h5>
                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="txtMovieName">Movie Name</label>
                                                <div class="col-md-9">
                                                    <%--   <input type="text" id="txtMovieName" class="form-control" placeholder="Movie Name" />--%>
                                                    <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Movie Name"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="txtDesc">Description</label>
                                                <div class="col-md-9">
                                                    <%--  <textarea id="txtDesc" rows="5" class="form-control" name="comment" placeholder="Description"></textarea>--%>
                                                    <textarea id="txtDescription" cols="20" rows="2" class="form-control" placeholder="Description" runat="server"></textarea>

                                                </div>
                                            </div>

                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="projectinput6">Language</label>
                                                <div class="col-md-9">
                                                    <asp:DropDownList ID="dpLanguage" CssClass="form-control" runat="server"></asp:DropDownList>
                                                </div>
                                            </div>




                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="projectinput2">Movie Durations</label>
                                                <div class="col-md-9">
                                                    <asp:TextBox ID="txtDuration" runat="server" CssClass="form-control" placeholder="hh:mm:ss (eg:12:45:12)"></asp:TextBox>
                                                    <%--  <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server"
                                                                TargetControlID="txtDuration"
                                                                Mask="99:99:99"
                                                                MessageValidatorTip="true"
                                                                OnFocusCssClass="MaskedEditFocus"
                                                                OnInvalidCssClass="MaskedEditError"
                                                                MaskType="Time"
                                                                AcceptAMPM="True"
                                                                ErrorTooltipEnabled="True" />--%>
                                                    <ajaxToolkit:MaskedEditExtender ID="mskMovieDuration" runat="server"
                                                        TargetControlID="txtDuration"
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


                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="projectinput6">Movie Type</label>
                                                <div class="col-md-9">
                                                    <asp:DropDownList ID="dpMovieType" CssClass="form-control" runat="server"></asp:DropDownList>
                                                </div>
                                            </div>


                                        </div>

                                        <div class="form-actions">
                                            <button type="button" class="btn btn-warning mr-1">
                                                <i class="icon-cross2"></i>Cancel
                                            </button>
                                            <%--  <button type="submit" class="btn btn-primary" onclick="" runat="server" id="btnSaveMovie">
                                                    <i class="icon-check2"></i>Save
                                                </button>--%>
                                            <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary" OnClick="LinkButton1_Click"> <i class="icon-check2"></i>Save</asp:LinkButton>
                                        </div>

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
