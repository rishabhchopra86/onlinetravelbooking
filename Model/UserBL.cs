using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Data.Entity.Validation;

namespace Model
{
    public class UserBL :User
    {
        OnlineTicketBookingEntities obj;
        public UserBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddUser(User user)
        {
            try
            {
                obj.Users.Add(user);
                obj.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void DeleteUser()
        {
                //User user = obj.Users.SingleOrDefault(u => u.Id == this.Id);
                //user.IsActive = IsActive;
                obj.SaveChanges();
        }


        public void UpdateUser()
        {
                obj.SaveChanges();
        }

        public List<User> GetAllUser()
        {
            List<User> userList = new List<User>();
            userList = obj.Users.ToList();
            return userList;
        }
        #endregion

        #region Filtring
        public User GetByUserid()
        {
            User usr = new User();
            usr = obj.Users.FirstOrDefault(u => u.Id == this.Id);
            return usr;
        }
        #endregion
        public User login(string username, string password)
        {
            User u = new User();
            try
            {


                using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
                {
                    var query = obj.Users.Where(i => i.UserName == username && i.Password == password).FirstOrDefault();
                    return query;
                }

            }
            catch (Exception ex)
            {
                return u;
            }
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
        public int CustomerId(int id)
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                var query = obj.Customers.Where(i => i.UserId == id).FirstOrDefault();
                return query.Id;
            }
        }

    }
}
