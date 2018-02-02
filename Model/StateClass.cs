using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
   public class StateClass
    {

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public int TinNo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }

        private OnlineTicketBookingEntities _context;

        public void saveChanges()
        {
            _context.SaveChanges();
        }

        #region CRUD
        public void AddState()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                State st = new State();
                st.CountryId = CountryId;
                st.StateName = StateName;
                st.StateCode = StateCode;
                st.TinNo = TinNo;
                st.CreatedBy = CreatedBy;
                st.CreatedDate = CreatedDate;
                st.UpdatedDate = UpdatedDate;
                st.UpdatedBy = UpdatedBy;
                st.IsActive = IsActive;

                otbe.States.Add(st);
                saveChanges();
            }
        }
        public void deleteState()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                State stateId = otbe.States.SingleOrDefault(c => c.Id == Id);
                otbe.States.Remove(stateId);
                saveChanges();
            }
        }
        public void updateState()
        {

            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                State countryId = otbe.States.SingleOrDefault(c => c.Id == Id);
                State st = new State();
                st.CountryId = CountryId;
                st.StateName = StateName;
                st.StateCode = StateCode;
                st.TinNo = TinNo;
                st.CreatedBy = CreatedBy;
                st.CreatedDate = CreatedDate;
                st.UpdatedDate = UpdatedDate;
                st.UpdatedBy = UpdatedBy;
                st.IsActive = IsActive;
                saveChanges();
            }

        }
        public static List<State> getAll()
        {
            List<State> lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = (from i in otbe.States select i).ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public State getByid()
        {

            State lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = otbe.States.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion


    }
}
