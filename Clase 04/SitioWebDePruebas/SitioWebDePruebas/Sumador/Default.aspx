<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWebDePruebas.Sumador.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sumador de valores</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink runat="server" NavigateUrl="~/Default.aspx">Ir al inicio</asp:HyperLink><br />
            <asp:HyperLink runat="server" NavigateUrl="~/Sumador/Default.aspx">Recargar</asp:HyperLink>
            <br />
            Textbox HTML: <input type="text" id="textboxHtml" name="textboxHtml" /> <br />
            Textbox ASP.NET: <asp:TextBox runat="server" ID="txtServidor"></asp:TextBox> <br />
            <hr />
            Numero Uno: <asp:TextBox runat="server" ID="txtNumeroUno"></asp:TextBox><br />
            Numero Dos: <asp:TextBox runat="server" ID="txtNumeroDos"></asp:TextBox><br />
            <asp:Button runat="server" Text="Sumar" ID="btnSumar" OnClick="btnSumar_Click" /><br />
            Resultado: <asp:Label runat="server" Id="lblResultado"></asp:Label>

        </div>
    </form>
    <script>
        var componenteTextBox = document.getElementById('<%=txtServidor.ClientID %>');
        console.log("componenteTextBox.value" + componenteTextBox.value);
    </script>
</body>
</html>
