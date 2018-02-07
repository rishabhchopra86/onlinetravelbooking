using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;
namespace WebSite
{
    public partial class cinemasdetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                Response.Redirect("~/cinemas.aspx");
            }
            else
            {
                String id = Request.QueryString["Id"].ToString();
              
                CinemaBL cinemasbl = new CinemaBL();
                cinemasbl.Id = Convert.ToInt32(id.Substring(id.IndexOf(@"_") + 1));
                Cinema cinema = new Cinema();
                cinema=cinemasbl.getByid();
                cinemaAddress.InnerText = cinema.Address;
                cinemaemail.HRef = cinema.Email;
                cinemaName.InnerText = cinema.Name;
                cinemaPhone.InnerText = cinema.PhoneNo;
                
            }
       }
    }
}