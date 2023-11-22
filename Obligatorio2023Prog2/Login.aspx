<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Obligatorio2023Prog2.Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div>
        <h2>Login</h2>
        <div>
            <div class="row">
                <div class="col-lg-5">
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-5">
                    <asp:TextBox ID="txtContrasena" TextMode="Password" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
                </div>
            </div>
            <asp:Button ID="btnGuardar" Text="Iniciar Sesión" OnClick="btnGuardar_Click" runat="server" />
        </div>
        <div class="row">
            <div class="col-lg-5">
                <asp:Label ID="lblError" runat="server" Visible="false" CssClass="form-control" ForeColor="Red">Usuario y/o contraseña incorrectos</asp:Label>
            </div>
        </div>
    </div>
</asp:Content>


