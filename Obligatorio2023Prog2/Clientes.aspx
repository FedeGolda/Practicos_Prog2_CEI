<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Obligatorio2023Prog2.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>
    <div class="row">
        <div class="col-lg-12">
            <h3>Registro de Clientes</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control" Text="" placeholder="Cédula del cliente" MaxLength="8"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Ingrese solo números" ForeColor="Red" ValidationExpression="^\d{1,8}$" Display="Dynamic"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Text="" placeholder="Nombre del cliente"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" Text="" placeholder="Apellido del cliente"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Text="" placeholder="Dirección del cliente"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardarCliente" runat="server" CssClass="btn btn-primary" Text="Guardar Cliente" OnClick="btnGuardarCliente_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-8">
            <h4>Clientes Registrados</h4>
            <asp:Label ID="lblMensajeError" runat="server" ForeColor="Red"></asp:Label>
            <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" OnRowEditing="gvClientes_RowEditing" OnRowCancelingEdit="gvClientes_RowCancelingEdit" OnRowUpdating="gvClientes_RowUpdating" OnRowDeleting="gvClientes_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Cedula" HeaderText="Cedula" SortExpression="Cedula" ReadOnly="True" />
                    <asp:TemplateField HeaderText="Nombre" SortExpression="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombreGrid" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Apellido" SortExpression="Apellido">
                        <ItemTemplate>
                            <asp:Label ID="lblApellido" runat="server" Text='<%# Eval("Apellido") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtApellidoGrid" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Direccion" SortExpression="Direccion">
                        <ItemTemplate>
                            <asp:Label ID="lblDireccion" runat="server" Text='<%# Eval("Direccion") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDireccionGrid" runat="server" Text='<%# Bind("Direccion") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>