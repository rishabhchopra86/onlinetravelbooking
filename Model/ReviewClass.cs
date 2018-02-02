using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class ReviewClass
    {

        public int Id { get; set; }
        public int TypeId { get; set; }
        public int RTCId { get; set; }
        public int CustomerId { get; set; }
        public double Ratings { get; set; }
        public string Review1 { get; set; }
        public DateTime Date { get; set; }

       
        #region CRUD
        public void AddReview()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Review rvw = new Review();
                rvw.TypeId = TypeId;
                rvw.RTCId = RTCId;
                rvw.CustomerId = CustomerId;
                rvw.Ratings = Ratings;
                rvw.Review1 = Review1;
                rvw.Date = Date;

                obj.Reviews.Add(rvw);
                obj.SaveChanges();
            }
        }
        public void deleteReview()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Review reviewId = obj.Reviews.SingleOrDefault(c => c.Id == Id);
                obj.Reviews.Remove(reviewId);
                obj.SaveChanges();

            }
        }
        public void updateReview()
        {

            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Review reviewId = obj.Reviews.Where(c => c.Id == Id).FirstOrDefault();
                Review rvw = new Review();
                rvw.TypeId = TypeId;
                rvw.RTCId = RTCId;
                rvw.CustomerId = CustomerId;
                rvw.Ratings = Ratings;
                rvw.Review1 = Review1;
                rvw.Date = Date;
                obj.SaveChanges();

            }

        }
        public static List<Review> getAll()
        {
            List<Review> lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst =obj.Reviews.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Review getByid()
        {

            Review lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.Reviews.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
