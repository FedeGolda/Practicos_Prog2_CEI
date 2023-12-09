<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Obligatorio2023Prog2.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Administracion de Usuarios</h3>
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

    <h3>Permisos</h3>
    <div class="row">
        <div class="col-lg-5">
            <asp:CheckBoxList ID="cblPermisos" runat="server" CssClass="form-control">
                <asp:ListItem Value="VerClientes">Clientes</asp:ListItem>
                <asp:ListItem Value="VerUsuarios">Usuarios</asp:ListItem>
                <asp:ListItem Value="VerVentas">Ventas</asp:ListItem>
                <asp:ListItem Value="VerVehiculos">Vehiculos</asp:ListItem>
                <asp:ListItem Value="VerAlquileres">Alquileres</asp:ListItem>
            </asp:CheckBoxList>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardarUsuario" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardarUsuario_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-8">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            <h4>Usuarios registrados</h4>
            <asp:GridView ID="gvUsuarios" runat="server" Width="80%" BorderWidth="2px" CellPadding="10"
                OnRowCancelingEdit="gvUsuarios_RowCancelingEdit"
                OnRowDeleting="gvUsuarios_RowDeleting"
                OnRowEditing="gvUsuarios_RowEditing"
                OnRowUpdating="gvUsuarios_RowUpdating"
                AutoGenerateColumns="false"
                DataKeyNames="NombreUsuario">

                <Columns>
                    <asp:TemplateField HeaderText="Nombre Usuario">
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

                    <asp:TemplateField HeaderText="VerClientes">
                        <ItemTemplate>
                            <asp:Label ID="lblVerClientes" runat="server" Text='<%# Bind("VerClientes") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerClientesGrid" runat="server" Checked='<%# Bind("VerClientes") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="VerUsuarios">
                        <ItemTemplate>
                            <asp:Label ID="lblVerUsuarios" runat="server" Text='<%# Bind("VerUsuarios") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerUsuariosGrid" runat="server" Checked='<%# Bind("VerUsuarios") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="VerVehiculos">
                        <ItemTemplate>
                            <asp:Label ID="lblVerVehiculos" runat="server" Text='<%# Bind("VerVehiculos") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerVehiculosGrid" runat="server" Checked='<%# Bind("VerVehiculos") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="VerAlquileres">
                        <ItemTemplate>
                            <asp:Label ID="lblVerAlquileres" runat="server" Text='<%# Bind("VerAlquileres") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerAlquileresGrid" runat="server" Checked='<%# Bind("VerAlquileres") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="VerVentas">
                        <ItemTemplate>
                            <asp:Label ID="lblVerVentas" runat="server" Text='<%# Bind("VerVentas") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkVerVentasGrid" runat="server" Checked='<%# Bind("VerVentas") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>


        </div>
    </div>
</asp:Content>
