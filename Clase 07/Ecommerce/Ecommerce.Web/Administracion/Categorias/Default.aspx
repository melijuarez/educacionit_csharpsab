<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Ecommerce.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Web.Administracion.Categorias.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h3>Administración de categorias</h3>
    <div class="col-md-6">
        <a href="Nueva.aspx" class="btn btn-primary">Nueva</a>
    </div>
    <div class="col-md-6">
        Cantidad de categorias: <asp:Label runat="server" ID="lblCantidadCategorias"></asp:Label>
    </div>
    <asp:ListView runat="server" ID="listViewCategorias">
        <LayoutTemplate>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Nombre</th>
                        <th scope="col">Descripcion</th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Nombre") %></td>
                <td><%# Eval("Descripcion") %></td>
                <td>
                    <a href="Editar.aspx?id=<%# Eval("Id") %>">Editar</a>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
