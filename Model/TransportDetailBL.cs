using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public  class TransportDetailBL:TransportDetail
    {
        OnlineTicketBookingEntities obj;
        public TransportDetailBL()
        {
            obj = new OnlineTicketBookingEntities();
        } 

        #region CRUD
        public void AddTransportDetail(TransportDetail transdetail)
        {
                obj.TransportDetails.Add(transdetail);
                obj.SaveChanges();
        }

        public void DeleteTransportDetail()
        {
                obj.SaveChanges();
        }

        public void UpdateTransportDetail()
        {
                obj.SaveChanges();
        }

        public List<TransportDetail> GetAllTransportDetail()
        {
            List<TransportDetail> transDetailList = new List<TransportDetail>();
            transDetailList = obj.TransportDetails.ToList();
            return transDetailList;
        }
        #endregion

        #region Filtering
        public TransportDetail GetByTransportDetailid()
        {
            TransportDetail transdetail = new TransportDetail();
            transdetail = obj.TransportDetails.FirstOrDefault(u => u.Id == Id);
            return transdetail;
        }
        #endregion
    }
}
