using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Data.SqlTypes;

namespace Model
{
    public class ScreenMovieBL:ScreenMovie
    {
        OnlineTicketBookingEntities obj;
        public ScreenMovieBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddScreenMovie(ScreenMovie screen)
        {
            obj.ScreenMovies.Add(screen);
            obj.SaveChanges();
        }

        public void DeleteScreenMovie()
        {
            obj.SaveChanges();
        }

        public void UpdateScreenMovie()
        {
            obj.SaveChanges();
        }

        public List<ScreenMovie> GetAllScreenMovie()
        {
            List<ScreenMovie> ScreenList = new List<ScreenMovie>();
            ScreenList = obj.ScreenMovies.Where(s => s.IsActive == true).ToList();
            return ScreenList;
        }

        #endregion

        #region Filtring
        public ScreenMovie GetByScreenMovieid()
        {
            ScreenMovie screen = new ScreenMovie();
            screen = obj.ScreenMovies.FirstOrDefault(s=>s.Id==Id);
            return screen;
        }
        #endregion
        public List<ScreenMovie> getScreenMovieByMovieId(int Id)
        {
            var stringdate =  new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var screenmovie = obj.ScreenMovies.Where(i => i.MovieId == Id && i.Date >= stringdate).OrderBy(i=>i.Date).ToList();
            return screenmovie;
        }
        public List<ScreenMovie> getScreenMovieByCinemaId(int Id)
        {
            var stringdate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var screenmovie = obj.ScreenMovies.Where(i => i.CinemaId == Id && i.Date >= stringdate).OrderBy(i => i.Date).ToList();
            return screenmovie;
        }
        public List<DateTime> getScreenMovieDateByMovieId(int Id)
        {
            var stringdate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var screenmovie = obj.ScreenMovies.Where(i => i.MovieId == Id && i.Date >= stringdate).OrderBy(i => i.Date).ToList();
            List<DateTime> d = new List<DateTime>();
            foreach(var s in screenmovie)
            {
                d.Add(Convert.ToDateTime(s.Date));
            }
            return d.Distinct().ToList();
        }
    }
}
