using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class CinemaBL : Cinema
    {
        OnlineTicketBookingEntities obj;
        public CinemaBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddCinema(Cinema cinema)
        {
            obj.Cinemas.Add(cinema);
            obj.SaveChanges();
        }
        public void deleteCinema()
        {
            //Cinema cinema= obj.Cinemas.Where(c=>c.Id==this.Id).FirstOrDefault();
            //cinema.IsActive = IsActive;
            obj.SaveChanges();
        }

        public void updateCinema()
        {
            obj.SaveChanges();
        }

        public List<Cinema> getAllCinemas()
        {
            List<Cinema> lst = new List<Cinema>();
            lst = obj.Cinemas.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public Cinema getByid()
        {
            Cinema lst = new Cinema();
            lst = obj.Cinemas.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion
        public string getCinemaNameByid(int id)
        {

            return obj.Cinemas.Where(c => c.Id == id).FirstOrDefault().Name;
        }
        public List<Cinema> getAllCinemasByCityId(int Id)
        {
            List<Cinema> lst = new List<Cinema>();
            lst = obj.Cinemas.Where(i => i.CityId == Id).ToList();
            return lst;
        }
        public string getAllCinemasByCityIdDisplay(int Id, string cityName)
        {
            List<Cinema> lst = new List<Cinema>();
            if (Id == 0)
            {
                lst = obj.Cinemas.ToList();
            }
            else
            {
                lst = obj.Cinemas.Where(i => i.CityId == Id).ToList();
            }

            string displaycinemas = "";
            Rating r = new Rating();
            if (lst == null)
            {
                displaycinemas += "<div class='col-md-4'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='#'>" +
                        "                                        <img src = 'img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";

                displaycinemas += "                                    </ul>" +
                           "                                    <h5 class='thumb-title'><a class='text-darken' href='#'>No Data Found</a></h5>" +

                           "                                </div>" +
                           "                            </div>" +
                           "                        </div>";
            }
            else
            {
                ImageBL img = new ImageBL();
                foreach (Cinema c in lst)
                {
                    displaycinemas += "<div class='col-md-4'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='cinemasdetail.aspx?Id=Cinema_" + c.Id + "'>" +
                        "                                        <img src = '"+img.getByTypeIdRtc(53,c.Id)+"' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";
                    if (c.Ratings == null)
                    {
                        displaycinemas += r.rate(0);
                    }
                    else
                    {
                        displaycinemas += r.rate((double)c.Ratings);
                    }

                    displaycinemas += "                                    </ul>" +
                               "                                    <h5 class='thumb-title'><a class='text-darken'  href='cinemasdetail.aspx?Id=Cinema_" + c.Id + "'>" + c.Name + "</a></h5>" +
                               "                                    <p class='mb0'><small><i class='fa fa-map-marker'></i> " + cityName + "</small> </p>" +
                                "                                  <p class='mb0'><small><i class='fa fa-phone'></i> " + c.PhoneNo + "</small>" +
                               "                                    </p>" +
                               "                                </div>" +
                               "                            </div>" +
                               "                        </div>";
                }
            }
            return displaycinemas;
        }


    }
}
