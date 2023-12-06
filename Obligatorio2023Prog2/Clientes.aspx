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
            <asp:GridView ID="gvClientes" runat="server" CssClass="table" Width="80%" BorderStyle="Solid" BorderWidth="2px" CellSpacing="5"
                AutoGenerateColumns="false"
                OnRowCancelingEdit="gvClientes_RowCancelingEdit"
                OnRowDeleting="gvClientes_RowDeleting"
                OnRowEditing="gvClientes_RowEditing"
                OnRowUpdating="gvClientes_RowUpdating"
                DataKeyNames="Cedula" OnSelectedIndexChanged="gvClientes_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="Cedula">
                        <ItemTemplate>
                            <asp:Label ID="lblCedula" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="txtCedulaGrid" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>



                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lblNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombreGrid" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Apellido">
                        <ItemTemplate>
                            <asp:Label ID="lblApellido" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtApellidoGrid" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Direccion">
                        <ItemTemplate>
                            <asp:Label ID="lblDireccion" runat="server" Text='<%# Bind("Direccion") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDireccionGrid" runat="server" Text='<%# Bind("Direccion") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
