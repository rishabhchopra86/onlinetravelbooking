using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class UserClass
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string PasswordIv { get; set; }
        public string Encrypt { get; set; }
        public Nullable<bool> Logged { get; set; }
        public Nullable<bool> IsActive { get; set; }

        #region CRUD
        public void AddUser()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                User user = new User();
                user.UserCode = UserCode;
                user.UserName = UserName;
                user.Password = Password;
                user.Name = Name;
                user.TypeId =TypeId;
                user.PasswordIv = PasswordIv;
                user.Encrypt = Encrypt;
                user.Logged =Logged;
                user.IsActive = IsActive;
                obj.Users.Add(user);
                obj.SaveChanges();
            }
        }

        public void DeleteUser()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                User user = obj.Users.SingleOrDefault(u=>u.Id==Id);
                obj.Users.Remove(user);
                obj.SaveChanges();
            }
        }

        public void UpdateUser()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                User user = obj.Users.SingleOrDefault(u => u.Id ==Id);
                user.UserCode = UserCode;
                user.UserName = UserName;
                user.Password = Password;
                user.Name = Name;
                user.TypeId =TypeId;
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
