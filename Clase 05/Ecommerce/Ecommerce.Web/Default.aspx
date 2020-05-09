<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Ecommerce.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    Bienvenidos a la tienda <asp:Label ID="lblNombreYSlogan" runat="server"></asp:Label>
    <hr />
    <asp:ListView ID="listViewCategorias" runat="server">
        <LayoutTemplate>
            <table>
                <thead>
                    <td>
                        <th>Categoría</th>
                        <th>&nbsp;</th>
                    </td>
                </thead>
                <tbody>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Nombre") %></td>
                <td>
                    <a class="btn btn-primary" href="Productos.aspx?categoryId=<%# Eval("Id") %>">Ver Produtos</a>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
