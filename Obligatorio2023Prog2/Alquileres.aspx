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
    



            <columns>
                <asp:TemplateField HeaderText="Matricula">
                    <itemtemplate>
                        <asp:Label ID="lbl1" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                    </itemtemplate>
                    <edititemtemplate>
                        <asp:Label ID="lbl2" runat="server" Text='<%# Bind("Matricula") %>'></asp:Label>
                    </edititemtemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Cedula">
                    <itemtemplate>
                        <asp:Label ID="lbl3" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                    </itemtemplate>
                    <edititemtemplate>
                        <asp:Label ID="txtMarcaGrid" runat="server" Text='<%# Bind("Cedula") %>'></asp:Label>
                    </edititemtemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="FechaAlquiler">
                    <itemtemplate>
                        <asp:Label ID="lbl4" runat="server" Text='<%# Bind("FechaAlquiler") %>'></asp:Label>
                    </itemtemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Dias">
                    <itemtemplate>
                        <asp:Label ID="lbl7" runat="server" Text='<%# Bind("Dias") %>'></asp:Label>
                    </itemtemplate>
                    <edititemtemplate>
                        <asp:TextBox ID="txtDiasGrid" runat="server" Text='<%# Bind("Dias") %>'></asp:TextBox>
                    </edititemtemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio">
                    <itemtemplate>
                        <asp:Label ID="lbl8" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                    </itemtemplate>
                    <edititemtemplate>
                        <asp:TextBox ID="txtPrecioGrid" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                    </edititemtemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Devuelto">
                    <itemtemplate>
                        <asp:CheckBox ID="lbl9" runat="server" Checked='<%# Bind("AutoDevuelto") %>'></asp:CheckBox>
                    </itemtemplate>
                    <edititemtemplate>
                        <asp:CheckBox ID="chkDevueltoGrid" runat="server" Checked='<%# Bind("AutoDevuelto") %>'></asp:CheckBox>
                    </edititemtemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Estado">
                    <itemtemplate>
                        <asp:Label ID="lbl10" runat="server" Text='<%# Bind("Estado") %>' ForeColor="Red" Font-Bold="true"></asp:Label>
                    </itemtemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" />

            </columns>

                </asp:GridView>
            
        </div>
    </div>






</asp:Content>
