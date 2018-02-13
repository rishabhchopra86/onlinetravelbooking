using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataModel;

namespace WebSite.Admin
{
    public partial class AddScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CinemaBL cinemabl = new CinemaBL();
                dpCinemaName.DataSource = cinemabl.getAllCinemas();
                dpCinemaName.DataTextField = "Name";
                dpCinemaName.DataValueField = "Id";
                dpCinemaName.DataBind();

                //MovieBL moviebl = new MovieBL();
                //dpMovieName.DataSource = moviebl.GetAllMovie();
                //dpMovieName.DataTextField = "Name";
                //dpMovieName.DataValueField = "Id";
                //dpMovieName.DataBind();
            }
        }

        protected void btnSaveScreen_Click(object sender, EventArgs e)
        {
            ScreenMaster screenmaster = new ScreenMaster();
            screenmaster.CinemasId = int.Parse(dpCinemaName.SelectedItem.Value);
            screenmaster.ScreenName = txtScreenName.Text;
            screenmaster.TotalSeats = txtTotalSeats.Text;
            screenmaster.ScreenDesignId = 1;
            screenmaster.CreatedDate = DateTime.Now.Date;
            screenmaster.IsActive = true;
          
          //  ScreenMaster moviebl = new MovieBL();
         //   moviebl.AddMovie(mv);
            Response.Write("<script>alert('Screen added...')</script>");
        }
    }
}