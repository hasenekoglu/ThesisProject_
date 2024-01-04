using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.university
{
    public partial class university_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
            ThesisProjectDataTableAdapters.CITYTableAdapter city = new ThesisProjectDataTableAdapters.CITYTableAdapter();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            string universityName = university.GetUniversity(id)[0].NAME;
            string cityName = city.GetCity(id)[0].CITY_NAME;

            txtUniversityName.Text = universityName;

            cityCombo.Items.Clear();
            cityCombo.DataSource = city.GetAllCities();
            cityCombo.DataTextField = "CITY_NAME";
            cityCombo.DataValueField = "ID";
            cityCombo.DataBind();

            cityCombo.SelectedIndex = cityCombo.Items.IndexOf(cityCombo.Items.FindByText(cityName));

            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
             int universityid = Convert.ToInt32(Request.QueryString["id"]);
            int cityId = Convert.ToInt32(cityCombo.SelectedItem.Value);
            university.UniversityUpdate(txtUniversityName.Text, cityId, universityid);
            Response.Redirect("/university/university_list.aspx");

        }
    }
}