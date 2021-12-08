<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="ListProducto.aspx.cs" Inherits="AppImportaciones.Views.ListProducto1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Listado de productos"></asp:Label>

            <br /><br />
            <asp:GridView ID="grdProducto" runat="server"></asp:GridView>
            <br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar productos</asp:LinkButton>
        </div>
</asp:Content>
