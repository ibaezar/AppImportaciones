<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="AddPais.aspx.cs" Inherits="AppImportaciones.Views.AddPais1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Agregar Pais"></asp:Label><br /><br />
            <asp:TextBox ID="txtId" runat="server" placeholder="Id"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator><br />
            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator><br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar</asp:LinkButton><br />
            <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
            <br />
            <asp:LinkButton ID="lnkListado" runat="server" OnClick="lnkListado_Click">Ver listado paises</asp:LinkButton>
        </div>
</asp:Content>
