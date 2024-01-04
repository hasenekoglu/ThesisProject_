using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.city
{
    public partial class city_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.CITYTableAdapter city = new ThesisProjectDataTableAdapters.CITYTableAdapter();
            CityList.DataSource = city.GetAllCities();
            CityList.DataBind();    
        }
    }
}