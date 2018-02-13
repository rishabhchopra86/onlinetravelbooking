<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="AddTheatre.aspx.cs" Inherits="WebSite.Admin.AddTheatre" %>

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
                alert("Hello");
                $("#addData").hide();
                $("#gridData").show();

            });

            $("#dispAdd").click(function () {

                $("#gridData").hide();
                $("#addData").show();
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
                                            <div class="card-block">

                                                <div class="form-body">
                                                    <h5 class="form-section"><i class="icon-head"></i>Theatre Info</h5>
                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="projectinput1">Theatre Name</label>
                                                        <div class="col-md-9">
                                                            <input runat="server" type="text" required="required" id="txtTheatreName" class="form-control" placeholder="Theatre Name" />
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="txtAddress">Address</label>
                                                        <div class="col-md-9">
                                                            <textarea runat="server" id="txtAddress" rows="5" required="required" class="form-control" placeholder="Address"></textarea>
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="selCity">City</label>
                                                        <div class="col-md-9">
                                                            <asp:DropDownList ID="selCity" CssClass="form-control" runat="server"></asp:DropDownList>
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="selAgent">Agent</label>
                                                        <div class="col-md-9">
                                                            <asp:DropDownList ID="selAgent" CssClass="form-control" runat="server"></asp:DropDownList>
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="txtLattitude">Latitude</label>
                                                        <div class="col-md-9">
                                                            <input type="text" id="txtLattitude" runat="server" required="required" class="form-control" placeholder="Latitude" />
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="txtLongitude">Longitude</label>
                                                        <div class="col-md-9">
                                                            <input type="text" id="txtLongitude" runat="server" required="required" class="form-control" placeholder="Longitude" />
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="txtEmail">E-mail</label>
                                                        <div class="col-md-9">
                                                            <input type="email" id="txtEmail" runat="server" class="form-control" placeholder="E-mail" />
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="txtTheatreDesc">Theatre Description</label>
                                                        <div class="col-md-9">
                                                            <textarea id="txtTheatreDesc" required="required" runat="server" rows="5" class="form-control" placeholder="Description"></textarea>
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="txtPhoneNumber">Phone Number</label>
                                                        <div class="col-md-9">
                                                            <input type="text" id="txtPhoneNumber" runat="server" class="form-control" placeholder="Phone Number" />
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <label class="col-md-3 label-control" for="fileupload">Upload Theatre Logo</label>
                                                        <div class="col-md-9">
                                                            <asp:FileUpload ID="file" runat="server" class="form-control-file" />
                                                        </div>
                                                    </div>

                                                </div>

                                                <div class="form-actions">
                                                    <button type="button" class="btn btn-warning mr-1">
                                                        <i class="icon-cross2"></i>Cancel
                                                    </button>
                                                    <asp:LinkButton ID="btnSave" runat="server" CssClass="btn btn-primary" OnClick="btnSave_Click">	     
                                                <i class="icon-check"></i> Save
                                                    </asp:LinkButton>
                                                </div>
                                            </div>

                                            </div>
                                      
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
            <!-- // Basic form layout section end -->
        </div>
</asp:Content>
