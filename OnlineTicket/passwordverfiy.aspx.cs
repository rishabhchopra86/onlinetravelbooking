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
    public partial class passwordverfiy : System.Web.UI.Page
    {
        UserBL userbl;
        User user;
        AesEncrypt aes;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                 aes = new AesEncrypt();
                
                 userbl = new UserBL();
                userbl.Id= Convert.ToInt32(aes.DecryptText(Request.QueryString["id"].ToString(), "key"));
                 user= userbl.GetByUserid();
                if (user != null)
                {
                    
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            user.Password = user.Password = aes.EncryptText(Password.Text, user.UserName);
            userbl.UpdateUser();
        }
    }
}