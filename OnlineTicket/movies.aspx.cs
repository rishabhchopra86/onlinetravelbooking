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
        static List<Movie> movieList;
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
                movieList = moviebl.getAllMovieByCityIdDisplay(0, "", "");

                displayMovie(movieList);
               
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
            displayMovie( moviebl.getAllMovieByCityIdDisplayFilter(0, "", Name, SearchIdLang, SearchIdType,movieList));
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
            displayMovie(moviebl.getAllMovieByCityIdDisplayFilter(0, "", Name, SearchIdLang, SearchIdType,movieList));
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
        
            CityBL cities = new CityBL();
            Name = MovieName.Text;
            movieList = moviebl.getAllMovieByCityIdDisplay(0, "", Name);
            displayMovie(movieList);
          
        }
       public void displayMovie(List<Movie> lst)
        {
            string displaymovies = "";
            Rating r = new Rating();
            if (lst == null)
            {
                displaymovies += "<div class='col-md-3'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='#'>" +
                        "                                        <img src = 'img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";

                displaymovies += "                                    </ul>" +
                           "                                    <h5 class='thumb-title'><a class='text-darken' href='#'>No Data Found</a></h5>" +

                           "                                </div>" +
                           "                            </div>" +
                           "                        </div>";
            }
            else
            {
                foreach (Movie c in lst)
                {
                    displaymovies += "<div class='col-md-3'>" +
                        " <div class='thumb'>" +
                        " <header class='thumb-header'>" +
                        "                                    <a class='hover-img' href='moviecity.aspx?Id=movi_" + c.Id + "'>" +
                        "                                        <img src = 'img/lhotel_porto_bay_sao_paulo_lobby_800x600.jpg' alt='Image Alternative text' title='LHOTEL PORTO BAY SAO PAULO lobby' />" +
                        "                                        <h5 class='hover-title-center'>See Detail</h5>" +
                        "                                    </a>" +
                        "                                    </header>" +
                        "                                    <div class='thumb-caption'>" +
                        "                                    <ul class='icon-group text-tiny text-color'>";
                    if (c.TotalRatings == null)
                    {
                        displaymovies += r.rate(0);
                    }
                    else
                    {
                        displaymovies += r.rate((double)c.TotalRatings);
                    }

                    displaymovies += "                                    </ul>" +
                               "                                    <h5 class='thumb-title'><a class='text-darken'  href='moviecity.aspx?Id=movi_" + c.Id + "'>" + c.Name + "</a></h5>" +
                                "                                  <p class='mb0'><small><i class='fa fa-clock'></i> " + c.Duration + "</small>" +
                               "                                    </p>" +
                               "                                   <p class='mb0'><small>Language : " + moviebl.typeName((int)c.MovieLanguage) + "  | Type : " + moviebl. typeName((int)c.MovieType) + "</small>" +
                               "                                    </p>" +
                               "                                </div>" +
                               "                            </div>" +
                               "                        </div>";
                }
            }
            display.InnerHtml = displaymovies;
        }

      
    }
}