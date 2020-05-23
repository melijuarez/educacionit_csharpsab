<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Ecommerce.Master" AutoEventWireup="true" CodeBehind="VentaPorCategoria.aspx.cs" Inherits="Ecommerce.Web.Reportes.VentaPorCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label>Categoria</label>
                <asp:TextBox runat="server" ID="txtCategoria" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <label>Año</label>
                <asp:TextBox runat="server" ID="txtAnio" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="col-md-4 offset-md-4">
                <asp:Button runat="server" ID="btnBuscar" CssClass="btn btn-primary btn-block" Text="Buscar" OnClick="btnBuscar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
