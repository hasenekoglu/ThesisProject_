﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThesisProject_.Author;
using ThesisProject_.Cosupervisor;
using ThesisProject_.instutues;
using ThesisProject_.supervisor;
using ThesisProject_.university;

namespace ThesisProject_.thesis
{
    public partial class thesis_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                ThesisProjectDataTableAdapters.AUTHORSTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORSTableAdapter();
                ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter();
                ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
                ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
                ThesisProjectDataTableAdapters.INSTITUTESTableAdapter instute = new ThesisProjectDataTableAdapters.INSTITUTESTableAdapter();
                ThesisProjectDataTableAdapters.LANGUAGESTableAdapter language = new ThesisProjectDataTableAdapters.LANGUAGESTableAdapter();
                ThesisProjectDataTableAdapters.TYPESTableAdapter type = new ThesisProjectDataTableAdapters.TYPESTableAdapter();
                ThesisProjectDataTableAdapters.KEYWORDSTableAdapter keyword = new ThesisProjectDataTableAdapters.KEYWORDSTableAdapter();
                ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();


               /* int id = Convert.ToInt32(Request.QueryString["id"]);
                int pageNum = thesis.GEtThesis(id)[0].NUMBEROFPAGE;
                string abs = thesis.GEtThesis(id)[0].ABSTRACT;
                DateTime year = thesis.GEtThesis(id)[0].YEAR;*/




                authorList.Items.Clear();
                authorList.DataSource = author.GetAllAuthors();
                authorList.Items.Add(new ListItem("Choose your Author Lastname"));
                authorList.AppendDataBoundItems = true;
                authorList.DataTextField = "SURNAME";
                authorList.DataValueField = "ID";
                authorList.DataBind();
                




                supervisorList.Items.Clear();
                supervisorList.DataSource = supervisor.GetAllSupervisor();
                supervisorList.Items.Add(new ListItem("Choose your supervisor Lastname"));
                supervisorList.AppendDataBoundItems = true;
                supervisorList.DataTextField = "SURNAME";
                supervisorList.DataValueField = "ID";
                supervisorList.DataBind();
               


                cosupervisorList.Items.Clear();
                cosupervisorList.DataSource = cosupervisor.GetAllSupervisor();
                cosupervisorList.Items.Add(new ListItem("Choose your cosupervisor Lastname"));
                cosupervisorList.AppendDataBoundItems = true;
                cosupervisorList.DataTextField = "SURNAME";
                cosupervisorList.DataValueField = "ID";
                cosupervisorList.DataBind();
                


                universityList.Items.Clear();
                universityList.DataSource = university.GetAllUniversity();
                universityList.Items.Add(new ListItem("Choose your university"));
                universityList.AppendDataBoundItems = true;
                universityList.DataTextField = "NAME";
                universityList.DataValueField = "ID";
                universityList.DataBind();
               


                instutueList.Items.Clear();
                instutueList.DataSource = instute.GetAllInstutues();
                instutueList.Items.Add(new ListItem("Choose your instute"));
                instutueList.AppendDataBoundItems = true;
                instutueList.DataTextField = "INSTUTUE";
                instutueList.DataValueField = "ID";
                instutueList.DataBind();
             

                languageList.Items.Clear();
                languageList.DataSource = language.GetAllLanguages();
                languageList.Items.Add(new ListItem("Choose your language"));
                languageList.AppendDataBoundItems = true;
                languageList.DataTextField = "LANGUAGE";
                languageList.DataValueField = "ID";
                languageList.DataBind();
              


                typeList.Items.Clear();
                typeList.DataSource = type.GetAllTypes();
                typeList.Items.Add(new ListItem("Choose your type"));
                typeList.AppendDataBoundItems = true;
                typeList.DataTextField = "TYPE";
                typeList.DataValueField = "ID";
                typeList.DataBind();
            

                keywordList.Items.Clear();
                keywordList.DataSource = keyword.GetAllKeywords();
                keywordList.Items.Add(new ListItem("Choose your Keyword"));
                keywordList.AppendDataBoundItems = true;
                keywordList.DataTextField = "KEYWORDS_NAME";
                keywordList.DataValueField = "ID";
                keywordList.DataBind();
             

             // string numPage = Convert.ToString(pageNum);
             //   string loadedYear = Convert.ToString(year);

             //   txtPageNum.Text = numPage;
              //  txtAbstract.Text = abs;
               // txtYear.Text = loadedYear;



            }





        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();
            int thesisID = Convert.ToInt32(Request.QueryString["id"]);
            int authorId = Convert.ToInt32(authorList.SelectedItem.Value);
            int supervisorId = Convert.ToInt32(supervisorList.SelectedItem.Value);
            int cosupervisorId = Convert.ToInt32(cosupervisorList.SelectedItem.Value);
            int universityId = Convert.ToInt32(universityList.SelectedItem.Value);
            int instutueId = Convert.ToInt32(instutueList.SelectedItem.Value);
            int languageId = Convert.ToInt32(languageList.SelectedItem.Value);
            int typeId = Convert.ToInt32(typeList.SelectedItem.Value);
            int keywordId = Convert.ToInt32(keywordList.SelectedItem.Value);
            DateTime currentDateTime = DateTime.Now;

            int PageNumber = Convert.ToInt32(txtPageNum.Text);


            thesis.ThesisAdd(authorId, universityId, typeId, instutueId, languageId, supervisorId, cosupervisorId, PageNumber, txtAbstract.Text, txtYear.Text, currentDateTime, keywordId);
            Response.Redirect("/thesis/thesis_list.aspx");

        }
    }
}
