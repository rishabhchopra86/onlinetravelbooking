using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Configuration;



namespace WebSite.Admin
{
    public partial class DynamicControls : System.Web.UI.Page
    {

        TextBox txtbox;
        Random rd=new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i <= 5; i++)
            //{
            //    txtbox = new TextBox();
            //    txtbox.ID = "txtBox" + i;
            //    txtbox.MaxLength = 20;
            //    txtbox.Width = 50;
            //    txtbox.Style = "padding:20px";
            //    txtbox.Height=50;
            //    txtbox.Text = rd.Next(1, 10).ToString();
            //    PlaceHolder1.Controls.Add(txtbox);

            //}

            for (int m = 0; m < 5; m++)
            {
                for (int n = 0; n < 5; n++)
                {
                    txtbox = new TextBox();
                    txtbox.ID = "txtBox" + m+n;
                    txtbox.MaxLength = 20;
                    txtbox.Width = 50;
                                        
                     //txtbox.location = new Point(20,25);
                 //   txtbox.Style = "padding:20px";
                    txtbox.Height = 50;
                    txtbox.Text = rd.Next(1, 10).ToString();
                    PlaceHolder1.Controls.Add(txtbox);
                }
            }
        }
    }
}