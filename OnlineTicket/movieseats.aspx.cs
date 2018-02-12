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
    public partial class movieseats : System.Web.UI.Page
    {
       static int Mid;
        ScreenMovieBL screenmoviebl;
        MovieBL moviebl;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Request.QueryString["id"]) )
            {
                Response.Redirect("~/movies.aspx");
            }
            else
            {
                if (Response.Cookies["redirect"].Value != null)
                {
                    Response.Redirect(Response.Cookies["redirect"].Value);
                }
                if (!IsPostBack)
                {
                    String id = Request.QueryString["Id"].ToString();
                   
                    Mid = Convert.ToInt32(id.Substring(id.IndexOf(@"_") + 1));
                    screenmoviebl = new ScreenMovieBL();
                    screenmoviebl.Id = Mid;
                    ScreenMovie screenmovie = screenmoviebl.GetByScreenMovieid();
                    moviebl = new MovieBL();
                    moviebl.Id = (int)screenmovie.MovieId;
                    moviename.InnerText = moviebl.GetByMovieId().Name;
                    string ampm = (screenmovie.AM_PM == true) ? "Am" : "PM";
                    time.InnerText = screenmovie.StartTime.Value.Hours + ":" + screenmovie.StartTime.Value.Minutes + " " + ampm;
                    date.InnerText = screenmovie.Date.Value.ToShortDateString();
                }
            }
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            Response.Cookies["screenId"].Value = Mid.ToString();
            Response.Redirect("~/Payment.aspx");

        }
    }
}