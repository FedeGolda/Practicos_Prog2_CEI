﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="TestObligatorioP2.Vehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>
    <div class="row">
        <div class="col-lg-12">
            <h3>Catalogo Vehículos</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" Text="" placeholder="Matricula del vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" Text="" placeholder="Marca del vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control" Text="" placeholder="Modelo del vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-8">
            <asp:GridView ID="gvVehiculos" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5"
                OnRowCancelingEdit="gvVehiculos_RowCancelingEdit"
                OnRowDeleting="gvVehiculos_RowDeleting"
                DataKeyNames="Matricula"
                AutoGenerateColumns="false"
                OnRowEditing="gvVehiculos_RowEditing"
                OnRowUpdating="gvVehiculos_RowUpdating">

                <Columns>
                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lblMatricula" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="txtMatriculaGrid" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Marca">
                        <ItemTemplate>
                            <asp:Label ID="lblMarca" runat="server" Text='<%# Bind("Marca") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtMarcaGrid" runat="server" Text='<%# Bind("Marca") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Modelo">
                        <ItemTemplate>
                            <asp:Label ID="lblModelo" runat="server" Text='<%# Bind("Modelo") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtModeloGrid" runat="server" Text='<%# Bind("Modelo") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

                </Columns>


            </asp:GridView>
        </div>
    </div>
    <br />
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:DataGrid ID="dgVehiculos" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5">
            </asp:DataGrid>
        </div>
    </div>
</asp:Content>
