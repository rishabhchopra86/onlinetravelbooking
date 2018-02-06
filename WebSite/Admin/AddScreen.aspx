<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AddScreen.aspx.cs" Inherits="Admin_AddScreen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="app-content content container-fluid">
        <div class="content-wrapper">
            <div class="content-header row">
                <div class="content-header-left col-md-6 col-xs-12">
                    <%--  <h2 class="content-header-title mb-0">Add Theatres</h2>--%>

                    <button type="submit" class="btn btn-black">
                        <strong>View Screen List</strong>
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
                                                <h5 class="form-section"><i class="icon-film"></i>Screen Info</h5>
                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput1">Cinema</label>
                                                    <div class="col-md-9">
                                                            <select id="projectinput6" name="interested" class="form-control">
                                                                <option value="none" selected="" disabled="">--Select Cinema's--</option>
                                                                <option value="design">PVR</option>
                                                                <option value="development">Valentine</option>
                                                            </select>
                                                    </div>
                                                </div>

                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">Screen Name</label>
                                                    <div class="col-md-9">
                                                        <input type="text" id="projectinput2" class="form-control" placeholder="Add Screen" name="lname">
                                                    </div>
                                                </div>

                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput6">Total Seat</label>
                                                    <div class="col-md-9">
                                                        <div>
                                                            <input type="text" id="projectinput2" class="form-control" placeholder="Total Seats" name="lname">
                                                        </div>
                                                    </div>
                                                </div>


                                                <div class="form-group row">
                                                    <label class="col-md-3 label-control" for="projectinput2">Screen Design</label>
                                                    <div class="col-md-9">
                                                        <input type="text" id="projectinput2" class="form-control" placeholder="Screen Design" name="lname">
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
