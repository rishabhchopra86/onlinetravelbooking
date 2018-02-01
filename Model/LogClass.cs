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

        public void DeleteLog(LogClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Log log = obj.Logs.Where(l => l.Id == data.Id).FirstOrDefault();
                obj.Logs.Remove(log);
                obj.SaveChanges();
                
            }
        }

        public void UpdateLog(LogClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Log log = obj.Logs.Where(l => l.Id == data.Id).FirstOrDefault();
                log.CustomerId = data.CustomerId;
                log.LogoutTime = data.LogoutTime;
                log.LoginTime = data.LoginTime;
                log.LoginDate = data.LoginDate;
                log.IpAddress = data.IpAddress;
                log.ErrorMessage = data.ErrorMessage;

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
        public Log GetByLogId(LogClass data)
        {
            Log log = new Log();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                log = obj.Logs.Where(l => l.Id == data.Id).FirstOrDefault();
            }
            return log;
        }
#endregion

    }
}
