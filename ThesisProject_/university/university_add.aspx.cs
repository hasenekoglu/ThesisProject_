using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.university
{
    public partial class university_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ThesisProjectDataTableAdapters.CITYTableAdapter cities = new ThesisProjectDataTableAdapters.CITYTableAdapter();
                universityCombo.Items.Clear();
                universityCombo.Items.Add(new ListItem("Chooose Your City"));
                universityCombo.AppendDataBoundItems = true;
                universityCombo.DataSource = cities.GetAllCities();
                universityCombo.DataTextField = "CITY_NAME";
                universityCombo.DataValueField = "ID";
                universityCombo.DataBind();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
            int cityId = Convert.ToInt32(universityCombo.SelectedItem.Value);
            university.UniversityAdd(txtUniversityName.Text, cityId);
            Response.Redirect("/university/university_list.aspx");

        }
    }
}