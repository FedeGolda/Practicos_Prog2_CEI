<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Obligatorio2023Prog2.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:ListView ID="lvVehiculos" runat="server" DataKeyNames="Matricula" OnSelectedIndexChanged="lvVehiculos_SelectedIndexChanged">
    <LayoutTemplate>
        <table border="0" cellpadding="1" cellspacing="1">
            <tr runat="server">
                <th runat="server">Matricula</th>
            </tr>
            <tr id="itemPlaceholder" runat="server"></tr>
        </table>
    </LayoutTemplate>
    <ItemTemplate>
        <tr runat="server">
            <td>
                <asp:LinkButton runat="server" CommandName="Select" Text='<%# Eval("Matricula") %>' />
            </td>
        </tr>
    </ItemTemplate>
</asp:ListView>


</asp:Content>
