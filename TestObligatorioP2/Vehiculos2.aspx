﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos2.aspx.cs" Inherits="TestObligatorioP2.Vehiculos2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>
    <div class="row">
        <div class="col-lg-12">
            <h3>Catalogo de Vehiulos</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" placeholder="Matricula del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" placeholder="Marca del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control" placeholder="Modelo del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-8">
           <asp:GridView ID="gvVehiculos" CssClass="table" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5" 
               OnRowCancelingEdit="gvVehiculos_RowCancelingEdit" 
               OnRowDeleting="gvVehiculos_RowDeleting" 
               OnRowEditing="gvVehiculos_RowEditing" 
               OnRowUpdating="gvVehiculos_RowUpdating"
               AutoGenerateColumns="false"
               DataKeyNames="Matricula">
               <Columns>
                   <asp:TemplateField HeaderText="Matricula">
                       <ItemTemplate>
                           <asp:Label id="label1" runat="server" Text='<%# Bind("Matricula") %>' ></asp:Label>
                       </ItemTemplate>
                       <EditItemTemplate>
                            <asp:Label id="lblMatricula" runat="server" Text='<%# Bind("Matricula") %>' ></asp:Label>
                       </EditItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Marca">
                       <ItemTemplate>
                           <asp:Label id="label2" runat="server" Text='<%# Bind("Marca") %>' ></asp:Label>
                       </ItemTemplate>
                       <EditItemTemplate>
                            <asp:TextBox id="txtMarcaGrid" runat="server" Text='<%# Bind("Marca") %>' ></asp:TextBox>
                       </EditItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Modelo">
                       <ItemTemplate>
                           <asp:Label id="label3" runat="server" Text='<%# Bind("Modelo") %>' ></asp:Label>
                       </ItemTemplate>
                       <EditItemTemplate>
                            <asp:TextBox id="txtModeloGrid" runat="server" Text='<%# Bind("Modelo") %>' ></asp:TextBox>
                       </EditItemTemplate>
                   </asp:TemplateField>
                   <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />
               </Columns>

           </asp:GridView>
        </div>
    </div>
</asp:Content>
