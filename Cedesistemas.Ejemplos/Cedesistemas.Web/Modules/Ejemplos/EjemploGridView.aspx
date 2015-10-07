<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploGridView.aspx.cs" Inherits="Cedesistemas.Web.Modules.EjemploGridView" %>

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
                    <asp:GridView ID="GridViewCadenas" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CadenaId,Nombre" DataSourceID="SqlDataSourceCadenas" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridViewCadenas_SelectedIndexChanged" PageSize="3">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="CadenaId" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="CadenaId" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:TemplateField HeaderText="Codigo" SortExpression="Codigo">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Codigo") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text='<%# Bind("Codigo") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
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
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ClienteId" DataSourceID="SqlDataSourceClientes">
                        <Columns>
                            <asp:BoundField DataField="ClienteId" HeaderText="ClienteId" InsertVisible="False" ReadOnly="True" SortExpression="ClienteId" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                            <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                            <asp:BoundField DataField="Edad" HeaderText="Edad" ReadOnly="True" SortExpression="Edad" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSourceClientes" runat="server" ConnectionString="<%$ ConnectionStrings:AgenciaVIajesDbConnectionString %>" SelectCommand="SELECT        Clientes.*, DATEDIFF(YY,fechaNacimiento, getdate()) Edad
FROM            Clientes"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
