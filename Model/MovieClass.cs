using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class MovieClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> TotalRatings { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> Language { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddMovie()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Movie movie = new Movie();
                movie.Name = Name;
                movie.Description = Description;
                movie.TotalRatings = TotalRatings;
                movie.Duration = Duration;
                movie.Language = Language;
                movie.Type = Type;
                movie.CreatedBy = CreatedBy;
                movie.CreatedDate = CreatedDate;
                movie.UpdatedBy = UpdatedBy;
                movie.UpdatedDate = UpdatedDate;
                movie.IsActive = IsActive;

                obj.Movies.Add(movie);
                obj.SaveChanges();
            }
        }

        public void UpdateMovie()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Movie movie = obj.Movies.Where(m => m.Id == Id).FirstOrDefault();
                movie.Name = Name;
                movie.Description = Description;
                movie.TotalRatings = TotalRatings;
                movie.Duration = Duration;
                movie.Language = Language;
                movie.Type = Type;
                movie.CreatedBy = CreatedBy;
                movie.CreatedDate = CreatedDate;
                movie.UpdatedBy = UpdatedBy;
                movie.UpdatedDate = UpdatedDate;
                movie.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void DeleteMovie()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Movie movie = obj.Movies.Where(m => m.Id == Id).FirstOrDefault();
                movie.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public List<Movie>GetAllMovie()
        {
            List<Movie> movielst =new  List<Movie>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                movielst = obj.Movies.ToList();
            }
                return movielst;
        }
 #endregion
#region Filtering
        public Movie GetByMovieId()
        {
            Movie movie = new Movie();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                 movie = obj.Movies.Where(m => m.Id == Id).FirstOrDefault();
            }
            return movie;
        }
 #endregion
        }
}
