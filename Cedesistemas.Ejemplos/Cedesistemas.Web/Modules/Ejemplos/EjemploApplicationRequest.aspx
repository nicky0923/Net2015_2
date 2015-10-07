<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploApplicationRequest.aspx.cs" Inherits="Cedesistemas.Web.Modules.EjemploApplicationRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="TextBoxMensaje" runat="server" Height="25px" Width="385px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="ButtonEnviar" runat="server" OnClick="ButtonEnviar_Click" Text="Enviar" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
