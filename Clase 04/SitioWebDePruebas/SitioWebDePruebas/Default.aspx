<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWebDePruebas.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pagina Principal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="http://www.google.com"><strong>Ir a Google</strong></a><strong><br />
            <%--Esto es un comentario--%>
            <asp:HyperLink runat="server" NavigateUrl="~/Sumador/Default.aspx">Ir al Sumador</asp:HyperLink><br />
            <asp:HyperLink runat="server" NavigateUrl="~/Restador/Default.aspx">Ir al Restador</asp:HyperLink><br />
            <asp:HyperLink runat="server" NavigateUrl="~/Multiplicador/Default.aspx">Ir al Multiplicador</asp:HyperLink><br />
            <asp:HyperLink runat="server" NavigateUrl="~/Divididor/Default.aspx">Ir al Divididor</asp:HyperLink></strong><br />
        </div>
    </form>
</body>
</html>
