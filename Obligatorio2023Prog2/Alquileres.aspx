<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquileres.aspx.cs" Inherits="Obligatorio2023Prog2.Alquileres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div class="row">
        <div class="col-lg-12">
            <h3>Alquiler</h3>
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
            <asp:DropDownList ID="cboVehiculos" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Label Text="Dias: " runat="server"></asp:Label>
            <asp:TextBox ID="txtAlquilerDia" TextMode="Number" runat="server" CssClass="form-control" Text="" placeholder="Dias de alquiler" OnTextChanged="txtAlquilerDia_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-5">
            <asp:Button ID="btnGuardar" CausesValidation="false" runat="server" CssClass="btn btn-primary" Text="Alquilar" OnClick="btnGuardar_Click" />
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
            <asp:GridView ID="gvAlquileres" runat="server" Width="80%" BorderWidth="2px" CellSpacing="5"
                AutoGenerateColumns="false"
                OnRowCancelingEdit="gvAlquileres_RowCancelingEdit"
                OnRowDeleting="gvAlquileres_RowDeleting"
                OnRowEditing="gvAlquileres_RowEditing"
                OnRowUpdating="gvAlquileres_RowUpdating"
                DataKeyNames="Matricula" OnSelectedIndexChanged="gvAlquileres_SelectedIndexChanged">




                <Columns>
                    <asp:TemplateField HeaderText="Matricula">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl2" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Cedula">
                        <ItemTemplate>
                            <asp:Label ID="lbl3" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="txtMarcaGrid" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="FechaAlquiler">
                        <ItemTemplate>
                            <asp:Label ID="txtFechaAlquiler" runat="server" Text='<%# Bind("FechaAlquiler") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dias">
                        <ItemTemplate>
                            <asp:Label ID="txtDias" runat="server" Text='<%# Bind("Dias") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDiasGrid" runat="server" Text='<%# Bind("Dias") %>'></asp:TextBox>
                        </EditItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio">
                        <ItemTemplate>
                            <asp:Label ID="lbl8" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrecioGrid" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Devuelto">
                        <ItemTemplate>
                            <asp:CheckBox ID="txtAutoDevuelto" runat="server" Checked='<%# Bind("AutoDevuelto") %>'></asp:CheckBox>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="chkDevueltoGrid" runat="server" Checked='<%# Bind("AutoDevuelto") %>' OnCheckedChanged="chkDevueltoGrid_CheckedChanged"></asp:CheckBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <asp:Label ID="lbl10" runat="server" Text='<%# Bind("Estado") %>' ForeColor="Red" Font-Bold="true"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

                </Columns>

            </asp:GridView>

        </div>
    </div>






</asp:Content>
