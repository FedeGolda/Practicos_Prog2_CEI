﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Obligatorio2023Prog2.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Catálogo de Usuarios</h3>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control" Text="" placeholder="Nombre de Usuario"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:RadioButtonList ID="rblPermisos" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblPermisos_SelectedIndexChanged">
                <asp:ListItem Value="VerClientes" Selected="True">Clientes</asp:ListItem>
                <asp:ListItem Value="VerUsuarios">Usuarios</asp:ListItem>
                <asp:ListItem Value="VerVentas">Ventas</asp:ListItem>
                <asp:ListItem Value="VerVehiculos">Vehiculos</asp:ListItem>
                <asp:ListItem Value="VerAlquileres">Alquileres</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>


    <div runat="server" id="VerUsuarios">
        <h4>Permisos de Usuarios</h4>
        <ul>
            <li>Permiso 1</li>
            <li>Permiso 2</li>
        </ul>
    </div>
    <div runat="server" id="VerClientes">
        <h4>Permisos de Clientes</h4>
        <ul>
            <li>Permiso 1</li>
            <li>Permiso 2</li>
        </ul>
    </div>
    <div runat="server" id="VerVentas">
        <h4>Permisos de Ventas</h4>
        <ul>
            <li>Permiso 1</li>
            <li>Permiso 2</li>
        </ul>
    </div>
    <div runat="server" id="VerAlquileres">
        <h4>Permisos de Alquileres</h4>
        <ul>
            <li>Permiso 1</li>
            <li>Permiso 2</li>
        </ul>
    </div>
    <div runat="server" id="VerVehiculos">
        <h4>Permisos de Vehículos</h4>
        <ul>
            <li>Permiso 1</li>
            <li>Permiso 2</li>
        </ul>
    </div>




    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardarUsuario" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardarUsuario_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-8">
            <asp:GridView ID="gvUsuarios" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5"
                OnRowCancelingEdit="gvUsuarios_RowCancelingEdit"
                OnRowDeleting="gvUsuarios_RowDeleting"
                OnRowEditing="gvUsuarios_RowEditing"
                OnRowUpdating="gvUsuarios_RowUpdating"
                AutoGenerateColumns="false"
                DataKeyNames="NombreUsuario">
                <Columns>
                    <asp:TemplateField HeaderText="Nombre de Usuario">
                        <ItemTemplate>
                            <asp:Label ID="lblNombreUsuario" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombreUsuarioGrid" runat="server" Text='<%# Bind("NombreUsuario") %>' CssClass="form-control" placeholder="Nombre de Usuario"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Contraseña">
                        <ItemTemplate>
                            <asp:Label ID="lblContrasena" runat="server" Text='<%# Bind("Contrasena") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtContrasenaGrid" runat="server" Text='<%# Bind("Contrasena") %>' TextMode="Password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
