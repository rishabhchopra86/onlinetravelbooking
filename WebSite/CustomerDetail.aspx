<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDetail.aspx.cs" Inherits="WebSite.CustomerDetail" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE HTML>
<html>


<!-- Mirrored from remtsoy.com/tf_templates/traveler/demo_v1_7/feature-forms.html by HTTrack Website Copier/3.x [XR&CO'2014], Tue, 30 Jan 2018 06:18:09 GMT -->
<head runat="server">
    <title>Traveler - Form Elements</title>


    <meta content="text/html;charset=utf-8" http-equiv="Content-Type">
    <meta name="keywords" content="Template, html, premium, themeforest" />
    <meta name="description" content="Traveler - Premium template for travel companies">
    <meta name="author" content="Tsoy">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <!-- GOOGLE FONTS -->
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400italic,400,300,600' rel='stylesheet' type='text/css'>
    <!-- /GOOGLE FONTS -->
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/font-awesome.css">
    <link rel="stylesheet" href="css/icomoon.css">
    <link rel="stylesheet" href="css/styles.css">
    <link rel="stylesheet" href="css/mystyles.css">
    <script src="js/modernizr.js"></script>

    <link rel="stylesheet" href="css/switcher.css" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/bright-turquoise.css" title="bright-turquoise" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/turkish-rose.css" title="turkish-rose" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/salem.css" title="salem" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/hippie-blue.css" title="hippie-blue" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/mandy.css" title="mandy" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/green-smoke.css" title="green-smoke" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/horizon.css" title="horizon" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/cerise.css" title="cerise" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/brick-red.css" title="brick-red" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/de-york.css" title="de-york" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/shamrock.css" title="shamrock" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/studio.css" title="studio" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/leather.css" title="leather" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/denim.css" title="denim" media="all" />
    <link rel="alternate stylesheet" type="text/css" href="css/schemes/scarlet.css" title="scarlet" media="all" />
</head>
<body>
     <header id="main-header">
            <div class="header-top">
                <div class="container">
                    <div class="row">
                        <div class="col-md-3">
                            <a class="logo" href="index-2.html">
                                <img src="img/logo-invert.png" alt="Image Alternative text" title="Image Title" />
                            </a>
                        </div>
                        <div class="col-md-3 col-md-offset-2">
                            <form class="main-header-search">
                                <div class="form-group form-group-icon-left">
                                    <i class="fa fa-search input-icon"></i>
                                    <input type="text" class="form-control">
                                </div>
                            </form>
                        </div>
                        <div class="col-md-4">
                            <div class="top-user-area clearfix">
                                <ul class="top-user-area-list list list-horizontal list-border">
                                    <li class="top-user-area-avatar">
                                        <a href="user-profile.html">
                                            <img class="origin round" src="img/amaze_40x40.jpg" alt="Image Alternative text" title="AMaze" />Hi, John</a>
                                    </li>
                                    <li><a href="#">Sign Out</a>
                                    </li>
                                    <li class="nav-drop"><a href="#">USD $<i class="fa fa-angle-down"></i><i class="fa fa-angle-up"></i></a>
                                        <ul class="list nav-drop-menu">
                                            <li><a href="#">EUR<span class="right">€</span></a>
                                            </li>
                                            <li><a href="#">GBP<span class="right">£</span></a>
                                            </li>
                                            <li><a href="#">JPY<span class="right">円</span></a>
                                            </li>
                                            <li><a href="#">CAD<span class="right">$</span></a>
                                            </li>
                                            <li><a href="#">AUD<span class="right">A$</span></a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li class="top-user-area-lang nav-drop">
                                        <a href="#">
                                            <img src="img/flags/32/uk.png" alt="Image Alternative text" title="Image Title" />ENG<i class="fa fa-angle-down"></i><i class="fa fa-angle-up"></i>
                                        </a>
                                        <ul class="list nav-drop-menu">
                                            <li>
                                                <a title="German" href="#">
                                                    <img src="img/flags/32/de.png" alt="Image Alternative text" title="Image Title" /><span class="right">GER</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a title="Japanise" href="#">
                                                    <img src="img/flags/32/jp.png" alt="Image Alternative text" title="Image Title" /><span class="right">JAP</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a title="Italian" href="#">
                                                    <img src="img/flags/32/it.png" alt="Image Alternative text" title="Image Title" /><span class="right">ITA</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a title="French" href="#">
                                                    <img src="img/flags/32/fr.png" alt="Image Alternative text" title="Image Title" /><span class="right">FRE</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a title="Russian" href="#">
                                                    <img src="img/flags/32/ru.png" alt="Image Alternative text" title="Image Title" /><span class="right">RUS</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a title="Korean" href="#">
                                                    <img src="img/flags/32/kr.png" alt="Image Alternative text" title="Image Title" /><span class="right">KOR</span>
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
        </header>
    <form id="form1" runat="server">
        
  
        <div>
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
                                     <textarea id="address" runat="server" Class="form-control" rows="2"></textarea>
                                </div>
                                 <div class="form-group ">
                                    <label>City</label>
                                    <asp:TextBox ID="City" runat="server" CssClass="form-control"></asp:TextBox>
                                    
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
                                     <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" BehaviorID="ExpireDate_CalendarExtender" TargetControlID="ExpireDate">
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
           <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </form>

   
</body>
     <script src="js/jquery.js"></script>
        <script src="js/bootstrap.js"></script>
        <script src="js/slimmenu.js"></script>
        <script src="js/bootstrap-datepicker.js"></script>
        <script src="js/bootstrap-timepicker.js"></script>
        <script src="js/nicescroll.js"></script>
        <script src="js/dropit.js"></script>
        <script src="js/ionrangeslider.js"></script>
        <script src="js/icheck.js"></script>
        <script src="js/fotorama.js"></script>
        <script src="https://maps.googleapis.com/maps/api/js?v=3.exp&amp;sensor=false"></script>
        <script src="js/typeahead.js"></script>
        <script src="js/card-payment.js"></script>
        <script src="js/magnific.js"></script>
        <script src="js/owl-carousel.js"></script>
        <script src="js/fitvids.js"></script>
        <script src="js/tweet.js"></script>
        <script src="js/countdown.js"></script>
        <script src="js/gridrotator.js"></script>
        <script src="js/custom.js"></script>
        <script src="js/switcher.js"></script>
     <script>
         document.getElementById("passowrdDetail").style.display = "none";
          function next() {
             document.getElementById("basicDetail").style.display = "none";
             document.getElementById("passowrdDetail").style.display = "block";
         }
     </script>
</html>
