using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
   public class ReviewClass
    {

        public int Id { get; set; }
        public int TypeId { get; set; }
        public int RtId { get; set; }
        public int CustomerId { get; set; }
        public double Ratings { get; set; }
        public string Review1 { get; set; }
        public DateTime Date { get; set; }

        private OnlineTicketBookingEntities _context;

        public void saveChanges()
        {
            _context.SaveChanges();
        }

        #region CRUD
        public void AddReview()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Review rvw = new Review();
                rvw.TypeId = TypeId;
                rvw.RtId = RtId;
                rvw.CustomerId = CustomerId;
                rvw.Ratings = Ratings;
                rvw.Review1 = Review1;
                rvw.Date = Date;

                otbe.Reviews.Add(rvw);
                saveChanges();
            }
        }
        public void deleteReview()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Review reviewId = otbe.Reviews.SingleOrDefault(c => c.Id == Id);
                otbe.Reviews.Remove(reviewId);
                saveChanges();
            }
        }
        public void updateReview()
        {

            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Review reviewId = otbe.Reviews.SingleOrDefault(c => c.Id == Id);
                Review rvw = new Review();
                rvw.TypeId = TypeId;
                rvw.RtId = RtId;
                rvw.CustomerId = CustomerId;
                rvw.Ratings = Ratings;
                rvw.Review1 = Review1;
                rvw.Date = Date;
                saveChanges();
            }

        }
        public static List<Review> getAll()
        {
            List<Review> lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = (from i in otbe.Reviews select i).ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Review getByid()
        {

            Review lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = otbe.Reviews.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
