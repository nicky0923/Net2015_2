<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploViewState.aspx.cs" Inherits="Cedesistemas.Web.Modules.EjemploViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 526px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="ButtonEnviar" runat="server" OnClick="ButtonEnviar_Click" Text="Enviar" />
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
