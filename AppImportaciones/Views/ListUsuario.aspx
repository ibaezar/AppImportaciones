<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="ListUsuario.aspx.cs" Inherits="AppImportaciones.Views.ListUsuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Listado de usuarios"></asp:Label>
            <asp:GridView ID="grdUsuarios" runat="server"></asp:GridView><br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar Usuario</asp:LinkButton>
        </div>
</asp:Content>
