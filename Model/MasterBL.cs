using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class MasterBL:Master
    {
        OnlineTicketBookingEntities obj;
        public MasterBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddMaster(Master master)
        {
                obj.Masters.Add(master);
                obj.SaveChanges();
        }

        public void DeleteMaster()
        {
                //Master master = obj.Masters.Where(m => m.Id == this.Id).FirstOrDefault();
                //obj.Masters.Remove(master);
                obj.SaveChanges();
        }

        public void UpdateMaster()
        {
                obj.SaveChanges();
        }

        public List<Master> GetAllMaster()
        {
            List<Master> masterlst = new List<Master>();
            masterlst = obj.Masters.ToList();
            return masterlst;
        }

#endregion

#region Filtering
        public Master GetByMasterId()
        {
            Master master = new Master();
            master = obj.Masters.Where(m => m.Id == this.Id).FirstOrDefault();
            return master;
        }

        public List<MovieLanguage> GetByMovieLanguage()
        {
            List<MovieLanguage> movieLang = new List<MovieLanguage>();
            var lst = (from i in obj.Masters join j in obj.MasterValues on i.Id equals j.MasterId where i.Name== "MovieLanguage" select j).ToList();
            foreach(var ls in lst)
            {
                MovieLanguage ml = new MovieLanguage();
                ml.id = ls.Id;
                ml.Name = ls.Description;
                movieLang.Add(ml);
            }
            return movieLang;
        }

        public class MovieLanguage
        {
            public string Name { get; set; }
            public int id { get; set; }
        }



        public List<MovieType> GetMovieType()
        {
            List<MovieType> mt = new List<MovieType>();

            var lst = (from i in obj.Masters join j in obj.MasterValues on i.Id equals j.MasterId where i.Name == "MovieType" select j).ToList();
            foreach (var tmp in lst)
            {
                MovieType mtobj = new MovieType();
                mtobj.Id = tmp.Id;
                mtobj.movietype = tmp.Description;
                mt.Add(mtobj);
            }

            return mt;
        }

       public List<MasterValue> GetScreenFare()
        {
            List<MasterValue> screenFare = new List<MasterValue>();
            screenFare = (from i in obj.Masters join j in obj.MasterValues on i.Id equals j.MasterId where i.Name == "ScreenFare" select j).ToList();
            return screenFare;
        }

        public class MovieType
        {
            public int Id { get; set; }
            public string movietype { get; set; }
        }

        #endregion
    }
}


      