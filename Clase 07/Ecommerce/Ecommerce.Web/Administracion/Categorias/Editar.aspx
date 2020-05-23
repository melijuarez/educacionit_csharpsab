<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Ecommerce.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Ecommerce.Web.Administracion.Categorias.Editar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h3>Editar la categoría
        <asp:Label ID="labelNombreCategoria" runat="server"></asp:Label></h3>
    <asp:Panel runat="server" CssClass="col-md-12" ID="pnlError" Visible="false">
        <div class="alert alert-danger" role="alert">
            <asp:label runat="server" ID="lblError"></asp:label>
        </div>
    </asp:Panel>
    <div class="form-group">
        <label>Nombre</label>
        <asp:TextBox runat="server" ID="txtNombreCategoria" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Descripción</label>
        <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button runat="server" ID="btnGuardar" CssClass="btn btn-primary btn-block" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>
