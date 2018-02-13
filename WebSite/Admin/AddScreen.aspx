<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="AddScreen.aspx.cs" Inherits="WebSite.Admin.AddScreen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .modal-dialog {
            height: 90%; /* = 90% of the .modal-backdrop block = %90 of the screen */
        }

        .modal-content {
            height: 100%; /* = 100% of the .modal-dialog block */
        }

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                                        <div class="form-body">
                                            <h5 class="form-section"><i class="icon-film"></i>Screen Info</h5>
                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="projectinput6">Cinema Name</label>
                                                <div class="col-md-9">
                                                    <asp:DropDownList ID="dpCinemaName" CssClass="form-control" runat="server"></asp:DropDownList>
                                                </div>
                                            </div>

                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="projectinput6">Screen name</label>
                                                <div class="col-md-9">
                                                    <div>
                                                        <%--  <input type="text" runat="server" id="txttotalseat" class="form-control" placeholder="Total Seats" name="totseat"/>--%>
                                                        <asp:TextBox ID="txtScreenName" runat="server" class="form-control" placeholder="Screen Name"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>


                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="projectinput6">Total Seat</label>
                                                <div class="col-md-9">
                                                    <div>
                                                        <%--  <input type="text" runat="server" id="txttotalseat" class="form-control" placeholder="Total Seats" name="totseat"/>--%>
                                                        <asp:TextBox ID="txtTotalSeats" runat="server" class="form-control" placeholder="Total Seats"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <%--<div id="accordionWrapa1" role="tablist" aria-multiselectable="true">
                                                <div class="card">
                                                    <div id="heading1" class="card-header">
                                                        <a data-toggle="collapse" data-parent="#accordionWrapa1" href="#accordion1" aria-expanded="true" aria-controls="accordion1" class="card-title lead">Accordion Group Item #1</a>
                                                    </div>
                                                    <div id="accordion1" role="tabpanel" aria-labelledby="heading1" class="card-collapse collapse in" aria-expanded="true">
                                                        <div class="card-body">
                                                            <div class="card-block">
                                                                Caramels dessert chocolate cake pastry jujubes bonbon. Jelly wafer jelly beans. Caramels chocolate cake liquorice cake wafer jelly beans croissant apple pie. Oat cake brownie pudding jelly beans. Wafer liquorice chocolate bar chocolate bar liquorice. Tootsie roll gingerbread gingerbread chocolate bar tart chupa chups sugar plum toffee. Carrot cake macaroon sweet danish. Cupcake soufflé toffee marzipan candy canes pie jelly-o. Cotton candy bonbon powder topping carrot cake cookie caramels lemon drops liquorice. Dessert cookie ice cream toffee apple pie.
						
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>--%>

                                            <div class="form-group row">
                                                <label class="col-md-3 label-control" for="projectinput6">Arrange Seat Design</label>
                                                <div class="col-md-3">
                                                    <div>
                                                        <%--  <input type="text" runat="server" id="txttotalseat" class="form-control" placeholder="Total Seats" name="totseat"/>--%>
                                                        <asp:TextBox ID="txtNoOfRows" runat="server" class="form-control" placeholder="No of Rows"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-3">
                                                    <div>
                                                        <%--  <input type="text" runat="server" id="txttotalseat" class="form-control" placeholder="Total Seats" name="totseat"/>--%>
                                                        <asp:TextBox ID="txtNoofColumns" runat="server" class="form-control" placeholder="No Of Columns"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <%--  <label class="col-md-3 label-control" for="projectinput2">Screen Design</label>--%>
                                                <div class="col-md-3">
                                                    <div class="card-body collapse in">


                                                        <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary " data-toggle="modal" data-target="#default"> Add Screen Design</asp:LinkButton>

                                                        <div class="modal fade text-xs-left" id="default" tabindex="-1" role="dialog" aria-labelledby="myModalLabel16" aria-hidden="true">
                                                            <div class="modal-dialog modal-xl" role="document">
                                                                <div class="modal-content">
                                                                    <div class="">
                                                                       <%-- <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                                            <span aria-hidden="true">&times;</span>
                                                                        </button>--%>
                                                                    <%--    <br /><br /><br />--%><br />
                                                                        <%--	<h4 class="modal-title" id="myModalLabel16">Basic Modal</h4>--%>

                                                                        <center> <div style="border:1px solid grey;border-radius:10px;height:150px;width:30%;text-align:center">Screen this way<hr /></div></center><br /><br />

                                                                          <center> <div style="border:1px solid grey;border-radius:10px;height:300px;width:50%;text-align:center"></div></center><br /><br />

                                                                    </div>
                                                                    <div class="modal-body">


                                                                    </div>
                                                                    <div class="modal-footer">
                                                                        <button type="button" class="btn grey btn-outline-secondary" data-dismiss="modal">Close</button>
                                                                        <button type="button" class="btn btn-outline-primary">Save changes</button>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>


                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            </div>

                            <div class="form-actions">
                                <button type="button" class="btn btn-warning mr-1" id="btncancel">
                                    <i class="icon-cross2"></i>Cancel
                                </button>
                                <asp:LinkButton ID="btnSaveScreen" runat="server" CssClass="btn btn-primary" OnClick="btnSaveScreen_Click">
                                                     <i class="icon-check2"></i> Save

                                </asp:LinkButton>

                            </div>
                        </div>
                    </div>

                         
                </section>
                <!-- // Basic form layout section end -->
            </div>
        </div>
    </div>
   


</asp:Content>


