<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TestObligatorioP2.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Clientes</h3>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control" Text="" placeholder="Cedula del cliente"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>

    <div class="row">
        <div class="col-lg-8">
            <asp:GridView ID="gvClientes" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5"
                OnRowCancelingEdit="gvClientes_RowCancelingEdit"
                OnRowDeleting="gvClientes_RowDeleting"
                OnRowEditing="gvClientes_RowEditing"
                OnRowUpdating="gvClientes_RowUpdating"
                AutoGenerateColumns="false">


                <Columns>
                    <asp:TemplateField HeaderText="cedula">
                        <ItemTemplate>
                            <asp:Label ID="lblCedula" runat="server" Text='<%# Bind("cedula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCedulaGrid" runat="server" Text='<%# Bind("cedula") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>


            </asp:GridView>
        </div>
    </div>


    <br />
    <br />
    <div class="row">
        <div class="col-lg-8">
            <asp:DataGrid ID="dgClientes" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5">
            </asp:DataGrid>
        </div>
    </div>

</asp:Content>
