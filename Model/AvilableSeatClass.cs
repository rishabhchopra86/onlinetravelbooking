using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;

namespace Model
{
    public class AvilableSeatClass:AvailableSeat
    {
        
#region CRUD
        public void AddAvilableSeat()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                AvailableSeat avilableseat = new AvailableSeat();
                avilableseat.FareId = this.FareId;
                avilableseat.Seat = this.Seat;
                avilableseat.SeatStatus = this.SeatStatus;
                avilableseat.CreatedBy = this.CreatedBy;
                avilableseat.CreatedDate = this.CreatedDate;
                avilableseat.UpdatedBy = this.UpdatedBy;
                avilableseat.UpdatedDate = this.UpdatedDate;
                avilableseat.IsActive = this.IsActive;

                obj.AvailableSeats.Add(avilableseat);
                obj.SaveChanges();

            }
        }

        public void DeleteAvillableSeat()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                AvailableSeat avilableseat = obj.AvailableSeats.Where(avls => avls.Id == this.Id).FirstOrDefault();
                avilableseat.IsActive = IsActive;

                obj.SaveChanges();
            };
        }

        public void UpdateAvilableSeat()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                AvailableSeat avilableseat = obj.AvailableSeats.Where(avls => avls.Id == this.Id).FirstOrDefault();
                avilableseat.FareId = this.FareId;
                avilableseat.Seat = this.Seat;
                avilableseat.SeatStatus = this.SeatStatus;
                avilableseat.CreatedBy = this.CreatedBy;
                avilableseat.CreatedDate = this.CreatedDate;
                avilableseat.UpdatedBy = this.UpdatedBy;
                avilableseat.UpdatedDate = this.UpdatedDate;
                avilableseat.IsActive = this.IsActive;

                obj.SaveChanges();
            }
        }

        public List<AvilableSeatClass> GetAllAvailableSeat()
        {
            List<AvailableSeat> seatlist = new List<AvailableSeat>();
            List<AvilableSeatClass> seatclasslist = new List<AvilableSeatClass>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                seatlist = obj.AvailableSeats.ToList();
                foreach(var seat in seatlist)
                {
                    seatclasslist.Add((AvilableSeatClass)CopyProperties(seat,this));
                }
            }
            return seatclasslist;
        }
        public object CopyProperties(object source, object destination)
        {
            PropertyInfo[] destinationProperties = destination.GetType().GetProperties();
            foreach (PropertyInfo destinationPi in destinationProperties)
            {
                PropertyInfo sourcePi = source.GetType().GetProperty(destinationPi.Name);
                destinationPi.SetValue(destination, sourcePi.GetValue(source, null), null);
            }
            return destination;
        }
        #endregion

        #region Filtering
        public AvilableSeatClass GetByAvailableSeatId()
        {
            AvailableSeat availableseat = new AvailableSeat();
            AvilableSeatClass availableseatclass;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                availableseat = obj.AvailableSeats.Where(avls => avls.Id == this.Id).FirstOrDefault();
                availableseatclass = (AvilableSeatClass)CopyProperties(availableseat, this);
            }
            return availableseatclass;
        }
#endregion

    }
}
