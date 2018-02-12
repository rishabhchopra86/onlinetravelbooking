using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;
namespace OnlineTicket
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScreenMovieBL screenmoviebl = new ScreenMovieBL();
            try
            {
                screenmoviebl.Id = Convert.ToInt32(Request.Cookies["screenId"].Value);
                int Personno = Convert.ToInt32(Request.Cookies["noOfPerson"].Value);
                ScreenMovie screnmovie = screenmoviebl.GetByScreenMovieid();
                MovieBL moviename = new MovieBL();
                moviename.Id =(int) screnmovie.MovieId;
                MovieName.InnerText = moviename.GetByMovieId().Name;
                MovieName.HRef= "/moviecity.aspx?Id=" + moviename.GetByMovieId().Id;
                personno.InnerText = Personno.ToString();
                Rating r = new Rating();
               // rate.InnerText = r.rate((double)moviename.TotalRatings);
                int peramt = 0;
                perpersonamt.InnerText = peramt.ToString();
                totalamt.InnerText = (Personno * peramt).ToString();
                date.InnerText = screnmovie.Date.Value.ToShortDateString();
            }
            catch(Exception ex)
            {
                if (Response.Cookies["redirect"].Value != null)
                {
                    string redirect = Response.Cookies["redirect"].Value;

                    Response.Cookies["redirect"].Value = "";
                    Response.Redirect(redirect);
                }
                else
                {
                    Response.Redirect("~/movies.aspx");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["screenId"].Value = "";
            Request.Cookies["noOfPerson"].Value = "";
            Response.Redirect("~/SuccessPayment.aspx");

        }
    }
}