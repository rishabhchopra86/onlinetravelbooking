using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataModel;
using WebSite.Admin;

namespace WebSite.Admin
{
    public partial class AddTheatre : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CityBL city = new CityBL();
                selCity.DataSource = city.GetAllCities();
                selCity.DataTextField = "CityName";
                selCity.DataValueField = "Id";
                selCity.DataBind();

                AgentBL agent = new AgentBL();
                selAgent.DataSource = agent.GetAllAgent();
                selAgent.DataTextField = "TravellerName";
                selAgent.DataValueField = "Id";
                selAgent.DataBind();

                fillGrid();
            }
        }
        public void fillGrid()
        {
            try
            {
                //OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities();
                //GreedTheatre.DataSource = obj.getAllCinemas().ToList();
                //GreedTheatre.DataBind();
            }
            catch (Exception exp)
            {

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema cinema = new Cinema();
                cinema.Address = txtAddress.Value;
                cinema.CityId = Convert.ToInt32(selCity.SelectedItem.Value);
                cinema.Email = txtEmail.Value;
                cinema.Name = txtTheatreName.Value;
                cinema.Langitude = Convert.ToDecimal(txtLongitude.Value);
                cinema.Lattitude = Convert.ToDecimal(txtLattitude.Value);
                cinema.Description = txtTheatreDesc.Value;
                cinema.AgentId = Convert.ToInt32(selAgent.SelectedItem.Value);
                cinema.IsActive = true;
                cinema.PhoneNo = txtPhoneNumber.Value;
                CinemaBL cinemabl = new CinemaBL();
                cinemabl.AddCinema(cinema);

                DataModel.Image img = new DataModel.Image();

                ImageBL imagebl = new ImageBL();
                if (file.HasFile)
                {
                    try
                    {
                        ImageCompress imgCompress = ImageCompress.GetImageCompressObject;
                        imgCompress.GetImage = new System.Drawing.Bitmap(file.FileContent);
                        imgCompress.Height = 400;
                        imgCompress.Width = 800;

                        var fnm = "TheatrePic" + Guid.NewGuid().ToString() + System.IO.Path.GetExtension(file.FileName);
                        string path = Server.MapPath("~/Images/Theatre/");
                        string filename = System.IO.Path.Combine(path, fnm);
                        imgCompress.Save(fnm, path);


                        img.ImageName = fnm;
                        img.Path = filename;
                        img.Description = "Image of Theatre";
                        img.RTId = cinema.Id;
                        img.IsActive = true;

                        UserBL userbl = new UserBL();
                        img.TypeId = userbl.typeid("Cinemas");

                        imagebl.AddImage(img);

                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message.ToString());
                    }
                }
                txtAddress.Value = txtEmail.Value = txtLattitude.Value = txtLongitude.Value = txtPhoneNumber.Value = txtTheatreDesc.Value = txtTheatreName.Value = string.Empty;
            }
            catch (Exception exp)
            {

            }
        }
      
    }
}