using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class LogBL:Log
    {
        OnlineTicketBookingEntities obj;
        public LogBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddLog(Log log)
        {
                obj.Logs.Add(log);
                obj.SaveChanges();
        }

        public List<Log> GetAllLog()
        {
            List<Log> loglst = new List<Log>();
            loglst = obj.Logs.ToList();
            return loglst;
        }
#endregion

#region Filtering
        public Log GetByLogId()
        {
            Log log = new Log();
            log = obj.Logs.Where(l => l.Id == Id).FirstOrDefault();
            return log;
        }
#endregion

    }
}
