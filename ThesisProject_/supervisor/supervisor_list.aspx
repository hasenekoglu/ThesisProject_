﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="supervisor_list.aspx.cs" Inherits="ThesisProject_.supervisor.supervisor_list" %>

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
                    <form id="form2" runat="server">
                         <h3>Supervisor List</h3>
                          <table class="table table-bordered table-hover">
                           <thead>
                             <tr>
                             <th>Id</th>
                             <th>Supervisor Name</th>
                             <th>Supervisor Lastname</th>
                         
                             <th>Supervisor Email</th>
                            </tr>
                            </thead>
                            <tbody>
                      <asp:Repeater runat="server" ID="supervisorList">
                     <ItemTemplate>
                       <tr>
                         <td><%# Eval("ID") %></td>
                         <td><%# Eval("NAME") %></td>
                         <td><%# Eval("SURNAME") %></td>
                
                         <td><%# Eval("EMAIL") %></td>
                      <td>

                       <asp:HyperLink NavigateUrl='<%# "supervisor_delete.aspx?id=" + Eval("ID") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                       <asp:HyperLink NavigateUrl='<%# "supervisor_edit.aspx?id=" + Eval("ID") %>' runat="server" CssClass="btn btn-success">Edit</asp:HyperLink>

                      </td>
                      </tr>    
               </ItemTemplate>
           </asp:Repeater>
       </tbody>
   </table>
                        <a href="/supervisor/supervisor_add.aspx" role="button" class="btn btn-success">Add supervisor</a>
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




