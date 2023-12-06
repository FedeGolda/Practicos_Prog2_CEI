<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="Obligatorio2023Prog2.Vehiculos" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Catalogo de Vehiculos</h3>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:RadioButtonList ID="rblTipoVehiculo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblTipoVehiculo_SelectedIndexChanged">
                <asp:ListItem Value="Moto" Selected="True">Moto</asp:ListItem>
                <asp:ListItem Value="Auto">Auto</asp:ListItem>
                <asp:ListItem Value="Camion">Camion</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" Text="" placeholder="Matricula del vehiculo"></asp:TextBox>
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
            <asp:TextBox ID="txtAño" runat="server" TextMode="Number" CssClass="form-control" placeholder="Año del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtKilometros" runat="server" TextMode="Number" CssClass="form-control" placeholder="Kilometros del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtColor" runat="server" CssClass="form-control" placeholder="Color del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtPrecioVenta" runat="server" TextMode="Number" CssClass="form-control" placeholder="Precio venta del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtPrecioAlquiler" runat="server" TextMode="Number" CssClass="form-control" placeholder="Precio alquiler del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtCilindradas" runat="server" TextMode="Number" CssClass="form-control" Text="" placeholder="Cilindradas del vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtCantPasajeros" Visible="false" TextMode="Number" runat="server" CssClass="form-control" Text="" placeholder="Cantidad de Pasajeros del vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtToneladas" runat="server" TextMode="Number" Visible="false" CssClass="form-control" Text="" placeholder="Toneladas del vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtImagen1" runat="server" CssClass="form-control" placeholder="imagen 1 del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtImagen2" runat="server" CssClass="form-control" placeholder="imagen 2 del Vehiculo"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:TextBox ID="txtImagen3" runat="server" CssClass="form-control" placeholder="imagen 3 del Vehiculo"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-8">
            <h4>Vehiculos registrados</h4>
            <asp:Label ID="lblMensajeError" runat="server" ForeColor="Red"></asp:Label>
            <asp:GridView ID="gvVehiculos" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5"
                OnRowCancelingEdit="gvVehiculos_RowCancelingEdit"
                OnRowDeleting="gvVehiculos_RowDeleting"
                OnRowEditing="gvVehiculos_RowEditing"
                OnRowUpdating="gvVehiculos_RowUpdating"
                AutoGenerateColumns="false"
                DataKeyNames="Matricula">
                <Columns>
                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lblMatricula" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lblMatriculaEdit" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
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


                    <asp:TemplateField HeaderText="Año">
                        <ItemTemplate>
                            <asp:Label ID="lblAño" runat="server" Text='<%# Bind("Año") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAñoGrid" runat="server" Text='<%# Bind("Año") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Kilometros">
                        <ItemTemplate>
                            <asp:Label ID="lblKilometros" runat="server" Text='<%# Bind("Kilometros") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtKilometrosGrid" runat="server" Text='<%# Bind("Kilometros") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Color">
                        <ItemTemplate>
                            <asp:Label ID="lblColor" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtColorGrid" runat="server" Text='<%# Bind("Color") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="PrecioVenta">
                        <ItemTemplate>
                            <asp:Label ID="lblPrecioVenta" runat="server" Text='<%# Bind("PrecioVenta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioVentaGrid" runat="server" Text='<%# Bind("PrecioVenta") %>'></asp:TextBox>

                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="PrecioAlquilerDia">
                        <ItemTemplate>
                            <asp:Label ID="lblPrecioAlquilerDia" runat="server" Text='<%# Bind("PrecioAlquilerDia") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioAlquilerDiaGrid" runat="server" Text='<%# Bind("PrecioAlquilerDia") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="CampoEspecial">
                        <ItemTemplate>
                            <asp:Label ID="lblCampoEspecial" runat="server" Text='<%# Bind("CampoEspecial") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCampoEspecialGrid" runat="server" Text='<%# Bind("CampoEspecial") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Imagen1">
                        <ItemTemplate>
                            <asp:Image ID="imgImagen1" runat="server" ImageUrl='<%# Bind("Imagen1") %>' Height="100" Width="100"></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtImagen1Grid" runat="server" Text='<%# Bind("Imagen1") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Imagen2">
                        <ItemTemplate>
                            <asp:Image ID="imgImagen2" runat="server" ImageUrl='<%# Bind("Imagen2") %>' Height="100" Width="100"></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtImagen2Grid" runat="server" Text='<%# Bind("Imagen2") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Imagen3">
                        <ItemTemplate>
                            <asp:Image ID="imgImagen3" runat="server" ImageUrl='<%# Bind("Imagen3") %>' Height="100" Width="100"></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtImagen3Grid" runat="server" Text='<%# Bind("Imagen3") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </div>




</asp:Content>
