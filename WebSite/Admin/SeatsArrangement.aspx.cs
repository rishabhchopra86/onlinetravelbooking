using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite.Admin
{
    public partial class SeatsArrangement : System.Web.UI.Page
    {
        List<string> Values=new List<string>();
        //int n1 = Convert.ToInt16(txtRows.Text);
        //int n2 = Convert.ToInt16(txtColumns.Text);

        int n1, n2;
        static int tmp = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //{
            //    for (var i = 0; i < TextBoxCount; i++)
            //    { }
            //        //AddTextBox(i);
            //}


        }

        //private int TextBoxCount
        //{
        //    get
        //    {
        //        var count = ViewState["txtBoxCount"];
        //        return (count == null) ? 0 : (int)count;
        //    }
        //    set { ViewState["txtBoxCount"] = value; }
        //}



        protected void btnAddTextBox_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(txtRows.Text);
            n2 = Convert.ToInt32(txtColumns.Text);
            //   Response.Write(n1);

            dynamic.InnerHtml = "";
            for (int k = 0; k < n1; k++)
            {

                for (int l = 0; l < n2; l++)
                {

                    //var txt = new TextBox { ID = string.Concat("txtDynamic", tmp) };
                    //txt.Style.Add("display", "inline");
                    //txt.Style.Add("width", "30px");
                    //txt.Style.Add("background", "grey");
                    //txt.Style.Add("padding-top", "10px");
                    //phControls.Controls.Add(txt);

                    dynamic.InnerHtml += "<input type='text' name='txtDynamic" + tmp + "' style='width:30px;margin:5px;' id='txtDynamic" + tmp + "' runat='server'/>";
                    tmp++;

                }
                dynamic.InnerHtml += "<br>";

            }
        }

        protected void btnWriteValues_Click(object sender, EventArgs e)
        {
            /*foreach (var control in phControls.Controls)
            {
                var textBox = control as TextBox;
                if (textBox == null) continue;
                Response.Write(string.Concat(textBox.Text, "<br />"));
            }*/
            int tot = 0;
            for (var i = 0; i < tmp; i++)
            {
                //var txtbox = control as TextBox;
                //if (txtbox == null)
                //{
                //    continue;
                //}
                //Response.Write(dynamic.InnerHtml);

                string[] textboxValues = Request.Form.GetValues("txtDynamic" + i);

                // Values[i] = textboxValues.ToString();
                string textboxValues1 = textboxValues[0] == "" ? "0" : textboxValues[0];

                textboxValues = textboxValues1.Split();

                int[] val = Array.ConvertAll(textboxValues, int.Parse);
               // tot = val.Count();
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Values.Add(serializer.Serialize(val[0]));
            }
            dynamic.InnerHtml = "";
            n1 = Convert.ToInt32(txtRows.Text);
            n2 = Convert.ToInt32(txtColumns.Text);
            //   Response.Write(n1);

            dynamic.InnerHtml = "";
            int cnt = 0;
            tot = Values.Count();
            string[,] arr=new string[tot,tot];
            for (int k = 0; k < n1; k++)
            {
                for (int l = 0; l < n2; l++)
                {
                    if (Values[cnt]!="0")
                    {
                        arr[k,l] =Values[cnt];
                        dynamic.InnerHtml += "<input type='button' value='" + Values[cnt] + "' style='width:30px;margin:5px;' runat='server'/>";
                        cnt++;
                    }
                    else
                    {
                        arr[k, l] = "";
                        dynamic.InnerHtml += "<span style='width:10px;margin-left:40px;'></span>";
                        cnt++;
                    }
                }
                dynamic.InnerHtml += "<br>";

            }

        }
    }
}