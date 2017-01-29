<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<FilmManager.Models.IDal>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
<h1> Page de connexion</h1>
    <form id="form1" runat="server" action="Home/Connect" submitdisabledcontrols="True">
        <asp:TextBox ID="login" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="password" runat="server"></asp:TextBox> <br />
        <asp:Button ID="Button1" runat="server" Text="Button"  /> <br />
    </form>
 <script runat="server">

</script>
</body>
</html>
