<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="ListCiudad.aspx.cs" Inherits="AppImportaciones.Views.ListCiudad1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Listado de ciudades"></asp:Label><br /><br />
            <asp:DropDownList ID="dropPais" runat="server"></asp:DropDownList><br />
            <asp:LinkButton ID="lnkVer" runat="server" OnClick="lnkVer_Click">Ver</asp:LinkButton>
            <br /><asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
            <br /><br />
            
            <asp:GridView ID="grdCiudad" runat="server"></asp:GridView>

            <br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar Ciudad</asp:LinkButton>
        </div>
</asp:Content>
