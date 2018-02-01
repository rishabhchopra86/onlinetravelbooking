using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterValueClass m = new MasterValueClass();
        m.AddMasterValue();
        //userlogin.InnerText = "Sign Out";
        //userlogin.HRef = "Logout.aspx";
       // user.Visible = false;
        if (!string.IsNullOrEmpty(Session["id"] as string))
        {
            //userlogi.InnerText = "Sign Out";
            //userlogi.HRef = "Logout.aspx";
        }
        else
        {
            //user.Visible = false;
        }
    }
}
