﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="ListCiudad.aspx.cs" Inherits="AppImportaciones.Views.ListCiudad1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
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
