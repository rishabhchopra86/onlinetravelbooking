using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class LogClass
    {
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.TimeSpan> LoginTime { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
        public Nullable<System.TimeSpan> LogoutTime { get; set; }
        public string IpAddress { get; set; }
        public string ErrorMessage { get; set; }

#region CRUD
        public void AddLog()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Log log = new Log();
                log.CustomerId = CustomerId;
                log.LoginTime = LoginTime;
                log.LoginDate = LoginDate;
                log.LogoutTime = LogoutTime;
                log.IpAddress = IpAddress;
                log.ErrorMessage = ErrorMessage;

                obj.Logs.Add(log);
                obj.SaveChanges();
            }
        }

        //public void DeleteLog()
        //{
        //    using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
        //    {
        //        Log log = obj.Logs.Where(l => l.Id == Id).FirstOrDefault();
        //        obj.Logs.Remove(log);
        //        obj.SaveChanges();
                
        //    }
        //}

        public void UpdateLog()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Log log = obj.Logs.Where(l => l.Id == Id).FirstOrDefault();
                log.CustomerId = CustomerId;
                log.LogoutTime = LogoutTime;
                log.LoginTime = LoginTime;
                log.LoginDate = LoginDate;
                log.IpAddress = IpAddress;
                log.ErrorMessage = ErrorMessage;

                obj.SaveChanges();
            }
        }

        public List<Log> GetAllLog()
        {
            List<Log> loglst = new List<Log>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                loglst = obj.Logs.ToList();
            }
            return loglst;
        }
#endregion

#region Filtering
        public Log GetByLogId()
        {
            Log log = new Log();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                log = obj.Logs.Where(l => l.Id == Id).FirstOrDefault();
            }
            return log;
        }
#endregion

    }
}
