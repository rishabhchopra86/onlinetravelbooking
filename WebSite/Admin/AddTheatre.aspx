<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AddTheatre.aspx.cs" Inherits="Admin_AddTheatre" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .checked {
    color: orange;
}
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="app-content content container-fluid">
      <div class="content-wrapper">
        <div class="content-header row">
          <div class="content-header-left col-md-6 col-xs-12">
          <%--  <h2 class="content-header-title mb-0">Add Theatres</h2>--%>
                  
                  <button type="submit" class="btn btn-primary" style="background-color:#1B0B05">
	                               <strong> View Theatre List</strong>
	                            </button>                 
                                  
           
          </div>

          <div class="content-header-right col-md-6 col-xs-12">
            <div class="media width-250 float-xs-right">
           
            </div>
          </div>
       
        </div><br />
        <div class="content-body"><!-- Basic form layout section start -->
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
	                    		<h5 class="form-section"><i class="icon-head"></i> Theatre Info</h5>
			                    <div class="form-group row">
	                            	<label class="col-md-3 label-control" for="projectinput1">Theatre Name</label>
		                            <div class="col-md-9">
		                            	<input type="text" id="projectinput1" class="form-control" placeholder="First Name" name="fname">
		                            </div>
		                        </div>

                                <div class="form-group row">
									<label class="col-md-3 label-control" for="projectinput9">Address</label>
									<div class="col-md-9">
										<textarea id="projectinput9" rows="5" class="form-control" name="comment" placeholder="Address"></textarea>
									</div>
								</div>

                                 <div class="form-group row">
		                        	<label class="col-md-3 label-control" for="projectinput6">City</label>
		                        	<div class="col-md-9">
			                            <select id="projectinput6" name="interested" class="form-control">
			                                <option value="none" selected="" disabled="">--City--</option>
			                                <option value="design">Surat</option>
			                                <option value="development">Bangalore</option>
			                                <option value="illustration">Bhopal</option>
			                                <option value="branding">Kanpur</option>
			                                <option value="video">Gandhinagar</option>
			                            </select>
		                            </div>
		                        </div>

		                        <div class="form-group row">
	                            	<label class="col-md-3 label-control" for="projectinput2">Latitude</label>
									<div class="col-md-9">
	                            		<input type="text" id="projectinput2" class="form-control" placeholder="Latitude" name="lname">
	                            	</div>
		                        </div>

                                  <div class="form-group row">
	                            	<label class="col-md-3 label-control" for="projectinput2">Longitude</label>
									<div class="col-md-9">
	                            		<input type="text" id="projectinput2" class="form-control" placeholder="Longitude" name="lname">
	                            	</div>
		                        </div>

		                        <div class="form-group row">
		                            <label class="col-md-3 label-control" for="projectinput3">E-mail</label>
		                            <div class="col-md-9">
		                            	<input type="text" id="projectinput3" class="form-control" placeholder="E-mail" name="email">
		                            </div>
		                        </div>

                                  <div class="form-group row">
									<label class="col-md-3 label-control" for="projectinput9">Theatre Description</label>
									<div class="col-md-9">
										<textarea id="projectinput9" rows="5" class="form-control" name="comment" placeholder="Description"></textarea>
									</div>
								</div>

                                 <div class="form-group row">
									<label class="col-md-3 label-control" for="projectinput9">Theatre Ratings</label>
									<div class="col-md-9">
										                            
                                                                        <span class="fa fa-star checked"></span>
                                                                        <span class="fa fa-star checked"></span>
                                                                        <span class="fa fa-star checked"></span>
                                                                        <span class="fa fa-star"></span>
                                                                        <span class="fa fa-star"></span>
									</div>
								</div>

 



		                        <div class="form-group row">
		                            <label class="col-md-3 label-control" for="projectinput4">Phone Number</label>
		                            <div class="col-md-9">
		                            	<input type="text" id="projectinput4" class="form-control" placeholder="Phone Number" name="phone">
		                            </div>
		                        </div>

							
							</div>

	                        <div class="form-actions">
	                            <button type="button" class="btn btn-warning mr-1">
	                            	<i class="icon-cross2"></i> Cancel
	                            </button>
	                            <button type="submit" class="btn btn-primary">
	                                <i class="icon-check2"></i> Save
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

