using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class booknow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();

            TextBox textbox = new TextBox();
            int count = Panel2.Controls.OfType<TextBox>().ToList().Count;
            textbox.Location = new System.Drawing.Point(60, 25 * count);
            textbox.Size = new System.Drawing.Size(80, 20);
            textbox.Name = "textbox_" + (count + 1);
            textbox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            Panel2.Controls.Add(textbox);

        }

        protected void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}