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
                ImageBL img = new ImageBL();
                List<DataModel.Image> imagespath = img.getAllByTypeIdRtc(53, cinemasbl.Id);
                foreach(var imagepath in imagespath)
                {
                    cinemaimage.InnerHtml += "<img src='"+imagepath.Path+ "' alt='Image Not Found' title='" + imagepath.Description + "' />";
                }
                ScreenMovieBL screenmoviebl = new ScreenMovieBL();
                int cnt = 1;
                string ampm;
                MovieBL moviebl = new MovieBL();
                List<ScreenMovie> screnmovie = screenmoviebl.getScreenMovieByCinemaId(cinemasbl.Id);
                var dates = screnmovie.Select(i => i.Date).Distinct().ToList();
                string disable="";
                foreach (var s in dates)
                {

                    if (cnt == 1)
                    {
                        myTab1.InnerHtml += " <li class='active'><a href='#tab-1" + cnt + "' data-toggle='tab'><i class='fa fa-calendar'></i>" + s.Value.ToString("d-MMM") + "</li></a>";
                        cinemadatedetail.InnerHtml += "  <div class='tab-pane fade in active' id='tab-1" + cnt + "'>  ";
                    }
                    else
                    {
                        myTab1.InnerHtml += " <li><a href='#tab-1" + cnt + "' data-toggle='tab'><i class='fa fa-calendar'></i>" + s.Value.ToString("d-MMM") + "</li></a>";
                        cinemadatedetail.InnerHtml += "  <div class='tab-pane fade in ' id='tab-1" + cnt + "'>  ";
                    }
                    var MoviesId = screnmovie.FindAll(i => i.Date == s.Value).Select(i => i.MovieId).Distinct().ToList();
                    foreach (var movie in MoviesId)
                    {
                        cinemadatedetail.InnerHtml += "   <div class='col-md-12'>" +
                        "                                             <div class='gap'></div>" +
                        "                                         <div class='col-md-4'><span class='fa fa-film'></span>"+ moviebl .GetMovieNameById(movie.Value)+ "</div>" +
                        "                                           <div class='col-md-8'>";
                        var shows = screnmovie.FindAll(i => i.MovieId == movie.Value && i.Date == s.Value).ToList();
                        foreach (var show in shows)
                        {
                            disable = "";
                            ampm = (show.AM_PM == true) ? "AM" : "Pm";
                            if (DateTime.Now.Date.ToString() == s.Value.Date.ToString())
                            {
                                DateTime d = DateTime.Parse(show.StartTime.ToString()+ ampm);
                                disable = (DateTime.Compare(d , DateTime.Now)>0)?"": " disabled='disabled' ";
                            }
                           
                            cinemadatedetail.InnerHtml += "                                               <div class='col-md-2'>" +
                        "                                                   <a href = 'movieseats.aspx?id=movieseats_" + show.Id + "' "+disable+" class='btn btn-default'  data-toggle='tooltip' data-html='true' title='Avaiable : " + show.AvailableSeat + " seats'>" +
                        "                                                   " + show.StartTime.Value.Hours + ":" + show.StartTime.Value.Minutes + " " + ampm + "</a>" +
                        "                                                   </div>";
                        }
                        cinemadatedetail.InnerHtml += "                                           </div>";
                        cinemadatedetail.InnerHtml += "                                        </div>";
                    }

                    cinemadatedetail.InnerHtml += "</div>";
                    cnt++;



                }
            }
       }
    }
}