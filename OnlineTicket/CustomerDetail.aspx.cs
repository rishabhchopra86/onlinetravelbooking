using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;
namespace WebSite
{
    public partial class CustomerDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
           
            customer.Address = address.Value;
           
            customer.AlternatePhoneNo = Convert.ToInt32( AlternateNumber.Text);
            customer.CityId = 1;
            customer.CreatedBy = Convert.ToInt32(Session["Id"].ToString());
            customer.CreatedDate = DateTime.Now;
            customer.UserId= Convert.ToInt32(Session["Id"].ToString());
            customer.PostalCode = Convert.ToInt32(PostalCode.Text);
            customer.PhoneNo = Convert.ToInt32(PhoneNumber.Text);
            customer.PassportNo =PassportNumber.Text;
            customer.PassportCountryId = Convert.ToInt32(PassportCountry.Text);
            customer.Nationality = Nationality.Text;
            customer.MiddleName = MiddleName.Text;
            customer.FirstName = FisrstName.Text;
            customer.DOB = Convert.ToDateTime(DOB.Text);
            customer.ExpiryDateOfPassport =Convert.ToDateTime( ExpireDate.Text);
            customer.Fax = Fax.Text;
            customer.IsActive = true;
            CustomerBL customerbl = new CustomerBL();
            customerbl.AddCustomer(customer);
            Response.Redirect("~/Default.aspx");
        }
    }
}