using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace OnlineTicketBL
{
    public class ScreenBL:Screen
    {
        OnlineTicketBookingEntities obj;
        public ScreenBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddScreen(Screen screen)
        {
                obj.Screens.Add(screen);
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

        public List<Screen> GetAllScreen()
        {
            List<Screen> ScreenList = new List<Screen>();
            ScreenList = obj.Screens.ToList();
            return ScreenList;
        }
        #endregion

        #region Filtring
        public Screen GetByScreenid()
        {
            Screen screen = new Screen();
            screen = obj.Screens.FirstOrDefault(u => u.Id == Id);
            return screen;
        }
        #endregion
    }
}
