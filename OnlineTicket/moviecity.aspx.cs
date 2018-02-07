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
    public partial class moviecity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                Response.Redirect("~/movies.aspx");
            }
            else
            {
                String id = Request.QueryString["Id"].ToString();
                
                MovieBL moviebl = new MovieBL();
                moviebl.Id = Convert.ToInt32(id.Substring(id.IndexOf(@"_") + 1));
                Movie movie = new Movie();
                movie = moviebl.GetByMovieId();
                movieName.InnerText = movie.Name;
                movieType.InnerText = moviebl.typeName((int)movie.MovieType);
                movieLanguage.InnerText = moviebl.typeName((int)movie.MovieLanguage);
                movieDuration.InnerText = movie.Duration.ToString();
            }
        }
    }
}