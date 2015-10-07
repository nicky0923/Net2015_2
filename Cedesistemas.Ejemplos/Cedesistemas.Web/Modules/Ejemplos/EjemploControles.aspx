<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploControles.aspx.cs" Inherits="Cedesistemas.Web.Modules.EjemploControles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 494px;
        }
    </style>
</head>
<body>
    jhkjhkjkjj
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LabelNombre" runat="server" Text="Identificación" ToolTip="Digite la identificación" Width="100px"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LabelSingle" runat="server" Text="Ejemplo singleline" Width="100px"></asp:Label>
                    <asp:TextBox ID="TextBoxAtributos" runat="server" Height="22px" Width="217px" placeholder ="Ingrese el documento" AutoPostBack="True" OnTextChanged="TextBoxAtributos_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Height="62px" TextMode="MultiLine" Width="211px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="ButtonCambiar" runat="server" OnClick="ButtonCambiar_Click" Text="Cambiar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxFecha" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButtonCalendario" runat="server" Height="25px" ImageUrl="~/Assets/img/Calendario.png" OnClick="ImageButtonCalendario_Click" Width="33px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Panel ID="PanelCalendario" runat="server" Visible="False">
                        <asp:Calendar ID="CalendarFecha" runat="server" OnSelectionChanged="CalendarFecha_SelectionChanged"></asp:Calendar>
                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" Height="178px" OnNextButtonClick="Wizard1_NextButtonClick" Width="475px">
                        <WizardSteps>
                            <asp:WizardStep runat="server" title="Información básica">
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" title="Estudios">
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                                <asp:ListItem>Universitario</asp:ListItem>
                                                <asp:ListItem>Colegio</asp:ListItem>
                                                <asp:ListItem>Maestria</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" AllowReturn="False" Title="Experiencia laboral">
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Programación" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Base de datos" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                                <asp:ListItem Value="1">1 a 2</asp:ListItem>
                                                <asp:ListItem Value="2">2 a 5</asp:ListItem>
                                                <asp:ListItem Value="3">5 a 10</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Otros complementos">
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Text="Cargar hoja de vida"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:FileUpload ID="FileUpload1" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                        </WizardSteps>
                    </asp:Wizard>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
