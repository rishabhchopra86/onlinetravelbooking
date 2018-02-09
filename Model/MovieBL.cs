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
        public string GetMovieNameById(int id)
        {
           
            var movie = obj.Movies.Where(m => m.Id == id).FirstOrDefault();
            return movie.Name;
        }
        public List<Movie> getAllMovieByCityIdDisplay(int Id, string cityName,string movieName)
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

            return lst;
        }
        public List<Movie> getAllMovieByCityIdDisplayFilter(int Id, string cityName, string movieName,List<int> filterLang, List<int> filterType)
        {
            List<Movie> lst = new List<Movie>();
            if (Id == 0)
            {
             
                if (movieName == "" || movieName==null)
                {
                    if (!filterLang.Any())
                    {
                        if (!filterType.Any())
                        {

                            var fliterlist = obj.Movies.ToList();
                            foreach (Movie m in fliterlist)
                            {
                                lst.Add(m);
                            }

                        }
                        else
                        {
                            foreach (int ti in filterType)
                            {
                                var fliterlist = obj.Movies.Where(i =>  i.MovieType == ti).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }
                            }
                        }
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
                {
                    if (!filterLang.Any())
                    {
                        if (!filterType.Any())
                        {

                            var fliterlist = obj.Movies.Where(i => i.Name == movieName).ToList();
                            foreach (Movie m in fliterlist)
                            {
                                lst.Add(m);
                            }

                        }
                        else
                        {
                            foreach (int ti in filterType)
                            {
                                var fliterlist = obj.Movies.Where(i => i.MovieType == ti && i.Name == movieName).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (int fi in filterLang)
                        {
                            if (!filterType.Any())
                            {

                                var fliterlist = obj.Movies.Where(i => i.MovieLanguage == fi && i.Name==movieName).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }

                            }
                            else
                            {
                                foreach (int ti in filterType)
                                {
                                    var fliterlist = obj.Movies.Where(i => i.MovieLanguage == fi && i.MovieType == ti && i.Name == movieName).ToList();
                                    foreach (Movie m in fliterlist)
                                    {
                                        lst.Add(m);
                                    }
                                }
                            }
                        }
                    }
                }
                   
            }
            else
            {

                lst = obj.Movies.Where(i => i.Id == Id).ToList();
            }

            return lst;
        }
        public List<Movie> getAllMovieByCityIdDisplayFilter(int Id, string cityName, string movieName, List<int> filterLang, List<int> filterType,List<Movie> movies)
        {
            List<Movie> lst = new List<Movie>();
            if (Id == 0)
            {

                if (movieName == "" || movieName == null)
                {
                    if (!filterLang.Any())
                    {
                        if (!filterType.Any())
                        {

                            var fliterlist = movies.ToList();
                            foreach (Movie m in fliterlist)
                            {
                                lst.Add(m);
                            }

                        }
                        else
                        {
                            foreach (int ti in filterType)
                            {
                                var fliterlist = movies.Where(i => i.MovieType == ti).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (int fi in filterLang)
                        {
                            if (!filterType.Any())
                            {

                                var fliterlist = movies.Where(i => i.MovieLanguage == fi).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }

                            }
                            else
                            {
                                foreach (int ti in filterType)
                                {
                                    var fliterlist = movies.Where(i => i.MovieLanguage == fi && i.MovieType == ti).ToList();
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
                {
                    if (!filterLang.Any())
                    {
                        if (!filterType.Any())
                        {

                            var fliterlist = movies.Where(i => i.Name == movieName).ToList();
                            foreach (Movie m in fliterlist)
                            {
                                lst.Add(m);
                            }

                        }
                        else
                        {
                            foreach (int ti in filterType)
                            {
                                var fliterlist = movies.Where(i => i.MovieType == ti && i.Name == movieName).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (int fi in filterLang)
                        {
                            if (!filterType.Any())
                            {

                                var fliterlist = movies.Where(i => i.MovieLanguage == fi && i.Name == movieName).ToList();
                                foreach (Movie m in fliterlist)
                                {
                                    lst.Add(m);
                                }

                            }
                            else
                            {
                                foreach (int ti in filterType)
                                {
                                    var fliterlist = movies.Where(i => i.MovieLanguage == fi && i.MovieType == ti && i.Name == movieName).ToList();
                                    foreach (Movie m in fliterlist)
                                    {
                                        lst.Add(m);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else
            {

                lst = obj.Movies.Where(i => i.Id == Id).ToList();
            }
            return lst;
         
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
