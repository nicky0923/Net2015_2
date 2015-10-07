<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploSessionRequest.aspx.cs" Inherits="Cedesistemas.Web.Modules.EjemploSessionRequest" %>

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
                    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                    <asp:Button ID="ButtonEnviar" runat="server" OnClick="ButtonEnviar_Click" Text="Enviar" />
                </td>
                <td>&nbsp;</td>
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
