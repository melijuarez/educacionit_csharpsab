<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Ecommerce.Master" AutoEventWireup="true" CodeBehind="MiTienda.aspx.cs" Inherits="Ecommerce.Web.AcercaDe.MiTienda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-md-6">
            Acerca de Mi Tienda...
        </div>
        <div class="col-md-6">
            <asp:Label runat="server" ID="lblContadorViewState">0</asp:Label><br />
            <asp:Button runat="server" CssClass="btn btn-primary" ID="btnContadorViewState" OnClick="btnContadorViewState_Click" Text="Incrementar" />
            <hr />
            <asp:Label runat="server" ID="lblContadorSesion">0</asp:Label><br />
            <asp:Button runat="server" CssClass="btn btn-secondary" ID="btnContadorSesion" OnClick="btnContadorSesion_Click" Text="Incrementar" />
            <hr />
            <asp:Label runat="server" ID="lblContadorVisitasAplicacion"></asp:Label>
        </div>
    </div>    
</asp:Content>
