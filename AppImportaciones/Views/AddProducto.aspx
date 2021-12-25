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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
                <asp:Label ID="lbTitulo" runat="server" Text="Agregar Nuevos Productos"></asp:Label>

                <br /><br />

                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">Nombre Producto</td>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Valor Producto</td>
                        <td>
                            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtValor" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Stock Producto</td>
                        <td>
                            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtValor" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
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
                            <asp:LinkButton ID="lnkListar" CausesValidation="false" runat="server" OnClick="lnkListar_Click">Listado Productos</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>

            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1" runat="server">
        <ProgressTemplate>
            <!--SPINNER-->
            <div class="spinner">
            <div class="modal-dialog modal-dialog-centered" role="document">
                    <div class="modal-content">
                        <div class="modal-header justify-content-center">
                                <h4>Cargando datos</h4>
                        </div>
                        <div class="modal-body">
                            <div class="text-center">
                                <p>Espere mientras carga la información</p>
                                <div class="spinner-border text-success" style="width: 3rem; height: 3rem;" role="status">
                                    <span class="sr-only">Loading...</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
