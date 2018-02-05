using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void hotelsearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("hotelsearch.aspx");
        }

        protected void searchflight_Click(object sender, EventArgs e)
        {
            Response.Redirect("flightsearch.aspx");
        }

        protected void trainsearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("trainsearch.aspx");
        }

        protected void searchbus_Click(object sender, EventArgs e)
        {
            Response.Redirect("bussearch.aspx");
        }

        protected void moviesearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("movies.aspx");
        }

      protected void packagesearch_Click1(object sender, EventArgs e)
        {
            Response.Redirect("packages.aspx");
        }
    }
}