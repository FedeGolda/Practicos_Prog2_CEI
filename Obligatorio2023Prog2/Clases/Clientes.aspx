<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Obligatorio2023Prog2.Clases.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>
    <div class="row">
        <div class="col-lg-12">
            <h3>Lista Clientes</h3>
        </div>

        <div class="row">
            <div class="col-lg-8">
                <asp:GridView ID="gvClientes" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5"
                    AutoGenerateColumns="False" OnRowEditing="gvClientes_RowEditing" OnRowUpdating="gvClientes_RowUpdating"
                    OnRowCancelingEdit="gvClientes_RowCancelingEdit" OnRowDeleting="gvClientes_RowDeleting"
                    DataKeyNames="Id" OnSelectedIndexChanged="gvClientes_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" ReadOnly="True" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                        <asp:BoundField DataField="Cedula" HeaderText="Cédula" SortExpression="Cedula" />
                        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
