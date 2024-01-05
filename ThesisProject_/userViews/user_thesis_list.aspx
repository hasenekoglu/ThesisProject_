<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_thesis_list.aspx.cs" Inherits="ThesisProject_.userViews.user_thesis_list" %>
 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="assets/style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

</head>
<body>

    <div id="wrapper" class="toggled">

        <!-- Sidebar -->
        <nav class="navbar navbar-expand-lg ">
            <a class="navbar-brand navbar-title" href="#"><span>Graduate Thesis System</span></a>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a href ="user_author_list.aspx" role="button"> Authors</a>
                    </li>
                    <li class="nav-item">
                        <a href="user_supervisor_list.aspx" role="button"> Supervisors </a>
                    </li>
                    <li class="nav-item">
                        <a href="user_cosupervisor_list.aspx" role="button">Cosupervisors </a>
                    </li>
                    <li class="nav-item">
                        <a href="user_thesis_list.aspx" role="button"> Thesis</a>
                    </li>
                    <li class="nav-item">
                        <a href="user_university_list.aspx" role="button"> Universities </a>
                    </li>
                    <li class="nav-item">
                        <a href="user_types_list.aspx" role="button"> Types </a>
                    </li>
                    <li class="nav-item">
                        <a href="user_language_list.aspx" role="button"> Language </a>
                    </li>
                </ul>
            </div>
        </nav>
        <!-- /#sidebar-wrapper -->
        <!-- Page Content -->

        <div id="page-content-wrapper">
            <div class="container-fluid">
                <h2 class="table-title"> Thesis List</h2>
<form id="form1" runat="server">
   <table class="table table-bordered table-hover">

          <thead>
              <tr>
                <th>Id</th>
                <th>Author Name</th>
                <th>Supervisor Name</th>
                <th>Cosupervisor Name</th>
                <th>University Name</th>
                <th>Instutues Name</th>
                <th>Langugage</th>
                <th>Type</th>
                <th>Keyword</th>
                <th>Page Number</th>
                <th>Abstract</th>
                <th>Year</th>
                <th>Submisson Date</th>
              </tr>
          </thead>
          <tbody>
              <asp:Repeater runat="server" ID="thesisList">
                  <ItemTemplate>
                    <tr>
                      <td><%# Eval("ID") %></td>
    <td><%# getAuthorName(Convert.ToInt32(Eval("AUTHORID"))) %></td>
    <td><%# getSupervisorName(Convert.ToInt32(Eval("SUPERVISORID"))) %></td>
    <td><%# getCoSupervisorName(Convert.ToInt32(Eval("COSUPERVISORID"))) %></td>
    <td><%# getUniversityName(Convert.ToInt32(Eval("UNIVERSITYID"))) %></td>
    <td><%# getInstutes(Convert.ToInt32(Eval("INSTITUTEID"))) %></td>
    <td><%# getLanguage(Convert.ToInt32(Eval("LANGUAGEID"))) %></td>
    <td><%# getType(Convert.ToInt32(Eval("TYPEID"))) %></td>
    <td><%# getKeyword(Convert.ToInt32(Eval("TITLEID"))) %></td>
    <td><%# Eval("NUMBEROFPAGE") %></td>
                      <td>
                          <asp:HyperLink NavigateUrl='<%# "/thesis/thesis_details.aspx?id=" + Eval("ID") %>' runat="server" CssClass="btn btn-primary">Click here to more details</asp:HyperLink>

                      </td>
                      <td><%# Eval("YEAR") %></td>
                      <td><%# Eval("SUBMISSIN") %></td>
                      
                    </tr>    
                  </ItemTemplate>
              </asp:Repeater>
          </tbody>
      </table>

</form>

            </div>
        </div>
        <!-- /#page-content-wrapper -->
        <!-- Footer -->
        <footer class="footer">
            <div class="footer-links">
                <a class="footer-link" role="button" href="user_author_list.aspx">Authors</a>
                <a class="footer-link" role="button" href="user_supervisor_list.aspx">Supervisors</a>
                <a class="footer-link" role="button" href="user_cosupervisor_list.aspx">Cosupervisors</a>
                <a class="footer-link" role="button" href="user_thesis_list.aspx">Thesis</a>
                <a class="footer-link" role="button" href="user_university_list.aspx">Universities</a>
                <a class="footer-link" role="button" href="user_types_list.aspx">Types</a>
                <a class="footer-link" role="button" href="user_language_list.aspx">Language</a>
            </div>
            <div class="footer-descriptions">
                Created by Eyup Kerem Malkoc, Emre Can Inan , Verda Betul Al &@2023
            </div>
        </footer>
        <!-- Footer -->


    </div>

    <!-- /#wrapper -->

</body>
</html>








