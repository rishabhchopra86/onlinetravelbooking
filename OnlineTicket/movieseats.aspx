<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="movieseats.aspx.cs" Inherits="WebSite.movieseats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <link rel="stylesheet" href="css/seatstyle.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a class="popup-text" href="#search-dialog" data-effect="mfp-zoom-out" style="display:none" >Change search</a>
           <div class="mfp-with-anim mfp-hide mfp-move-from-top mfp-dialog mfp-search-dialog" id="search-dialog">
                <h3>Number Of person</h3>
         
                    <div class="tabbable">
                       
                        <div class="tab-content">
                            <div class="tab-pane fade in active" id="flight-search-1">
                             
                                <div class="input-daterange" data-date-format="MM d, D">
                                    <div class="row">
                                       
                                        <div class="col-md-6">
                                            <div class="form-group form-group-lg ">
                                                <label>Person</label>
                                              
                                                <select class="form-control " id="person" runat="server" onchange="persons(this)">
                                                       <option value="">Select number of Seats</option>
                                                    <option  value="1">1</option>
                                                    <option  value="2">2</option>
                                                    <option  value="3">3</option>
                                                    <option  value="4">4</option>
                                                    <option  value="5">5</option>
                                                    <option  value="6" >6</option>
                                                    <option  value="7">7</option>
                                                    <option  value="8">8</option>
                                                    <option  value="9">9</option>
                                                    <option  value="10">10</option>
                                                    <option  value="11">11</option>
                                                    <option  value="12">12</option>
                                                    <option  value="13">13</option>
                                                    <option  value="14">14</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <img src="" class="img img-responsive" id="iconpix" style="height:100px;width:100px;display:none"  />
                                        </div>
                                    </div>
                                </div>
                            </div>
                         
                        </div>
                    </div>
                  
            </div>
    <div class="container">
      <div class="gap"></div>

        <div class="col-md-12">  <h1 >
            <span id="moviename" runat="server"></span>
            At 
             <span id="time" runat="server"></span>
            On
             <span id="date" runat="server"></span>
        </h1>
             <div class="col-md-6">
        <h3>
            Number of Person :-  <span id="personno" runat="server" ></span>   <small><a class="popup-text" href="#search-dialog" data-effect="mfp-zoom-out"  > Change Person</a></small>
        </h3></div>
        <div class="col-md-6">
            
            
        
        </div>
             <div class="col-md-12">
             <h6 class="pull-right">
                 <asp:Button ID="Button1" runat="server" Text="Proceed" CssClass="btn btn-primary" /></h6>
                 </div>
            </div>
        <div class="gap"></div>
        <div class="row">
            <div class="col-md-12">
                <div class="plane">
  <div class="cockpit">
    <h5>All EYES THIS WAY PLEASE</h5>
  </div>
  <div class="exit exit--front fuselage">
    
  </div>

  <ol class="cabin fuselage">
       <li class="row--0">
                              <ol class="seats" type="A">
                                         <li class="seat">
                                             <input type="checkbox" id="chk_1" name="1"  data-content="200" />
                                           <label for="chk_1" id="1" data-toggle='tooltip' data-placement='top' data-original-title="RS 200" onclick="select(this);">1</label>
                                         </li>
                                      
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="2" disabled="" name="2" onchange="select(this);" />
                                                                                 <label for="2">2</label>
                                                                               </li>
                                                                            
                                         <li class="seat">
                                           <input type="checkbox" id="chk_3" name="3" />
                                           <label for="chk_3" id="3" onclick="select(this);">3</label>
                                         </li>
                                      
                                                                               
                                         <li class="seat">
                                           <input type="checkbox" id="chk_4" name="4" />
                                           <label for="chk_4" id="4" onclick="select(this);">4</label>
                                         </li>
                                      
                                         <li class="seat">

                                           <span for=""></span>
                                         </li>
                                      
                                         <li class="seat">

                                           <span for=""></span>
                                         </li>
                                      
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="chk_5" disabled="" name="7"  onchange="select(this);" />
                                                                                 <label for="chk_5" onchange="select(this);" id="5">5</label>
                                                                               </li>
                                                                            
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="6" disabled="" name="8" onchange="select(this);"/>
                                                                                 <label for="6" onchange="select(this);" >6</label>
                                                                               </li>
                                                                            
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="7" disabled="" name="9">
                                                                                 <label for="7">7</label>
                                                                               </li>
                                                                            
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="8" disabled="" name="10">
                                                                                 <label for="8">8</label>
                                                                               </li>
                                                                                </ol> </li>   <li class="row--1">
                              <ol class="seats" type="A">
                                         <li class="seat">
                                           <input type="checkbox" id="9" name="11">
                                           <label for="9">9</label>
                                         </li>
                                      
                                         <li class="seat">
                                           <input type="checkbox" id="10" name="12">
                                           <label for="10">10</label>
                                         </li>
                                      
                                         <li class="seat">
                                           <input type="checkbox" id="11" name="13">
                                           <label for="11">11</label>
                                         </li>
                                      
                                         <li class="seat">
                                           <input type="checkbox" id="12" name="14">
                                           <label for="12">12</label>
                                         </li>
                                      
                                         <li class="seat">

                                           <span for=""></span>
                                         </li>
                                      
                                         <li class="seat">

                                           <span for=""></span>
                                         </li>
                                      
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="13" disabled="" name="17">
                                                                                 <label for="13">13</label>
                                                                               </li>
                                                                            
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="14" disabled="" name="18">
                                                                                 <label for="14">14</label>
                                                                               </li>
                                                                            
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="15" disabled="" name="19">
                                                                                 <label for="15">15</label>
                                                                               </li>
                                                                            
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="16" disabled="" name="20">
                                                                                 <label for="16">16</label>
                                                                               </li>
                                                                                </ol> </li></ol></div>
            </div>
        </div>
    </div>
    <script>
        var selected=0;
        $(document).ready(function () {
            $(".popup-text").trigger('click');
        });
        function persons(value) {
            debugger;
            initialize();
            var val = value.options[value.selectedIndex].value;
            var iconpix = document.getElementById('iconpix');
            if (!val == "") {
                var perso = document.getElementById('<%= personno.ClientID %>');
                perso.innerText = val;
                selected = Number(perso.innerText);
               
                iconpix.setAttribute("style", "height:100px;width: 100px");
                var no = Number(val);
                if (no==1)
                    iconpix.src = "img/icon/bicycle.png";
                else if (no == 2)
                    iconpix.src = "img/icon/bike.png";
                else if (no == 3)
                    iconpix.src = "img/icon/auto.png";
                else if (no == 4)
                    iconpix.src = "img/icon/car.png";
                else if (no >= 5 && no<=8)
                    iconpix.src = "img/icon/car2.png";
                else 
                    iconpix.src = "img/icon/bus.png";
            }
            else {
                iconpix.setAttribute("style", "height:100px;width: 100px;display:none");
                iconpix.src = "";
                swal("Number of Person Should be More Than Zero");
            }
        }
        $(function () {
            $("[data-toggle='tooltip']").tooltip();
        });
        function select(val) {
            debugger;
            var perso = document.getElementById('chk_' + val.id);
            if (selected <= 0) {
                swal("Number of Person Exceeded");
                perso.checked = true;
                return false;
            }
         
            if (perso.checked) {
                selected+= 1;
            } else {
                selected-= 1;
            }
          

        }
    </script>
    
 

</asp:Content>
