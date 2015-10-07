<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BuscarPersona.ascx.cs" Inherits="Cedesistemas.Web.Controls.BuscarPersona" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="458px"></asp:TextBox>
            <asp:Button ID="buscar" runat="server" Text="" CssClass="glyphicon glyphicon-search" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceLIstadoPersonas" DataKeyNames="ClienteId,Nombre,Apellidos,Codigo">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ClienteId" HeaderText="ClienteId" SortExpression="ClienteId" />
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                    <asp:BoundField DataField="FechaNacimiento" DataFormatString="{0:yyyy/MM/dd}" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSourceLIstadoPersonas" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="BuscarPersonas" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="dato" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="ButtonAcceptar" runat="server" OnClick="ButtonAcceptar_Click" Text="Aceptar" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>

