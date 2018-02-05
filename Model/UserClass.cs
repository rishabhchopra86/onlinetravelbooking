using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace OnlineTicketBL
{
    public class UserClass :User
    {
        OnlineTicketBookingEntities obj;
        public UserClass()
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
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                User user = obj.Users.SingleOrDefault(u => u.Id == Id);
                user.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateUser()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                User user = obj.Users.FirstOrDefault(u => u.Id == Id);
                user.UserCode = UserCode;
                user.UserName = UserName;
                user.Password = Password;
                user.Name = Name;
                user.TypeId = TypeId;
                user.PasswordIv = PasswordIv;
                user.Encrypt = Encrypt;
                user.Logged = Logged;
                user.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public List<User> GetAllUser()
        {
            List<User> userList = new List<User>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                //userList = obj.Users.Select(usr=>new UserClass
                //{
                //    UserCode = usr.UserCode,
                //    UserName = usr.UserName,
                //    Password = usr.Password,
                //    Name = usr.Name,
                //    TypeId = usr.TypeId,
                //    PasswordIv = usr.PasswordIv,
                //    Encrypt = usr.Encrypt,
                //    Logged = usr.Logged,
                //    IsActive = usr.IsActive,
                //    Id=usr.Id
                // }).ToList();

                userList = obj.Users.ToList();

            }
            return userList;
        }
        #endregion

        #region Filtring
        public User GetByUserid()
        {
            User usr = new User();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                usr = obj.Users.FirstOrDefault(u => u.Id == Id);
            }
            return usr;
        }
        #endregion
    }
}
