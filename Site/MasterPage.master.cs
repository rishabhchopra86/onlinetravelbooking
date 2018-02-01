using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //userlogin.InnerText = "Sign Out";
        //userlogin.HRef = "Logout.aspx";
       // user.Visible = false;
        if (!string.IsNullOrEmpty(Session["id"] as string))
        {
            userlogin.InnerText = "Sign Out";
            userlogin.HRef = "Logout.aspx";
        }
        else
        {
            user.Visible = false;
        }
    }
}
