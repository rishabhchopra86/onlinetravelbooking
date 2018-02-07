using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataModel;
using Model;
namespace OnlineTicket
{
    public partial class CustomerDetail : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CityBL city = new CityBL();
           
            DropDownList1.DataValueField = "CityName";
            DropDownList1.DataTextField = "Id";
            DropDownList1.DataSource = city.GetallCitiesbyCountry(101);
            DropDownList1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            CityBL city = new CityBL();
            customer.Address = address.Value;
            customer.AlternatePhoneNo = Convert.ToInt32(AlternateNumber.Text);
            customer.CityId = city.getCityId(DropDownList1.SelectedValue.ToString());
            customer.CreatedBy = Convert.ToInt32(Session["Id"].ToString());
            customer.CreatedDate = DateTime.Now;
            customer.UserId = Convert.ToInt32(Session["Id"].ToString());
            customer.PostalCode = Convert.ToInt32(PostalCode.Text);
            customer.PhoneNo =PhoneNumber.Text;
            customer.PassportNo = PassportNumber.Text;
            customer.PassportCountryId = Convert.ToInt32(PassportCountry.Text);
            customer.Nationality = Nationality.Text;
            customer.MiddleName = MiddleName.Text;
            customer.FirstName = FisrstName.Text;
            customer.DOB = Convert.ToDateTime(DOB.Text);
            customer.ExpiryDateOfPassport = Convert.ToDateTime(ExpireDate.Text);
            customer.Fax = Fax.Text;
            customer.IsActive = true;
            CustomerBL customerbl = new CustomerBL();
            customerbl.AddCustomer(customer);
            Response.Redirect("~/Default.aspx");
        }
    }
}