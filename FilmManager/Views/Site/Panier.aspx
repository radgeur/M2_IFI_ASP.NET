<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Panier</title>
</head>
<body>
    <div>
        <h1> Votre Panier </h1>
        <% foreach (var f in ViewData["films"] as IList<FilmManager.Models.Film>)
           { %>
           <%: @Html.ActionLink("Supprimer", "Delete", "Panier", new { id = f.id }, null)%>
           <%: f.title%><br />
           <% } %>
           <%: @Html.ActionLink("Retour à la liste des films", "Return", "Panier")%> <br />
         <%: @Html.ActionLink("Déconnection", "Disconnected", "ListFilms")%>
    </div>
</body>
</html>
