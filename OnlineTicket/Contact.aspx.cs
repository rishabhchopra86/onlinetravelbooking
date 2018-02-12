using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;
using System.Net;
using System.Net.Mail;

namespace WebSite
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmsg_Click(object sender, EventArgs e)
        {

            ContactU contact = new ContactU();
            contact.Name = txtname.Value;
            contact.Email = txtemail.Value;
            contact.PhoneNo = txtno.Value;
            contact.Message = txtmessage.Value;
            contact.CreatedDate = DateTime.Now;
            ContactUsBL contactbl = new ContactUsBL();
            bool val=sendmail();
            contact.SentEmail = val;
            contactbl.AddContactUs(contact);
            clear();
        }
        public void clear()
        {
            txtname.Value = "";
            txtemail.Value = "";
            txtmessage.Value = "";
            txtno.Value = "";
        }
        public bool sendmail()
        {

            using (MailMessage mm = new MailMessage("lanetteam.krishna@gmail.com", txtemail.Value))
            {
                try
                {
                    mm.Subject = txtmessage.Value;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("lanetteam.krishna@gmail.com", "lanetteam1");
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
                    return true;
                }
                catch(Exception exp)
                {
                    return false;
                }
            }
        }
    }
}
