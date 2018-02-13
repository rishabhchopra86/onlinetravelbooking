using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;

namespace WebSite.Admin
{
    public partial class AddScreenMovies : System.Web.UI.Page
    {
        static int index = 0;
        static List<string> faretypename;
        static List<string> farerate;
        static List<string> fareType;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                faretypename = new List<string>();
                fareType = new List<string>();
                farerate = new List<string>();

                MovieBL moviebl = new MovieBL();
                ddlmovies.DataSource = moviebl.GetAllMovie();
                ddlmovies.DataValueField = "Id";
                ddlmovies.DataTextField = "Name";
                ddlmovies.DataBind();

                ScreenBL screenbl = new ScreenBL();
                ddlscreen.DataSource = screenbl.GetAllScreen();
                ddlscreen.DataValueField = "Id";
                ddlscreen.DataTextField = "ScreenName";
                ddlscreen.DataBind();

                MasterBL masterbl = new MasterBL();
                ddlScreenFare.DataSource = masterbl.GetScreenFare();
                ddlScreenFare.DataTextField = "Description";
                ddlScreenFare.DataValueField = "Id";
                ddlScreenFare.DataBind();

                CinemaBL cinemabl = new CinemaBL();
                ddlCinemas.DataSource = cinemabl.getAllCinemas();
                ddlCinemas.DataTextField = "Name";
                ddlCinemas.DataValueField = "Id";
                ddlCinemas.DataBind();

                fillGrid();
            }
        }

        public void fillGrid()
        {
            try
            {
                OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities();
                GreedScreenMovie.DataSource = obj.GetScreenMovieDetails().ToList();
                GreedScreenMovie.DataBind();
            }
            catch (Exception exp)
            {

            }
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                FareRate.InnerHtml = "";

                ScreenMovie screen = new ScreenMovie();
                screen.MovieId = Convert.ToInt32(ddlmovies.SelectedItem.Value);
                screen.ScreenId = Convert.ToInt32(ddlscreen.SelectedItem.Value);

                screen.Date = Convert.ToDateTime(txtMovieDate.Text.ToString());
                screen.StartTime = Convert.ToDateTime(txtStartTime.Text.ToString()).TimeOfDay;
                screen.EndTime = Convert.ToDateTime(txtEndTime.Text.ToString()).TimeOfDay;
                string ampm = txtStartTime.Text.Substring(9, 2);

                if (ampm == "AM")
                {
                    screen.AM_PM = true;
                }
                else
                {
                    screen.AM_PM = false;
                }

                screen.AvailableSeat = Convert.ToInt32(txtAvailableSeat.Text);
                screen.CreatedDate = DateTime.Now.Date;
                if (rdb2d.Checked == true)
                {
                    screen.C2D3D = true;
                }

                if (rdb3d.Checked == true)
                {
                    screen.C2D3D = false;
                }
                screen.IsActive = true;
                screen.CinemaId = Convert.ToInt32(ddlCinemas.SelectedItem.Value);

                ScreenMovieBL screenbl = new ScreenMovieBL();
                screenbl.AddScreenMovie(screen);

                for (int i = 0; i < faretypename.Count; i++)
                {
                    DataModel.ScreenFare sf = new DataModel.ScreenFare();
                    sf.Rate = Convert.ToDouble(farerate[i]);
                    sf.ScreenId = screen.Id;
                    sf.FareType = Convert.ToInt32(fareType[i]);
                    ScreenFareBL sfbl = new ScreenFareBL();
                    sfbl.AddScreenFare(sf);
                }
                txtAvailableSeat.Text = txtEndTime.Text = txtMovieDate.Text = txtStartTime.Text = string.Empty;

                ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "showMessage('Successfully Added','Success');", true);


            }
            catch (Exception exp)
            {

            }
            Response.Redirect("AddScreenMovies.aspx");
        }

        protected void GreedScreenMovie_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (GreedScreenMovie.EditIndex == e.Row.RowIndex && e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList ddlCinemaList = (DropDownList)e.Row.FindControl("updateCinemaName");
                CinemaBL cinemabl = new CinemaBL();
                ddlCinemaList.DataSource = cinemabl.getAllCinemas();
                ddlCinemaList.DataTextField = "Name";
                ddlCinemaList.DataValueField = "Id";
                ddlCinemaList.DataBind();

                DropDownList ddlMovieList = (DropDownList)e.Row.FindControl("updateMovieName");
                MovieBL moviebl = new MovieBL();
                ddlMovieList.DataSource = moviebl.GetAllMovie();
                ddlMovieList.DataTextField = "Name";
                ddlMovieList.DataValueField = "Id";
                ddlMovieList.DataBind();


                DropDownList ddlScreenList = (DropDownList)e.Row.FindControl("updateScreenName");
                ScreenBL screenbl = new ScreenBL();
                ddlScreenList.DataSource = screenbl.GetAllScreen();
                ddlScreenList.DataTextField = "ScreenName";
                ddlScreenList.DataValueField = "Id";
                ddlScreenList.DataBind();

                RadioButton chkAM = (RadioButton)e.Row.FindControl("UpchkAm");
                RadioButton chkPM = (RadioButton)e.Row.FindControl("UpchkPm");
                string Hampm = ((HiddenField)e.Row.FindControl("Hampm1")).Value;
                if (Hampm == "True")
                {
                    chkAM.Checked = true;
                }
                if (Hampm == "False")
                {
                    chkPM.Checked = true;
                }

                RadioButton updaterdb2d = (RadioButton)e.Row.FindControl("updaterdb2d");
                RadioButton updaterdb3d = (RadioButton)e.Row.FindControl("updaterdb3d");
                string H2d3d = ((HiddenField)e.Row.FindControl("UH2d3d")).Value;
                if (H2d3d == "True")
                {
                    updaterdb2d.Checked = true;
                }
                if (H2d3d == "False")
                {
                    updaterdb3d.Checked = true;
                }
            }
            if (GreedScreenMovie.EditIndex != e.Row.RowIndex && e.Row.RowType == DataControlRowType.DataRow)
            {
                RadioButton chkAM = (RadioButton)e.Row.FindControl("chkAm");
                RadioButton chkPM = (RadioButton)e.Row.FindControl("chkPm");
                string Hampm = ((HiddenField)e.Row.FindControl("Hampm")).Value;
                if (Hampm == "True")
                {
                    chkAM.Checked = true;
                }
                if (Hampm == "False")
                {
                    chkPM.Checked = true;
                }

                RadioButton rdb2d = (RadioButton)e.Row.FindControl("rdb2d");
                RadioButton rdb3d = (RadioButton)e.Row.FindControl("rdb3d");
                string H2d3d = ((HiddenField)e.Row.FindControl("H2d3d")).Value;
                if (H2d3d == "True")
                {
                    rdb2d.Checked = true;
                }
                if (H2d3d == "False")
                {
                    rdb3d.Checked = true;
                }
            }
        }

        protected void GreedScreenMovie_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GreedScreenMovie.DataKeys[e.RowIndex].Values["Id"]);
                ScreenMovieBL screenbl = new ScreenMovieBL();
                screenbl.Id = id;
                ScreenMovie sm = screenbl.GetByScreenMovieid();
                sm.IsActive = false;
                screenbl.DeleteScreenMovie();
                fillGrid();
            }
            catch (Exception exp)
            {

            }
        }

        protected void GreedScreenMovie_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GreedScreenMovie.DataKeys[e.RowIndex].Values["Id"]);

                DropDownList ddlCinemaId = (DropDownList)GreedScreenMovie.Rows[e.RowIndex].FindControl("updateCinemaName");
                DropDownList ddlMovieId = (DropDownList)GreedScreenMovie.Rows[e.RowIndex].FindControl("updateMovieName");
                DropDownList ddlScreenId = (DropDownList)GreedScreenMovie.Rows[e.RowIndex].FindControl("updateScreenName");

                TextBox txtDate = (TextBox)GreedScreenMovie.Rows[e.RowIndex].FindControl("txtDate");
                TextBox txtStartTime = (TextBox)GreedScreenMovie.Rows[e.RowIndex].FindControl("UpdatetxtStartTime");
                TextBox txtEndTime = (TextBox)GreedScreenMovie.Rows[e.RowIndex].FindControl("UpdatetxtEndTime");
                TextBox txtAvlblseat = (TextBox)GreedScreenMovie.Rows[e.RowIndex].FindControl("updateAvlblSeat");

                RadioButton updaterdb2d = (RadioButton)GreedScreenMovie.Rows[e.RowIndex].FindControl("updaterdb2d");
                RadioButton updaterdb3d = (RadioButton)GreedScreenMovie.Rows[e.RowIndex].FindControl("updaterdb3d");
                bool c2d3d = true;
                if (updaterdb2d.Checked == true)
                {
                    c2d3d = true;
                }
                if (updaterdb3d.Checked == true)
                {
                    c2d3d = false;
                }

                RadioButton chkAM = (RadioButton)GreedScreenMovie.Rows[e.RowIndex].FindControl("UpchkAm");
                RadioButton chkPM = (RadioButton)GreedScreenMovie.Rows[e.RowIndex].FindControl("UpchkPm");
                bool ampm = true;
                if (chkAM.Checked == true)
                {
                    ampm = true;
                }
                if (chkPM.Checked == true)
                {
                    ampm = false;
                }

                ScreenMovieBL screenbl = new ScreenMovieBL();
                screenbl.Id = id;
                ScreenMovie sm = screenbl.GetByScreenMovieid();
                sm.AM_PM = ampm;
                sm.AvailableSeat = Convert.ToInt16(txtAvlblseat.Text);
                sm.C2D3D = c2d3d;
                sm.CinemaId = Convert.ToInt32(ddlCinemaId.SelectedItem.Value);
                sm.MovieId = Convert.ToInt32(ddlMovieId.SelectedItem.Value);
                sm.ScreenId = Convert.ToInt32(ddlScreenId.SelectedItem.Value);
                sm.Date = Convert.ToDateTime(txtDate.Text.ToString());
                sm.StartTime = Convert.ToDateTime(txtStartTime.Text.ToString()).TimeOfDay;
                sm.EndTime = Convert.ToDateTime(txtEndTime.Text.ToString()).TimeOfDay;
                sm.UpdatedDate = DateTime.Now;
                screenbl.UpdateScreenMovie();
                GreedScreenMovie.EditIndex = -1;
                fillGrid();
            }
            catch (Exception exp)
            {

            }
        }

        protected void GreedScreenMovie_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GreedScreenMovie.EditIndex = e.NewEditIndex;
            fillGrid();
        }

        protected void GreedScreenMovie_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GreedScreenMovie.PageIndex = e.NewPageIndex;
            fillGrid();
        }

        protected void GreedScreenMovie_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GreedScreenMovie.EditIndex = -1;
            fillGrid();
        }

        protected void AddButtonRate_Click(object sender, EventArgs e)
        {
            fareType.Add(ddlScreenFare.SelectedValue);
            faretypename.Add(ddlScreenFare.SelectedItem.ToString());
            farerate.Add(txtRate.Text);
            FareRate.InnerHtml = "<div class='col-md-8'><table class='table table-bordered'><tr><td>Fare Type</td><td>Fare Rate</td></tr>";
            for (int i = 0; i < faretypename.Count; i++)
            {
                FareRate.InnerHtml += "<tr><td>" + faretypename[i] + "</td><td>" + farerate[i] + "</td></tr>";
            }
            FareRate.InnerHtml += "</table></div>";

            txtRate.Text = "";

        }

        public string GridViewSortExpression
        {
            get
            {
                return ViewState["GridViewSortExpression"] == null ? "FirstName" : ViewState["GridViewSortExpression"] as string;
            }
            set
            {
                ViewState["GridViewSortExpression"] = value;
            }
        }

        /// <summary>
        /// for Sorting Direction
        /// </summary>
        public SortDirection GridViewSortDirection
        {
            get
            {
                if (ViewState["sortDirection"] == null)
                    ViewState["sortDirection"] = SortDirection.Ascending;

                return (SortDirection)ViewState["sortDirection"];
            }
            set { ViewState["sortDirection"] = value; }
        }

        protected void GreedScreenMovie_Sorting(object sender, GridViewSortEventArgs e)
        {
           
        }

        protected void GreedScreenMovie_Sorting1(object sender, GridViewSortEventArgs e)
        {
            GridViewSortExpression = e.SortExpression;
            if (GridViewSortDirection == SortDirection.Ascending)
            {
                GridViewSortDirection = SortDirection.Descending;
                OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities();
                var lst = obj.GetScreenMovieDetails().ToList();
                GreedScreenMovie.DataSource = lst.OrderBy(x => x.GetType().GetProperty(GridViewSortExpression).GetValue(x, null)).ToList();
            }
            else
            {
                GridViewSortDirection = SortDirection.Ascending;
                OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities();
                var lst = obj.GetScreenMovieDetails().ToList();
                GreedScreenMovie.DataSource = lst.OrderBy(x => x.GetType().GetProperty(GridViewSortExpression).GetValue(x, null)).ToList();
            }
            GreedScreenMovie.DataBind();
        }

        protected void GreedScreenMovie_DataBound(object sender, EventArgs e)
        {
        //    GridViewRow row = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Normal);
        //    for (int i = 0; i < GreedScreenMovie.Columns.Count; i++)
        //    {
        //        TableHeaderCell cell = new TableHeaderCell();
        //        TextBox txtSearch = new TextBox();
        //        txtSearch.Attributes["placeholder"] = GreedScreenMovie.Columns[i].HeaderText;
        //        txtSearch.CssClass = "search_textbox";
        //        cell.Controls.Add(txtSearch);
        //        row.Controls.Add(cell);
        //    }
        //    GreedScreenMovie.HeaderRow.Parent.Controls.AddAt(1, row);
        }
    }
}