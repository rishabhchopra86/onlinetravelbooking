using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class StateBL:State
    {
        OnlineTicketBookingEntities obj;
        public StateBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddState(State state)
        {
                obj.States.Add(state);
                obj.SaveChanges();
        }

        public void deleteState()
        {
                obj.SaveChanges();
        }

        public void updateState()
        {
                obj.SaveChanges();
        }

        public List<State> getAll()
        {
            List<State> lst = new List<State>();
            lst = obj.States.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public State getByid()
        {
            State lst = new State();
            lst = obj.States.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion


    }
}
