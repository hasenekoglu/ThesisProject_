<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thesis_details.aspx.cs" Inherits="ThesisProject_.thesis.thesis_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Repeater runat="server" ID="thesisList">
                 <ItemTemplate>
                     
  <h3><%# Eval("ID") %></h3>
 <h3><%# Eval("AUTHORID") %></h3>
 <h3><%# Eval("SUPERVISORID") %></h3>
 <h3><%# Eval("COSUPERVISORID") %></h3>
 <h3><%# Eval("UNIVERSITYID") %></h3>
 <h3><%# Eval("INSTITUTEID") %></h3>
 <h3><%# Eval("LANGUAGEID") %></h3>
 <h3><%# Eval("TYPEID") %></h3>
 <h3><%# Eval("TITLEID") %></h3>
 <h3><%# Eval("NUMBEROFPAGE") %></h3>
 <h3><%# Eval("ABSTRACT") %></h3>
 <h3><%# Eval("YEAR") %></h3>
 <h3><%# Eval("SUBMISSIN") %></h3>
 <h3>

     <asp:HyperLink NavigateUrl='<%# "universite_sil.aspx?id=" + Eval("UNIVERSITYID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
     <asp:HyperLink NavigateUrl='<%# "universite_duzenle.aspx?id=" + Eval("UNIVERSITYID") %>' runat="server" CssClass="btn btn-success">Düzenle</asp:HyperLink>

</h3>
                 </ItemTemplate>
             </asp:Repeater>

        </div>
    </form>
</body>
</html>
