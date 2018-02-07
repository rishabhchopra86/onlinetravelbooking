using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using Model;
namespace WebSite
{
    public partial class movies : System.Web.UI.Page
    {
        MovieBL moviebl;
        static string Name;
        string disp;
        MasterBL masterbl;
        static List<CheckBox> langChckBox;
        static List<CheckBox> TypeChckBox;
        static List<int> SearchIdLang;
        static List<int> SearchIdType;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            moviebl = new MovieBL();
            masterbl = new MasterBL();
            if (!this.IsPostBack)
            {
                CityBL city = new CityBL();


                disp = moviebl.getAllMovieByCityIdDisplay(0, "", "");
                display.InnerHtml = disp;
                var masterLanguage = masterbl.getMasterValues(3);
                langChckBox = new List<CheckBox>();
                TypeChckBox = new List<CheckBox>();
                SearchIdLang = new List<int>();
                SearchIdType = new List<int>();
                foreach (MasterValue m in masterLanguage)
                {
                    
                    CheckBox c = new CheckBox();
                    c.Text = m.Description;
                    c.ID = m.Id.ToString();
                    c.AutoPostBack = true;
                    c.TextAlign = TextAlign.Right;
                    c.CheckedChanged += new EventHandler(LanguageCheck);
                    listcheckboxLanguage.Controls.Add(c);
                    
                    langChckBox.Add(c);
                    //listcheckboxLanguage.InnerHtml+= "<div class='checkbox'><input  type='checkbox'  onChange='UpdatePanel(this)' value='"+m.Description+"'/><label>" + m.Description+"</label></div>";
                }
                var masterType = masterbl.getMasterValues(4);
                foreach (MasterValue m in masterType)
                {
                    CheckBox c = new CheckBox();
                    c.Text = m.Description;
                    c.AutoPostBack = true;
                    c.ID = m.Id.ToString();
                    listcheckboxType.Controls.Add(c);
                    c.CheckedChanged += new EventHandler(TypeCheck);
                    TypeChckBox.Add(c);
                    //listcheckboxType.InnerHtml += "<div class='checkbox'><label><input  type='checkbox'  onChange='UpdatePanel(this)'  value='" + m.Description + "'/>" + m.Description + "</label></div>";
                }
            }
            else
            {
                foreach (CheckBox item in langChckBox)
                {
                    item.CheckedChanged += new EventHandler(LanguageCheck);
                    listcheckboxLanguage.Controls.Add(item);
                }
                foreach (CheckBox item in TypeChckBox)
                {
                    item.CheckedChanged += new EventHandler(TypeCheck);
                    listcheckboxType.Controls.Add(item);
                }
            }
            }

        private void LanguageCheck(object sender, EventArgs e)
        {
            CheckBox checkBox = (sender as CheckBox);
            if (checkBox.Checked)
            {
                SearchIdLang.Add(Convert.ToInt32(checkBox.ID));
            }
            else
            {
                SearchIdLang.Remove(Convert.ToInt32(checkBox.ID));
            }
            display.InnerHtml = moviebl.getAllMovieByCityIdDisplayFilter(0, "", MovieName.Text, SearchIdLang, SearchIdType);
        }
        private void TypeCheck(object sender, EventArgs e)
        {
            CheckBox checkBox = (sender as CheckBox);
            if (checkBox.Checked)
            {
                SearchIdType.Add(Convert.ToInt32(checkBox.ID));
            }
            else
            {
                SearchIdType.Remove(Convert.ToInt32(checkBox.ID));
            }
            display.InnerHtml = moviebl.getAllMovieByCityIdDisplayFilter(0, "", MovieName.Text, SearchIdLang, SearchIdType);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
        
            CityBL cities = new CityBL();
            Name = MovieName.Text;
                display.InnerHtml = moviebl.getAllMovieByCityIdDisplay(0, "", MovieName.Text);
          
        }
       

      
    }
}