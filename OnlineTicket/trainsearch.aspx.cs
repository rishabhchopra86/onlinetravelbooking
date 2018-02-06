using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class trainsearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                display.InnerHtml = "";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            display.InnerHtml += " <li>" +
                                "<div class='booking-item-container'>" +
                                   " <div class='booking-item'>" +
                                        "<div class='row'>" +
                                            "<div class='col-md-2'>" +
                                               " <div class='booking-item-airline-logo'>" +
                                                  "  <img src='img/croatia.jpg' alt='Image Alternative text' title='Image Title' />" +
                                                   " <p>Croatia Airlines</p>" +
                                               " </div>" +
                                           " </div>" +
                                           " <div class='col-md-5'>" +
                                                "<div class='booking-item-flight-details'>" +
                                                   " <div class='booking-item-departure'><i class='fa fa-train fa-2x'></i>" +
                                                       " <h5>10:25 PM</h5>" +
                                                      "  <p class='booking-item-date'>Sun, Mar 22</p>" +
                                                      "  <p class='booking-item-destination'>London, England, United Kingdom (LHR)</p>" +
                                                  "  </div>" +
                                                   " <div class='booking-item-arrival'><i class='fa fa-train fa-2x'></i>" +
                                                    "    <h5>12:25 PM</h5>" +
                                                        "<p class='booking-item-date'>Sat, Mar 23</p>" +
                                                      "  <p class='booking-item-destination'>New York, NY, United States (JFK)</p>" +
                                                   " </div>" +
                                                "</div>" +
                                          "  </div>" +
                                           " <div class='col-md-2'>" +
                                               " <h5>22h 50m</h5>" +
                                               " <p>1 stop</p>" +
                                          "  </div>" +
                                           " <div class='col-md-3'><span class='booking-item-price'>$485</span><span>/person</span>" +
                                              "  <p class='booking-item-flight-class'>Class: First</p><a class='btn btn-primary' href='#'>Select</a>" +
                                           " </div>" +
                                       " </div>" +
                                    "</div>" +
                                    "<div class='booking-item-details'>" +
                                       " <div class='row'>" +
                                            "<div class='col-md-8'>" +
                                               " <p>Flight Details</p>" +
                                               " <h5 class='list-title'>London (LHR) to Charlotte (CLT)</h5>" +
                                               " <ul class='list'>" +
                                                 "   <li>US Airways 731</li>" +
                                                   " <li>Economy / Coach Class ( M), AIRBUS INDUSTRIE A330-300</li>" +
                                                   " <li>Depart 09:55 Arrive 15:10</li>" +
                                                  "  <li>Duration: 9h 15m</li>" +
                                               " </ul>" +
                                              "  <h5>Stopover: Charlotte (CLT) 7h 1m</h5>" +
                                                "<h5 class='list-title'>Charlotte (CLT) to New York (JFK)</h5>" +
                                               " <ul class='list'>" +
                                                   " <li>US Airways 1873</li>" +
                                                   " <li>Economy / Coach Class ( M), Airbus A321</li>" +
                                                   " <li>Depart 22:11 Arrive 23:53</li>" +
                                                  "  <li>Duration: 1h 42m</li>" +
                                               " </ul>" +
                                              "  <p>Total trip time: 17h 58m</p>" +
                                           " </div>" +
                                       " </div>" +
                                  "  </div>" +
                               " </div>" +
                          "  </li>";
        }
    }

}