<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Obligatorio2023Prog2.Login" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-bottom: 8px;
        }
    </style>

    <div>
        <h2>Login</h2>
        <div>
            <label for="txtUsuario">Usuario:</label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtContraseña">Contraseña:</label>
            <asp:TextBox ID="txtContraseña" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnLogin" Text="Iniciar Sesión" OnClick="btnLogin_Click" runat="server" />
        </div>

    </div>
</asp:Content>
