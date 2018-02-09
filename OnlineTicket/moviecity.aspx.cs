using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;
using System.Data.SqlTypes;

namespace WebSite
{
    public partial class moviecity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Mid;
            if (string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                Response.Redirect("~/movies.aspx");
            }
            else
            {
                String id = Request.QueryString["Id"].ToString();
                Mid = Convert.ToInt32(id.Substring(id.IndexOf(@"_") + 1));
                MovieBL moviebl = new MovieBL();
                moviebl.Id = Mid;
                Movie movie = new Movie();
                movie = moviebl.GetByMovieId();
                movieName.InnerText = movie.Name;
                movieType.InnerText = moviebl.typeName((int)movie.MovieType);
                movieLanguage.InnerText = moviebl.typeName((int)movie.MovieLanguage);
                movieDuration.InnerText = movie.Duration.ToString();
                ScreenMovieBL screenmoviebl = new ScreenMovieBL();
                List<ScreenMovie> screnmovie= screenmoviebl.getScreenMovieByMovieId(Mid);
                var dates = screnmovie.Select(i=>i.Date).Distinct().ToList();
                int cnt = 1;
                ImageBL img = new ImageBL();
                List<DataModel.Image> imagespath = img.getAllByTypeIdRtc(53, Mid);
                foreach (var imagepath in imagespath)
                {
                    movieimage.InnerHtml += "<img src='" + imagepath.Path + "' alt='Image Not Found' title='" + imagepath.Description + "' />";
                }
                CinemaBL cinemabl = new CinemaBL();
                string ampm;
                string disable="";
                foreach (var s in dates)
                {

                    if (cnt == 1)
                    {
                        myTab1.InnerHtml += " <li class='active'><a href='#tab-1" + cnt + "' data-toggle='tab'><i class='fa fa-calendar'></i>" + s.Value.ToString("d-MMM") + "</li></a>";
                        tabs.InnerHtml += "  <div class='tab-pane fade in active' id='tab-1" + cnt + "'>  ";
                    }
                    else
                    {
                        myTab1.InnerHtml += " <li><a href='#tab-1" + cnt + "' data-toggle='tab'><i class='fa fa-calendar'></i>" + s.Value.ToString("d-MMM") + "</li></a>";
                        tabs.InnerHtml += "  <div class='tab-pane fade in ' id='tab-1" + cnt + "'>  ";
                    }
                        var cinemasId = screnmovie.FindAll(i => i.Date == s.Value).Select(i => i.CinemaId).Distinct().ToList();
                        foreach (var cinema in cinemasId)
                        {
                            tabs.InnerHtml += "   <div class='col-md-12'>" +
                            "                                             <div class='gap'></div>" +
                            "                                         <div class='col-md-4'><span class='fa fa-heart-o'></span> "+ cinemabl.getCinemaNameByid(cinema.Value) + "</div>" +
                            "                                           <div class='col-md-8'>";
                            var shows = screnmovie.FindAll(i => i.CinemaId == cinema.Value && i.Date == s.Value).ToList();
                            foreach (var show in shows)
                            {
                            disable = "";
                            ampm = (show.AM_PM == true) ? "AM" : "Pm";
                            if (DateTime.Now.Date.ToString() == s.Value.Date.ToString())
                            {
                                DateTime d = DateTime.Parse(show.StartTime.ToString() + ampm);
                                disable = (DateTime.Compare(d, DateTime.Now) > 0) ? "" : " disabled='disabled' ";
                            }
                            tabs.InnerHtml += "                                               <div class='col-md-2'>" +
                            "                                                   <a href = 'movieseats.aspx?id=movieseats_"+show.Id+ "' " + disable + " class='btn btn-default' data-toggle='tooltip' data-html='true' title='Avaiable : " + show.AvailableSeat+" seats'>" +
                            "                                                    "+show.StartTime.Value.Hours+":"+ show.StartTime.Value.Minutes + " "+ ampm + "</a>" +
                            "                                                   </div>";
                            }
                           tabs.InnerHtml += "                                           </div>";
                            tabs.InnerHtml += "                                        </div>";
                        }
                        
                           tabs.InnerHtml +="</div>";
                    cnt++;
                
                
                   
                }


            }
        }
    }
}