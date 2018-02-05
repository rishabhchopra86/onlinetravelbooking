using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace OnlineTicketBL
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
                obj.Users.Add(user);
                obj.SaveChanges();
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
    }
}
