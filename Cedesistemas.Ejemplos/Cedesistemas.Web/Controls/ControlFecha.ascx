<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlFecha.ascx.cs" Inherits="Cedesistemas.Web.Controls.ControlFecha" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<div style="display: inline">
    <asp:TextBox ID="TextBoxFecha" runat="server" Enabled="false" AutoPostBack="True"></asp:TextBox>
    <cc1:CalendarExtender ID="TextBoxFecha_CalendarExtender" Enabled="true" runat="server" Format="yyyy/MM/dd" TargetControlID="TextBoxFecha" PopupButtonID="ImageButtonCalendario" />
    <asp:ImageButton ID="ImageButtonCalendario" runat="server" Height="22px" ImageUrl="~/Assets/img/Calendario.png" Width="22px" />
</div>

