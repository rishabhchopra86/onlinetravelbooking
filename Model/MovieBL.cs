using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class MovieBL : Movie
    {
        OnlineTicketBookingEntities obj;
        public MovieBL()
        {
            obj = new OnlineTicketBookingEntities();
        }
        #region CRUD
        public void AddMovie(Movie movie)
        {
            obj.Movies.Add(movie);
            obj.SaveChanges();
        }

        public void UpdateMovie()
        {
            obj.SaveChanges();
        }

        public void DeleteMovie()
        {
            //Movie movie = obj.Movies.Where(m => m.Id == this.Id).FirstOrDefault();
            //movie.IsActive = IsActive;
            obj.SaveChanges();
        }

        public List<Movie> GetAllMovie()
        {
            List<Movie> movielst = new List<Movie>();
            movielst = obj.Movies.ToList();
            return movielst;
        }
        #endregion
        #region Filtering
        public Movie GetByMovieId()
        {
            Movie movie = new Movie();
            movie = obj.Movies.Where(m => m.Id == this.Id).FirstOrDefault();
            return movie;
        }
        #endregion
        public string getAllMovieByCityIdDisplay(int Id, string cityName,string movieName)
        {
            List<Movie> lst = new List<Movie>();
            if (Id == 0)
            {
                if (movieName == "") {
                    lst = obj.Movies.ToList(); }
                else
                    lst = obj.Movies.Where(i=>i.Name==movieName).ToList();
            }
            else
            {
                
                lst = obj.Movies.Where(i => i.Id == Id).ToList();
            }

            string displaymovies = "";
            Rating r = new Rating();
            if (lst == null)
            {
                displaymovies += "<div class='col-md-3'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='#'>" +
                        "                                        <img src = 'img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";

                displaymovies += "                                    </ul>" +
                           "                                    <h5 class='thumb-title'><a class='text-darken' href='#'>No Data Found</a></h5>" +

                           "                                </div>" +
                           "                            </div>" +
                           "                        </div>";
            }
            else
            {
                foreach (Movie c in lst)
                {
                    displaymovies += "<div class='col-md-3'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='moviecity.aspx?Id=movi_" + c.Id + "'>" +
                        "                                        <img src = 'img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";
                    if (c.TotalRatings == null)
                    {
                        displaymovies += r.rate(0);
                    }
                    else
                    {
                        displaymovies += r.rate((double)c.TotalRatings);
                    }

                    displaymovies += "                                    </ul>" +
                               "                                    <h5 class='thumb-title'><a class='text-darken'  href='moviecity.aspx?Id=movi_" + c.Id + "'>" + c.Name + "</a></h5>" +
                                "                                  <p class='mb0'><small><i class='fa fa-clock'></i> " + c.Duration + "</small>" +
                               "                                    </p>" +
                               "                                   <p class='mb0'><small>Language : " + typeName((int) c.MovieLanguage) + "  | Type : " + typeName((int)c.MovieType) + "</small>" +
                               "                                    </p>" +
                               "                                </div>" +
                               "                            </div>" +
                               "                        </div>";
                }
            }
            return displaymovies;
        }
        public string getAllMovieByCityIdDisplayFilter(int Id, string cityName, string movieName,List<int> filterLang, List<int> filterType)
        {
            List<Movie> lst = new List<Movie>();
            if (Id == 0)
            {
             
                if (movieName == "")
                {
                    if (!filterLang.Any())
                    {
                        lst = obj.Movies.ToList();
                    }
                    else
                    {
                        foreach(int fi in filterLang)
                        {
                            if (!filterType.Any())
                            {

                                var fliterlist = obj.Movies.Where(i => i.MovieLanguage == fi).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }

                            }
                            else
                            {
                                foreach (int ti in filterType)
                                {
                                    var fliterlist = obj.Movies.Where(i => i.MovieLanguage == fi && i.MovieType==ti).ToList();
                                    foreach (Movie m in fliterlist)
                                    {
                                        lst.Add(m);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                    lst = obj.Movies.Where(i => i.Name == movieName).ToList();
            }
            else
            {

                lst = obj.Movies.Where(i => i.Id == Id).ToList();
            }

            string displaymovies = "";
            Rating r = new Rating();
            if (lst == null)
            {
                displaymovies += "<div class='col-md-3'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='#'>" +
                        "                                        <img src = 'img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";

                displaymovies += "                                    </ul>" +
                           "                                    <h5 class='thumb-title'><a class='text-darken' href='#'>No Data Found</a></h5>" +

                           "                                </div>" +
                           "                            </div>" +
                           "                        </div>";
            }
            else
            {
                foreach (Movie c in lst)
                {
                    displaymovies += "<div class='col-md-3'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='moviecity.aspx?Id=movi_" + c.Id + "'>" +
                        "                                        <img src = 'img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";
                    if (c.TotalRatings == null)
                    {
                        displaymovies += r.rate(0);
                    }
                    else
                    {
                        displaymovies += r.rate((double)c.TotalRatings);
                    }

                    displaymovies += "                                    </ul>" +
                               "                                    <h5 class='thumb-title'><a class='text-darken'  href='moviecity.aspx?Id=movi_" + c.Id + "'>" + c.Name + "</a></h5>" +
                                "                                  <p class='mb0'><small><i class='fa fa-clock'></i> " + c.Duration + "</small>" +
                               "                                    </p>" +
                               "                                   <p class='mb0'><small>Language : " + typeName((int)c.MovieLanguage) + "  | Type : " + typeName((int)c.MovieType) + "</small>" +
                               "                                    </p>" +
                               "                                </div>" +
                               "                            </div>" +
                               "                        </div>";
                }
            }
            return displaymovies;
        }
        public string typeName(int id)
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                var query = obj.MasterValues.Where(i => i.Id == id).FirstOrDefault();
                return query.Description;
            }
        }
        public int typeid(string name)
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                var query = obj.MasterValues.Where(i => i.Description == name).FirstOrDefault();
                return query.Id;
            }
        }
    }
}
