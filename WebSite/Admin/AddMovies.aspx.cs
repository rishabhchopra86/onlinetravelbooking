using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataModel;
using System.Data.Entity.Validation;
using System.Globalization;

namespace WebSite.Admin
{
    public partial class AddMovies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //CityBL citybl = new CityBL();
                //dpLanguage.DataSource = citybl.GetAllCities();
                //dpLanguage.DataTextField = "CityName";
                //dpLanguage.DataValueField = "CityId";
                //dpLanguage.DataBind();
                MasterBL masterbl = new MasterBL();
                dpLanguage.DataSource = masterbl.GetByMovieLanguage();
                dpLanguage.DataTextField = "Name";
                dpLanguage.DataValueField = "id";
                dpLanguage.DataBind();

              
                dpMovieType.DataSource = masterbl.GetMovieType();
                dpMovieType.DataTextField = "movietype";
                dpMovieType.DataValueField = "Id";
                dpMovieType.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

           

                Movie mv = new Movie();
                mv.Name = txtName.Text;
                mv.Description = txtDescription.InnerText;
            // 
            //TimeSpan tmp;
                mv.Duration =   Convert.ToDateTime(txtDuration.Text).TimeOfDay;
                mv.MovieLanguage = int.Parse(dpLanguage.SelectedItem.Value);
                mv.MovieType = int.Parse(dpMovieType.SelectedItem.Value);
                mv.IsActive = true;
                mv.CreatedDate = DateTime.Now.Date;
                MovieBL moviebl = new MovieBL();
                moviebl.AddMovie(mv);
                Response.Write("<script>alert('Movie added...')</script>");
            
            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
        }
    }
}