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
    }
}
