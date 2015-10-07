<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Internal.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Cedesistemas.Web.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 500px;
            height: 600px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style5">
        <tr>
            <td>
                <asp:Label ID="LabelBienvenido" runat="server" Text="Bienvenido al sistema de reservas" SkinID="titulos"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
