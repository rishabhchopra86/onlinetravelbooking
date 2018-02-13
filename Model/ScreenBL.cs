using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class ScreenBL:Screen
    {
        OnlineTicketBookingEntities obj;
        public ScreenBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddScreen(ScreenMaster screen)
        {
                obj.ScreenMasters.Add(screen);
                obj.SaveChanges();
        }

        public void DeleteScreen()
        {
                obj.SaveChanges();
        }

        public void UpdateScreen()
        {
                obj.SaveChanges();
        }

        public List<ScreenMaster> GetAllScreen()
        {
            List<ScreenMaster> ScreenList = new List<ScreenMaster>();
            ScreenList = obj.ScreenMasters.Where(s=>s.IsActive==true).ToList();
            return ScreenList;
        }
        #endregion

        #region Filtring
        public ScreenMaster GetByScreenid()
        {
            ScreenMaster screen = new ScreenMaster();
            screen = obj.ScreenMasters.FirstOrDefault(u => u.Id == Id);
            return screen;
        }
        #endregion
    }
}
