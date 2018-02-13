﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
    public class ScreenMovieBL:ScreenMovie
    {
        OnlineTicketBookingEntities obj;
        public ScreenMovieBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddScreenMovie(ScreenMovie screen)
        {
            obj.ScreenMovies.Add(screen);
            obj.SaveChanges();
        }

        public void DeleteScreenMovie()
        {
            obj.SaveChanges();
        }

        public void UpdateScreenMovie()
        {
            obj.SaveChanges();
        }

        public List<ScreenMovie> GetAllScreenMovie()
        {
            List<ScreenMovie> ScreenList = new List<ScreenMovie>();
            ScreenList = obj.ScreenMovies.Where(s => s.IsActive == true).ToList();
            return ScreenList;
        }

        #endregion

        #region Filtring
        public ScreenMovie GetByScreenMovieid()
        {
            ScreenMovie screen = new ScreenMovie();
            screen = obj.ScreenMovies.FirstOrDefault(s=>s.Id==Id);
            return screen;
        }
        #endregion
    }
}
