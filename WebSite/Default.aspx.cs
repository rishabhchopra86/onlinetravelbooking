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

        protected void flightsearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("flightsearch.aspx");
        }
    }
}