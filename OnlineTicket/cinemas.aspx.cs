using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataModel;
namespace WebSite
{
    public partial class cinemas : System.Web.UI.Page
    {
        CinemaBL cinemabl;
        protected void Page_Load(object sender, EventArgs e)
        {
            cinemabl = new CinemaBL();
            if (!IsPostBack)
            {
                CityBL city = new CityBL();
              
                DropDownList1.DataValueField = "CityName";
                DropDownList1.DataTextField = "Id";
                DropDownList1.DataSource = city.GetallCitiesbyCountry(101);
                DropDownList1.DataBind();
                display.InnerHtml = cinemabl.getAllCinemasByCityIdDisplay(0, "");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CityBL cities = new CityBL();
            cityname.InnerText = city.Value;
            
            display.InnerHtml = cinemabl.getAllCinemasByCityIdDisplay(cities.getCityId(city.Value),city.Value);
        }
       
    }
}