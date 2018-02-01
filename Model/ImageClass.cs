using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class ImageClass
    {
        public int Id { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> RTId { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string ImageName { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddImage()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Image image = new Image();
                image.TypeId = TypeId;
                image.RTId = RTId;
                image.Description = Description;
                image.Path = Path;
                image.ImageName = ImageName;
                image.CreatedBy = CreatedBy;
                image.CreatedDate = CreatedDate;
                image.UpdatedBy = UpdatedBy;
                image.UpdatedDate = UpdatedDate;
                image.IsActive = IsActive;

                obj.Images.Add(image);
                obj.SaveChanges();

            }
        }

        public void DeleteImage(ImageClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Image image = obj.Images.Where(i => i.Id == data.Id).FirstOrDefault();
                obj.Images.Remove(image);
                obj.SaveChanges();
            }
        }

        public void UpdateImages(ImageClass data)
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Image image = obj.Images.Where(i => i.Id == data.Id).FirstOrDefault();
                image.TypeId = data.TypeId;
                image.RTId = data.RTId;
                image.Description = data.Description;
                image.Path = data.Path;
                image.ImageName = data.ImageName;
                image.CreatedBy = data.CreatedBy;
                image.CreatedDate = CreatedDate;
                image.UpdatedBy = UpdatedBy;
                image.UpdatedDate = UpdatedDate;
                image.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public List<Image> GetAllImage()
        {
            List<Image> imagelst = new List<Image>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                imagelst = obj.Images.ToList();
            }
            return imagelst;
        }
#endregion
        
#region Filtering
        public Image GetByImageId(ImageClass data)
        {
            Image image = new Image();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                image = obj.Images.Where(i => i.Id == data.Id).FirstOrDefault();
            }
            return image;
        }
#endregion
    }
}
