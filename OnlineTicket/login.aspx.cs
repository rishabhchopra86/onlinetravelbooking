using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataModel;
using Newtonsoft.Json.Linq;

namespace WebSite
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            const string secretKey = "6LcajkQUAAAAANoDrOqCJY2RkmVqtG5SAn-3fZNw";
            string userResponse = Request.Form["g-Recaptcha-Response"];

            var webClient = new System.Net.WebClient();
            string verification = webClient.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, userResponse));

            var verificationJson = Newtonsoft.Json.Linq.JObject.Parse(verification);
            if (verificationJson["success"].Value<bool>())
            {




                UserBL log = new UserBL();
                User u = new User();
                u = log.login(loginUserName.Text, loginPassword.Text);
                if (u != null)
                {
                    Session["type"] = log.typeName((int)u.TypeId);

                    if (Session["type"].ToString() == "Customer")
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
            else
            {
                errorlogin.Text = "InValid Captcha";
            }
                

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text != "" && Password.Text != "" && Name.Text != "")
            {

                UserBL userbl = new UserBL();
                if (userbl.emailPresent(UserName.Text))
                {
                    AesEncrypt encrypt = new AesEncrypt();
                    User user = new User();
                    user.Encrypt = "AES";
                    user.PasswordIv = UserName.Text;
                    user.Password = encrypt.EncryptText(Password.Text, UserName.Text);
                    user.Name = Name.Text;
                    user.UserName = UserName.Text;
                    user.IsActive = true;
                    user.TypeId = userbl.typeid("Customer");
                    userbl.AddUser(user);
                    Session["Id"] = user.Id.ToString();
                    Response.Redirect("~/CustomerDetail.aspx");
                }
                else
                {
                    signupmessage.Text = "Email is already present";
                }
            }
            else
            {
                signupmessage.Text = "Information is not as per requirement";
            }
        }
      
    }
}