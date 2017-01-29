<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<System.Collections.Generic.List<FilmManager.Models.Film>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>ListFilms</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Liste des films:</h1>

        <%
            foreach (var f in Model)
            { 
         %>
            <%: @Html.ActionLink("Sélectionner", "Selected", "ListFilms", new { id = f.id }, null)%>
            <%: @Html.ActionLink("Vu", "Saw", "ListFilms")%>
            <%: @Html.ActionLink("Pas vu", "Unsaw", "ListFilms")%>
            <% if(Session["admin"].Equals(true))
               { 
             %>
                <%: @Html.ActionLink("Supprimer", "DeleteFilm", "ListFilms", new { id = f.id }, null)%>
            <%  } %>
            <%: f.title %><br />
         <%
            }  
         %>
        <br />
         <%: @Html.ActionLink("Accéder au panier", "Index", "Panier")%><br />
         <%: @Html.ActionLink("Déconnection", "Disconnected", "ListFilms")%>
    </div>
    </form>
</body>
</html>
