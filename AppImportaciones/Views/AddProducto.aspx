<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="AddProducto.aspx.cs" Inherits="AppImportaciones.Views.AddProducto1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 310px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Agregar Nuevos Productos"></asp:Label>

            <br /><br />

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Id Producto</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre Producto</td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Valor Producto</td>
                    <td>
                        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Stock Producto</td>
                    <td>
                        <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Vendedor Encargado</td>
                    <td>
                        <asp:DropDownList ID="dropVendedor" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar</asp:LinkButton>
                    </td>
                    <td>
                        <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkListar" runat="server" OnClick="lnkListar_Click">Listado Productos</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>

        </div>
</asp:Content>
