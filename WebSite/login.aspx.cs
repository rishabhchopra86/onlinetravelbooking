using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
namespace WebSite
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Loginout log = new Loginout();
            UserClass u = new UserClass();
            u=log.login(loginUserName.Text, loginPassword.Text);
            if (u.TypeId != null)
            {
                Session["type"] = log.typeName((int)u.TypeId);
               
                if(Session["type"].ToString()=="Customer")
                {
                    Response.Redirect("~/profile.aspx");
                    Session["Id"] = log.CustomerId((int)u.Id);
                }
                else 
                {
                    if (Session["type"].ToString() == "Agent")
                    {
                        Session["Id"] = u.Id.ToString();
                    }
                    else
                    {
                        Session["Id"] = u.Id.ToString();
                    }
                    // Response.Redirect("~/admin/profile.aspx");
                    Response.Redirect("~/");
                }
            }
            else
            {
                errorlogin.Text = "InValid UserName and Password";
            }
                

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text != "" && Password.Text != "" && Name.Text != "")
            {
                Loginout log = new Loginout();
                AesEncrypt encrypt = new AesEncrypt();
                String timeStamp = GetTimestamp(DateTime.Now);
                UserClass user = new UserClass();
                user.Encrypt = "AES";
                user.PasswordIv = timeStamp;
                user.Password = Password.Text;
                user.Name = Name.Text;
                user.UserName = UserName.Text;
                user.IsActive = true;
                user.TypeId = log.typeid("Customer");
                user.AddUser();
                Response.Redirect("~/CustomerDetail.aspx");
            }
            else
            {
                signupmessage.Text = "Information is not as per requirement";
            }
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}