using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
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

        #region CRUD
        public void AddState()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
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

                obj.States.Add(st);
                obj.SaveChanges();
            }
        }
        public void deleteState()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                State stateId = obj.States.FirstOrDefault(c => c.Id == Id);
                stateId.IsActive = IsActive;

                obj.SaveChanges();
            }
        }
        public void updateState()
        {

            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                State state = obj.States.FirstOrDefault(c => c.Id == Id);
                state.CountryId = CountryId;
                state.StateName = StateName;
                state.StateCode = StateCode;
                state.TinNo = TinNo;
                state.CreatedBy = CreatedBy;
                state.CreatedDate = CreatedDate;
                state.UpdatedDate = UpdatedDate;
                state.UpdatedBy = UpdatedBy;
                state.IsActive = IsActive;
                obj.SaveChanges();
            }

        }
        public static List<State> getAll()
        {
            List<State> lst = new List<State>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.States.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public State getByid()
        {

            State lst = new State();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.States.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion


    }
}
