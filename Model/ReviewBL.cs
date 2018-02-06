using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class ReviewBL:Review
    {
        OnlineTicketBookingEntities obj;
        public ReviewBL()
        {
            obj = new OnlineTicketBookingEntities();
        }
       
        #region CRUD
        public void AddReview(Review review)
        {
                obj.Reviews.Add(review);
                obj.SaveChanges();
        }

        public void deleteReview()
        {
                obj.SaveChanges();
        }

        public void updateReview()
        {
                obj.SaveChanges();
        }

        public List<Review> getAll()
        {
            List<Review> lst = new List<Review>();
            lst =obj.Reviews.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public Review getByid()
        {

            Review lst = new Review();
            lst = obj.Reviews.Where(c => c.Id == Id).FirstOrDefault();

            return lst;
        }
        #endregion

    }
}
