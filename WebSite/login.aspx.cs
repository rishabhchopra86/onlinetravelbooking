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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AesEncrypt encrypt = new AesEncrypt();
            String timeStamp = GetTimestamp(DateTime.Now);
            UserClass user = new UserClass();
            user.Encrypt = "AES";
            user.PasswordIv = timeStamp;
            user.Password = Password.Text;
            user.Name = Name.Text;
            user.UserName = UserName.Text;
            user.IsActive = true;
            user.TypeId = 1;
            user.AddUser();
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}