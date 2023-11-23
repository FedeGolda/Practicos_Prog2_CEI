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
                <asp:DataGrid ID="dgClientes" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5" OnSelectedIndexChanged="dgClientes_SelectedIndexChanged">
                </asp:DataGrid>
            </div>
        </div>
    </div>
</asp:Content>
