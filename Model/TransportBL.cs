using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class TransportBL:Transport
    {
        OnlineTicketBookingEntities obj;
        public TransportBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddTransport(Transport trans)
        {
                obj.Transports.Add(trans);
                obj.SaveChanges();
        }

        public void DeleteTransport()
        {
                obj.SaveChanges();
        }

        public void UpdateTransport()
        {
                obj.SaveChanges();
        }

        public List<Transport> GetAllTransports()
        {
            List<Transport> transportList = new List<Transport>();
            transportList = obj.Transports.ToList();
            return transportList;
        }
        #endregion

        #region Filtering
        public Transport GetByTransportid()
        {
            Transport transport= new Transport();
            transport = obj.Transports.FirstOrDefault(t => t.Id == Id);
            return transport;
        }
        #endregion
    }
}
