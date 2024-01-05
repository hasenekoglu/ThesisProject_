using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.userViews
{
    public partial class user_thesis_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();
            thesisList.DataSource = thesis.GetAllThesis();
            thesisList.DataBind();
        }

        public string getAuthorName(int authorId)
        {
            ThesisProjectDataTableAdapters.AUTHORSTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORSTableAdapter();
            string authorName = " ";
            string authorSurname = " ";
            try
            {
                authorName = author.AuthorGet(authorId)[0].NAME;
                authorSurname = author.AuthorGet(authorId)[0].SURNAME;
            }
            catch
            {
                authorName = "-";
                authorSurname = "-";
            }
            return authorName + " " + authorSurname;
        }
        public string getSupervisorName(int supervisorId)
        {
            ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter();
            string supervisorName = " ";
            string supervisorSurname = " ";
            try
            {
                supervisorName = supervisor.SupervisorGet(supervisorId)[0].NAME;
                supervisorSurname = supervisor.SupervisorGet(supervisorId)[0].SURNAME;
            }
            catch
            {
                supervisorName = "-";
                supervisorSurname = "-";
            }
            return supervisorName + " " + supervisorSurname;
        }
        public string getCoSupervisorName(int CoSupervisorId)
        {
            ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
            string CoSupervisorName = " ";
            string CoSupervisorSurname = " ";
            try
            {
                CoSupervisorName = cosupervisor.CosupervisorGet(CoSupervisorId)[0].NAME;
                CoSupervisorSurname = cosupervisor.CosupervisorGet(CoSupervisorId)[0].SURNAME;
            }
            catch
            {
                CoSupervisorName = "-";
                CoSupervisorSurname = "-";
            }
            return CoSupervisorName + " " + CoSupervisorSurname;
        }
        public string getUniversityName(int universityId)
        {
            ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
            string universityName = " ";
            try
            {
                universityName = university.GetUniversity(universityId)[0].NAME;
            }
            catch
            {
                universityName= "-";
            }
            return universityName;
        }
        public string getInstutes(int instutueId)
        {
            ThesisProjectDataTableAdapters.INSTITUTESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTITUTESTableAdapter();
            string instutue = " ";
            try
            {
                instutue = instutues.GetInstutues(instutueId)[0].INSTUTUE;
            }
            catch
            {
                instutue = "-";
            }
            return instutue;
        }
        public string getLanguage(int languageId)
        {
            ThesisProjectDataTableAdapters.LANGUAGESTableAdapter lang = new ThesisProjectDataTableAdapters.LANGUAGESTableAdapter();
            string language = " ";
            try
            {
                language = lang.GetLanguage(languageId)[0].LANGUAGE;
            }
            catch
            {
                language = "-";
            }
            return language;
        }
        public string getType(int TypeId)
        {
            ThesisProjectDataTableAdapters.TYPESTableAdapter types = new ThesisProjectDataTableAdapters.TYPESTableAdapter();
            string type = " ";
            try
            {
                type = types.GetType(TypeId)[0].TYPE;

            }
            catch
            {
                type = "-";
            }
            return type;
        }
        public string getKeyword(int keywordId)
        {
            ThesisProjectDataTableAdapters.KEYWORDSTableAdapter key = new ThesisProjectDataTableAdapters.KEYWORDSTableAdapter();
            string keyword = " ";
            try
            {
                keyword = key.GetKeyword(keywordId)[0].KEYWORDS_NAME;
            }
            catch
            {
                keyword = "-";
            }
            return keyword;
        }
    }
}