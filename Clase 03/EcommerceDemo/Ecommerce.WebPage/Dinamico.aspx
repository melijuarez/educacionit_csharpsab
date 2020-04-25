<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dinamico.aspx.cs" Inherits="Ecommerce.WebPage.Dinamico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type ="text" value="Esto es un input estatico" /><br />
            <% Response.Write("Hola mundo desde el servidor"); %>
            <asp:Label ID="lblHolaMundo" runat="server" Text="ESTO SE SOBREESCRIBE"></asp:Label>
        </div>
    </form>
</body>
</html>
