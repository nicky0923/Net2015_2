<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploFormView.aspx.cs" Inherits="Cedesistemas.Web.Modules.EjemploFormView" %>

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
                        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="CadenaId" DataSourceID="SqlDataSourceCadenas" Width="220px" CellPadding="4" DefaultMode="Insert" ForeColor="#333333">
                            <EditItemTemplate>
                                <br />
                                <table class="auto-style1">
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                                <br />
                                <br />
                                CadenaId:
                            <asp:Label ID="CadenaIdLabel1" runat="server" Text='<%# Eval("CadenaId") %>' />
                                <br />
                                Nombre:
                            <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                                <br />
                                Codigo:
                            <asp:TextBox ID="CodigoTextBox" runat="server" Text='<%# Bind("Codigo") %>' />
                                <br />
                                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                            </EditItemTemplate>
                            <EditRowStyle BackColor="#999999" />
                            <EmptyDataTemplate>
                                No hay datos
                            </EmptyDataTemplate>
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <FooterTemplate>
                                Formularion Cadenas
                            </FooterTemplate>
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderTemplate>
                                Formulario cadenas cabeza
                            </HeaderTemplate>
                            <InsertItemTemplate>
                                Nombre:
                            <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                                <br />
                                Codigo:
                            <asp:TextBox ID="CodigoTextBox" runat="server" Text='<%# Bind("Codigo") %>' />
                                <br />
                                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                            </InsertItemTemplate>
                            <ItemTemplate>
                                CadenaId:
                            <asp:Label ID="CadenaIdLabel" runat="server" Text='<%# Eval("CadenaId") %>' />
                                <br />
                                Nombre:
                            <asp:Label ID="NombreLabel" runat="server" Text='<%# Bind("Nombre") %>' />
                                <br />
                                Codigo:
                            <asp:Label ID="CodigoLabel" runat="server" Text='<%# Bind("Codigo") %>' />
                                <br />
                                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                            </ItemTemplate>
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        </asp:FormView>
                        <asp:SqlDataSource ID="SqlDataSourceCadenas" runat="server" ConnectionString="<%$ ConnectionStrings:AgenciaVIajesDbConnectionString %>" DeleteCommand="DELETE FROM [Cadenas] WHERE [CadenaId] = @CadenaId" InsertCommand="INSERT INTO [Cadenas] ([Nombre], [Codigo]) VALUES (@Nombre, @Codigo)" SelectCommand="SELECT * FROM [Cadenas]" UpdateCommand="UPDATE [Cadenas] SET [Nombre] = @Nombre, [Codigo] = @Codigo WHERE [CadenaId] = @CadenaId">
                            <DeleteParameters>
                                <asp:Parameter Name="CadenaId" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="Nombre" Type="String" />
                                <asp:Parameter Name="Codigo" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="Nombre" Type="String" />
                                <asp:Parameter Name="Codigo" Type="String" />
                                <asp:Parameter Name="CadenaId" Type="Int32" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                        <br />
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
