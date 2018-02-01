using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class AvilableSeatClass
    {
        public int Id { get; set; }
        public Nullable<int> FareId { get; set; }
        public Nullable<int> Seat { get; set; }
        public Nullable<int> SeatStatus { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddAvilableSeat()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                AvailableSeat avilableseat = new AvailableSeat();
                avilableseat.FareId = FareId;
                avilableseat.Seat = Seat;
                avilableseat.SeatStatus = SeatStatus;
                avilableseat.CreatedBy = CreatedBy;
                avilableseat.CreatedDate = CreatedDate;
                avilableseat.UpdatedBy = UpdatedBy;
                avilableseat.UpdatedDate = UpdatedDate;
                avilableseat.IsActive = IsActive;

                obj.AvailableSeats.Add(avilableseat);
                obj.SaveChanges();

            }
        }

        public void DeleteAvillableSeat(AvilableSeatClass data)
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                AvailableSeat avilableseat = obj.AvailableSeats.Where(avls => avls.Id == data.Id).FirstOrDefault();
                obj.AvailableSeats.Remove(avilableseat);
                obj.SaveChanges();
            };
        }

        public void UpdateAvilableSeat(AvilableSeatClass data)
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                AvailableSeat avilableseat = obj.AvailableSeats.Where(avls => avls.Id == data.Id).FirstOrDefault();
                avilableseat.FareId = data.FareId;
                avilableseat.Seat = data.Seat;
                avilableseat.SeatStatus = data.SeatStatus;
                avilableseat.CreatedBy = data.CreatedBy;
                avilableseat.CreatedDate = data.CreatedDate;
                avilableseat.UpdatedBy = data.UpdatedBy;
                avilableseat.UpdatedDate = data.UpdatedDate;
                avilableseat.IsActive = data.IsActive;

                obj.SaveChanges();
            }
        }

        public List<AvailableSeat> GetAllAvailableSeat()
        {
            List<AvailableSeat> seatList = new List<AvailableSeat>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                seatList = obj.AvailableSeats.ToList();
            }
            return seatList;
        }
#endregion

#region Filtering
        public AvailableSeat GetByAvailableSeatId(AminitiesClass data)
        {
            AvailableSeat availableseat = new AvailableSeat();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                availableseat = obj.AvailableSeats.Where(avls => avls.Id == data.Id).FirstOrDefault();
            }
            return availableseat;
        }
#endregion

    }
}
