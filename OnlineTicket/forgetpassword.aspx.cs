using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;
using System.Net.Mail;

namespace OnlineTicket
{
    public partial class forgetpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBL userbl = new UserBL();
            if(!userbl.emailPresent(UserName.Text))
            {
                try
                {
                    User user = userbl.getuserbymail(UserName.Text);
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("lanetteam.rishabh@gmail.com");
                    mail.To.Add("lanetteam.rishabh@gmail.com");
                    mail.Subject = "Password Recover From Journey -The Traveler";
                    mail.Body = "<h1>This mail is for reset your password</h1>";
                    AesEncrypt aes = new AesEncrypt();
                    mail.Body+= "<a href='http://localhost:50066/passwordverfiy.aspx?id="+aes.EncryptText(user.Id.ToString(), "key") +"&reset=1'>Click me to verify....</a> ";
                    mail.IsBodyHtml = true;
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("lanetteam.rishabh@gmail.com", "8460192650");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                
                }
                catch (Exception ex)
                {
                    errormessage.InnerText = "Unable to Send Email";
                }
            }
            else
            {
                errormessage.InnerText = "Unable to Find User Name";
            }
        }
    }
}