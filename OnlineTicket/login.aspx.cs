using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataModel;
namespace WebSite
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            UserBL log = new UserBL();
            User u = new User();
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
                UserBL log = new UserBL();
                AesEncrypt encrypt = new AesEncrypt();
                User user = new User();
                UserBL userbl = new UserBL();
                user.Encrypt = "AES";
                user.PasswordIv = UserName.Text;
                user.Password = encrypt.EncryptText(UserName.Text, Password.Text);
                user.Name = Name.Text;
                user.UserName = UserName.Text;
                user.IsActive = true;
                user.TypeId = log.typeid("Customer");
                userbl.AddUser(user);
                Response.Redirect("~/CustomerDetail.aspx");
            }
            else
            {
                signupmessage.Text = "Information is not as per requirement";
            }
        }
      
    }
}