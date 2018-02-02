using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class ScreenClass
    {
        public int Id { get; set; }
        public Nullable<int> CinemasId { get; set; }
        public Nullable<int> MovieId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<int> TotalSeat { get; set; }
        public Nullable<int> AvailableSeat { get; set; }
        public Nullable<bool> C2D3D { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

        #region CRUD
        public void AddScreen()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Screen screen = new Screen();
                screen.AvailableSeat = AvailableSeat;
                screen.CinemasId = CinemasId;
                screen.MovieId =MovieId;
                screen.Name = Name;
                screen.Date = Date;
                screen.StartTime = StartTime;
                screen.EndTime = EndTime;
                screen.TotalSeat = TotalSeat;
                screen.C2D3D = C2D3D;
                screen.CreatedBy = CreatedBy;
                screen.CreatedDate =CreatedDate;
                screen.UpdatedBy = UpdatedBy;
                screen.UpdatedDate = UpdatedDate;
                screen.IsActive = IsActive;

                obj.Screens.Add(screen);
                obj.SaveChanges();
            }
        }

        public void DeleteScreen()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Screen screen = obj.Screens.Where(s=>s.Id==Id).FirstOrDefault();
                screen.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateScreen()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Screen screen = obj.Screens.Where(s => s.Id == Id).FirstOrDefault();
                screen.AvailableSeat = AvailableSeat;
                screen.CinemasId = CinemasId;
                screen.MovieId = MovieId;
                screen.Name = Name;
                screen.Date = Date;
                screen.StartTime = StartTime;
                screen.EndTime = EndTime;
                screen.TotalSeat = TotalSeat;
                screen.C2D3D = C2D3D;
                screen.CreatedBy = CreatedBy;
                screen.CreatedDate = CreatedDate;
                screen.UpdatedBy = UpdatedBy;
                screen.UpdatedDate = UpdatedDate;
                screen.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public List<Screen> GetAllScreen()
        {
            List<Screen> ScreenList = new List<Screen>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {

                ScreenList = obj.Screens.ToList();

            }
            return ScreenList;
        }
        #endregion

        #region Filtring
        public Screen GetByScreenid()
        {
            Screen screen = new Screen();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                screen = obj.Screens.FirstOrDefault(u => u.Id == Id);
            }
            return screen;
        }
        #endregion
    }
}
