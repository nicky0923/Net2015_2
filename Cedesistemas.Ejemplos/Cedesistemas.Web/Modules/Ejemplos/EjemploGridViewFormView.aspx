<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploGridViewFormView.aspx.cs" Inherits="Cedesistemas.Web.Modules.EjemploGridViewFormView" %>

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
                    <asp:FormView ID="FormView1" runat="server" DataKeyNames="CadenaId" DataSourceID="SqlDataSourceCadenas" DefaultMode="Insert" Height="59px" OnItemInserted="FormView1_ItemInserted" OnItemUpdated="FormView1_ItemUpdated" Width="82px">
                        <EditItemTemplate>
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
                        <InsertItemTemplate>
                            Nombre:
                            <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                            <br />
                            Codigo:
                            <asp:TextBox ID="CodigoTextBox" runat="server" Text='<%# Bind("Codigo") %>' />
                            <br />
                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
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

                        </ItemTemplate>
                    </asp:FormView>
                    <asp:SqlDataSource ID="SqlDataSourceCadenas" runat="server" ConnectionString="<%$ ConnectionStrings:AgenciaVIajesDbConnectionString %>" DeleteCommand="DELETE FROM [Cadenas] WHERE [CadenaId] = @CadenaId" InsertCommand="INSERT INTO [Cadenas] ([Nombre], [Codigo]) VALUES (@Nombre, @Codigo)" SelectCommand="SELECT * FROM [Cadenas] where cadenaId = @cadenaId" UpdateCommand="UPDATE [Cadenas] SET [Nombre] = @Nombre, [Codigo] = @Codigo WHERE [CadenaId] = @CadenaId">
                        <DeleteParameters>
                            <asp:Parameter Name="CadenaId" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Nombre" Type="String" />
                            <asp:Parameter Name="Codigo" Type="String" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="GridView1" Name="cadenaId" PropertyName="SelectedValue" />
                        </SelectParameters>
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
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CadenaId" DataSourceID="SqlDataSourceLIstaCadenas" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="CadenaId" HeaderText="CadenaId" InsertVisible="False" ReadOnly="True" SortExpression="CadenaId" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSourceLIstaCadenas" runat="server" ConnectionString="<%$ ConnectionStrings:AgenciaVIajesDbConnectionString %>" SelectCommand="SELECT Cadenas.* FROM Cadenas"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
