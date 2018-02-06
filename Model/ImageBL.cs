using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class ImageBL:Image
    {
        OnlineTicketBookingEntities obj;
        public ImageBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddImage(Image image)
        {
                obj.Images.Add(image);
                obj.SaveChanges();
        }

        public void DeleteImage()
        {
                obj.SaveChanges();
        }

        public void UpdateImages()
        {
                obj.SaveChanges();
        }

        public List<Image> GetAllImage()
        {
            List<Image> imagelst = new List<Image>();
            imagelst = obj.Images.ToList();
            return imagelst;
        }
#endregion
        
#region Filtering
        public Image GetByImageId()
        {
            Image image = new Image();
            image = obj.Images.Where(i => i.Id == Id).FirstOrDefault();
            return image;
        }
#endregion
    }
}
