<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Obligatorio2023Prog2.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Venta</h3>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <h3>Usuario:</h3>
            <asp:Label ID="lblNombreUsuario" runat="server" CssClass="form-control"></asp:Label>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Clientes: " runat="server"></asp:Label>
            <asp:DropDownList ID="cboClientes" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Vehiculos: " runat="server"></asp:Label>
            <asp:DropDownList ID="cboVehiculos" runat="server" CssClass="form-control" OnSelectedIndexChanged="cboVehiculos_SelectedIndexChanged1" AutoPostBack="true"></asp:DropDownList>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Fecha: " runat="server"></asp:Label>
            <asp:TextBox ID="txtFecha" TextMode="Date" runat="server" CssClass="form-control" Text="" placeholder="Fecha Venta"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" CausesValidation="false" runat="server" CssClass="btn btn-primary" Text="Vender" OnClick="btnGuardar_Click" />
        </div>
    </div>

    <div class="row">
        <div class="col-lg-8">
            <asp:Label ID="lblMensaje" runat="server" Visible="false" ForeColor="Red"></asp:Label>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:Label ID="lblPrecioSimbolo" runat="server" Visible="false" CssClass="form-control" ForeColor="Red">$ </asp:Label>
            <asp:Label ID="lblPrecio" runat="server" Visible="false" CssClass="form-control" ForeColor="Red"></asp:Label>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-8">
            <h4>Vehiculos vendidos registrados</h4>
            <asp:GridView ID="gridVentas" runat="server" Width="80%" BorderWidth="2px" CellPadding="10" CellSpacing="5"
                AutoGenerateColumns="false">



                <Columns>
                    <asp:TemplateField HeaderText="Nombre Usuario">
                        <ItemTemplate>
                            <asp:Label ID="lblUsuario" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtUsuarioGrid" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Cedula">
                        <ItemTemplate>
                            <asp:Label ID="lblCedula" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCedulaGrid" runat="server" Text='<%# Bind("Cedula") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="txtMatricula" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtMatriculaGrid" runat="server" Text='<%# Bind("Matricula") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="FechaVenta">
                        <ItemTemplate>
                            <asp:Label ID="txtFechaVenta" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechaVentaGrid" runat="server" Text='<%# Bind("FechaVenta") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
