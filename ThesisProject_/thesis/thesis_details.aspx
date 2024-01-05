<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thesis_details.aspx.cs" Inherits="ThesisProject_.thesis.thesis_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../assets/thesis_details.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
             <h1>Thesis details </h1>
                    <div class="buttons">
               <a href="thesis_list.aspx" role="button" class="btn btn-success">Back to Thesis List</a>
               <a href="../Author/author_list.aspx" role="button" class="btn btn-success">Back to Author List</a>
               <a href="../university/university_list.aspx" role="button" class="btn btn-success">Back to University List</a>
               <a href="../supervisor/supervisor_list.aspx" role="button" class="btn btn-success">Back to Supervisor List</a>
               <a href="../Cosupervisor/Cosupervisor_list.aspx" role="button" class="btn btn-success">Back to Cosupervisor List</a>
               <a href="../languages/languages_list.aspx" role="button" class="btn btn-success">Back to Language List</a>
               <a href="../city/city_list.aspx" role="button" class="btn btn-success">Back to City List</a>
             </div>
            <asp:Repeater runat="server" ID="thesisList">
                 <ItemTemplate>
                     
      <h3> Thesis number :  <%# Eval("ID") %></h3>
              <h3> Author Name: <%# getAuthorName(Convert.ToInt32(Eval("AUTHORID"))) %></h3>
              <h3> Supervisor Name: <%#getSupervisorName(Convert.ToInt32(Eval("SUPERVISORID"))) %></h3>
              <h3> Cosupervisor Name : <%#getCoSupervisorName(Convert.ToInt32(Eval("COSUPERVISORID"))) %></h3>
              <h3> University Name : <%# getUniversityName(Convert.ToInt32(Eval("UNIVERSITYID"))) %></h3>
              <h3> Instutue : <%# getInstutes(Convert.ToInt32(Eval("INSTITUTEID"))) %></h3>
              <h3> Language : <%# getLanguage(Convert.ToInt32(Eval("LANGUAGEID"))) %></h3>
              <h3> Type : <%# getType(Convert.ToInt32(Eval("TYPEID"))) %></h3>
              <h3> Keyword : <%# getKeyword(Convert.ToInt32(Eval("TITLEID"))) %></h3>
              <h3> Page Number : <%# Eval("NUMBEROFPAGE") %></h3>
              <h3> Abstarct :  <%# Eval("ABSTRACT") %></h3>
              <h3> Year :<%# Eval("YEAR") %></h3>
              <h3> Submission Date :<%# Eval("SUBMISSIN") %></h3>

     <asp:HyperLink NavigateUrl='<%# "thesis_delete.aspx?id=" + Eval("ID") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
     <asp:HyperLink NavigateUrl='<%# "thesis_edit.aspx?id=" + Eval("ID") %>' runat="server" CssClass="btn btn-success">Edit</asp:HyperLink>

</h3>
                 </ItemTemplate>
             </asp:Repeater>

        </div>
    </form>
</body>
</html>
