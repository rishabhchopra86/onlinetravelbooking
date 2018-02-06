<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="movieseats.aspx.cs" Inherits="WebSite.movieseats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js"></script>
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
                                              
                                                <select class="form-control " id="person" runat="server" onchange="persons(this.value)">
                                                    <option>1</option>
                                                    <option>2</option>
                                                    <option>3</option>
                                                    <option>4</option>
                                                    <option>5</option>
                                                    <option >6</option>
                                                    <option>7</option>
                                                    <option>8</option>
                                                    <option>9</option>
                                                    <option>10</option>
                                                    <option>11</option>
                                                    <option>12</option>
                                                    <option>13</option>
                                                    <option>14</option>
                                                </select>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                         
                        </div>
                    </div>
                  
            </div>
    <div class="container">
      <div class="col-md-12">
            <time datetime="2014-09-20" class="icon">
  <em>Saturday</em>
  <strong>September</strong>
  <span>20</span>
</time>
      </div>

        <div class="col-md-6">  <h1 >
            <span id="moviename" runat="server"></span>
            At 
             <span id="time" runat="server"></span>
        </h1>
        <h3>
            Number of Person :-  <span id="personno" ></span>   <small><a class="popup-text" href="#search-dialog" data-effect="mfp-zoom-out"  > Change Person</a></small>
        </h3></div>
        <div class="col-md-6">
             <div class="col-md-3">
            <h4 >Total :- <span id="totalamt" runat="server"></span></h4>
                 </div>
             <div class="col-md-6">
             <h6 class="pull-right">
                 <asp:Button ID="Button1" runat="server" Text="Proceed" CssClass="btn btn-primary" /></h6>
                 </div>
        </div>
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
                                           <input type="checkbox" id="1" name="1">
                                           <label for="1">1</label>
                                         </li>
                                      
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="2" disabled="" name="2">
                                                                                 <label for="2">2</label>
                                                                               </li>
                                                                            
                                         <li class="seat">
                                           <input type="checkbox" id="3" name="3">
                                           <label for="3">3</label>
                                         </li>
                                      
                                         <li class="seat">
                                           <input type="checkbox" id="4" name="4">
                                           <label for="4">4</label>
                                         </li>
                                      
                                         <li class="seat">

                                           <span for=""></span>
                                         </li>
                                      
                                         <li class="seat">

                                           <span for=""></span>
                                         </li>
                                      
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="5" disabled="" name="7">
                                                                                 <label for="5">5</label>
                                                                               </li>
                                                                            
                                                                               <li class="seat">
                                                                                 <input type="checkbox" id="6" disabled="" name="8">
                                                                                 <label for="6">6</label>
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
        $(document).ready(function () {
            $(".popup-text").trigger('click');
        });
        function persons(value) {
            personno.innerText = value;

        }
    </script>
</asp:Content>
