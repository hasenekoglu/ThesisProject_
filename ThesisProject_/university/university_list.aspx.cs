using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.university
{
    public partial class university_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university =  new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
            universityList.DataSource = university.GetAllUniversity();
            universityList.DataBind();
        }
        public string getCityName(int cityId)
        {
            ThesisProjectDataTableAdapters.CITYTableAdapter city = new ThesisProjectDataTableAdapters.CITYTableAdapter();
            string cityName = " ";
            try
            {
                cityName = city.GetCity(cityId)[0].CITY_NAME;
            }
            catch
            {
                cityName = " - (City has been deleted)  ";
            }
            return cityName;
        }
    }
}