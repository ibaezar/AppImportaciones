<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="DeleteProducto.aspx.cs" Inherits="AppImportaciones.Views.DeleteProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
                <asp:Label ID="lblTitulo" runat="server" Text="Seleccione el producto a Eliminar"></asp:Label>
                <br /><br />
                <asp:DropDownList ID="dropProductos" runat="server"></asp:DropDownList>
                <asp:LinkButton ID="lnkEliminar" runat="server" OnClick="lnkEliminar_Click">Eliminar</asp:LinkButton>
                <br /><br />
                <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
                <br /><br />
                <asp:LinkButton ID="lnkListar" runat="server" OnClick="lnkListar_Click">Listar Productos </asp:LinkButton> | 
                <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar Productos</asp:LinkButton>
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
