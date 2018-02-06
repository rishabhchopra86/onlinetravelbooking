<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CustomerDetail.aspx.cs" Inherits="OnlineTicket.CustomerDetail" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="global-wrap">
              
              <div class="container">
            <h1 align="center">Customer Information</h1>
        </div>
             <div class="container">
            <div class="row">
                    <div class="col-md-12">
                    <div class="gap gap-small"></div>
                    <hr>
                   
                    <div class="row row-wrap" id="basicDetail" >
                        <div class="col-md-6">
                           
                            
                                <div class="form-group ">
                                    <label>First Name</label>
                                    <asp:TextBox ID="FisrstName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            <div class="form-group ">
                                    <label>Last Name</label>
                                    <asp:TextBox ID="LastName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                 <div class="form-group ">
                                    <label>Middle Name</label>
                                    <asp:TextBox ID="MiddleName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                 <div class="form-group ">
                                    <label>Date of Birth</label>
                                    <asp:TextBox ID="DOB" runat="server" CssClass="form-control"></asp:TextBox>
                                     <ajaxToolkit:CalendarExtender ID="DOB_CalendarExtender" runat="server" BehaviorID="DOB_CalendarExtender" TargetControlID="DOB">
                                     </ajaxToolkit:CalendarExtender>
                                </div>
                             <div class="form-group ">
                                    <label>Phone Number</label>
                                    <asp:TextBox ID="PhoneNumber" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                </div>
                        </div>
                         <div class="col-md-6">
                           
                            <div class="form-group ">
                                    <label>Alternate Number</label>
                                    <asp:TextBox ID="AlternateNumber" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                </div>
                              <div class="form-group ">
                                    <label>Fax</label>
                                    <asp:TextBox ID="Fax" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                 <div class="form-group ">
                                    <label>Address</label>
                                     <textarea id="address" runat="server" class="form-control" rows="2"></textarea>
                                </div>
                                 <div class="form-group ">
                                    <label>City</label>
                                     <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                                    <asp:TextBox ID="City" runat="server" CssClass="form-control" onfocusout="changecity(this.value)"></asp:TextBox>
                                    
                                </div>
                             <div class="form-group ">
                                    <label>Postal Code</label>
                                    <asp:TextBox ID="PostalCode" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            
                             
                        </div>
                        <div class="col-md-12"> 
                           
                           
                             <asp:Button ID="Button1" runat="server" Text="Next" CssClass="btn btn-primary pull-right"  OnClientClick="next(); return false;"/>
                                
                             
                           
                             
                             
                            
                        </div>
                    </div>
                     <div class="row row-wrap" id="passowrdDetail" >
                           <div class="col-md-6"> 
                               <div class="form-group ">
                                    <label>Nationality</label>
                                    <asp:TextBox ID="Nationality" runat="server" CssClass="form-control"></asp:TextBox>
                                    
                                </div>
                                    <div class="form-group ">
                                    <label>Passport Number</label>
                                    <asp:TextBox ID="PassportNumber" runat="server" CssClass="form-control"></asp:TextBox>
                                    
                                </div>
                               <div class="form-group ">
                                    <label>Profile Picture</label>
                                   <asp:FileUpload ID="ProfilePicture" runat="server"  CssClass="form-control" />
                                    
                                </div>
                                 </div>
                          <div class="col-md-6"> 
                                <div class="form-group ">
                                    <label>Passport Country</label>
                                    <asp:TextBox ID="PassportCountry" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                             
                                 <div class="form-group ">
                                    <label>Expire Date</label>
                                    <asp:TextBox ID="ExpireDate" runat="server" CssClass="form-control"></asp:TextBox>
                                     <ajaxToolkit:CalendarExtender ID="ExpireDate_CalendarExtender" runat="server" BehaviorID="ExpireDate_CalendarExtender" TargetControlID="ExpireDate">
                                     </ajaxToolkit:CalendarExtender>
                                </div>
                               </div>
                           <div class="col-md-12"> 
                          <asp:Button ID="submit" runat="server" Text="Submit" CssClass="btn btn-primary pull-right" OnClick="submit_Click"  />
                         </div>
                         
                   

                </div>
                </div>

             </div>
              </div>
        </div>
            <script>
         document.getElementById("passowrdDetail").style.display = "none";
          function next() {
             document.getElementById("basicDetail").style.display = "none";
             document.getElementById("passowrdDetail").style.display = "block";
         }
     </script>
      <script>
          var selectElement = document.getElementById('<%= DropDownList1.ClientID %>');
          selectToDatalist(selectElement);
          selectElement.setAttribute("style", "display:none");
          function selectToDatalist(select, placeholder) {
              debugger;
              var eSelect = select
                  , options = eSelect.children
                  , eInput = document.createElement("input")
                  , eDatalist = document.createElement("datalist")
                  , selected
                  ;
              debugger;
              for (var o in options) {
                  option = options[o];

                  if (!(option && option.value)) { continue; }

                  if (option.selected) {
                      selected = option.innerText;
                  }

                  eDatalist.appendChild(option.cloneNode());
              }

              eDatalist.id = "datalist-st";
             
              document.getElementById('<%= City.ClientID %>').setAttribute("list", eDatalist.id);
              eSelect.parentNode.appendChild(eDatalist);

            debugger;
            return eInput;
          }
          function changecity(value) {
             
              document.getElementById('<%= DropDownList1.ClientID %>').selected = value;
          }
    </script>
</asp:Content>
