<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="author_edit.aspx.cs" Inherits="ThesisProject_.Author.author_edit" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="../assets/style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

</head>
<body>

    <div id="wrapper" class="toggled">

        <!-- Sidebar -->
        <div id="sidebar-wrapper" class="sidebarWrapper">
            <ul class="sidebar-nav">
                               <li class="sidebar-brand">
   <a href="../thesis/thesis_list.aspx">
    THESIS
</a>
 </li>
 <li>
     <a href ="../Author/author_list.aspx">Authors</a>
 </li>
 <li>
     <a href="../city/city_list.aspx">Cities</a>
 </li>
 <li>
     <a href="../Cosupervisor/Cosupervisor_list.aspx">Cosupervisors</a>
 </li>
 <li>
     <a href ="../supervisor/supervisor_list.aspx">Supervisor</a>
 </li>
 <li>
     <a href ="../Instutues/instutues_list.aspx">Instutes</a>
 </li>
 <li>
     <a href ="../keywords/keywords_list.aspx">Keywords</a>
 </li>
 <li>
     <a href ="../languages/languages_list.aspx">Language</a>
 </li>
 <li>
     <a href ="../types/types_list.aspx">Types</a>
 </li>
 <li>
     <a href ="../university/university_list.aspx">Universities</a>
 </li>
            </ul>
        </div>
        <!-- /#sidebar-wrapper -->
        <!-- Page Content -->
        <div class="title">Graduate Thesis System</div>
        <div id="page-content-wrapper">
            <div class="container-fluid">
                    <form id="form1" runat="server">
                        <h3>Edit Author</h3>
                            <div class="addAuthor"> 
                              <label for="Author Name"></label>
                              <asp:TextBox runat="server" ID="txtAuthorName" CssClass="form-control" placeHolder="Author Name" />                       
                              <label for="Author Surname"></label>
                              <asp:TextBox runat="server" ID="txtAuthorSurname" CssClass="form-control" placeHolder="Author Surname" />                      
                              <label for="Author Phone Number"></label>
                              <asp:TextBox runat="server" ID="txtAuthorPhoneNumber" CssClass="form-control" placeHolder="Phone Name" />                     
                              <label for="Author Email"></label>
                              <asp:TextBox runat="server" ID="txtAuthorEmail" CssClass="form-control" placeHolder="Email" />
                            </div>
                            <asp:Button Text="Save" ID="btnSave" runat="server" CssClass="btn btn-success" OnClick="btnSave_Click" />
                            <a href="/author/author_list.aspx" class="btn btn-danger">Cancel</a>
                     </form>
            </div>    
        </div>
        <!-- /#page-content-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- Menu Toggle Script -->


     <script src="./index.js"></script>
</body>
</html>









<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
</body>
</html>
