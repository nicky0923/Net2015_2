<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Internal.Master" AutoEventWireup="true" CodeBehind="ClienteView.aspx.cs" Inherits="Cedesistemas.Web.Modules.Private.Maestros.ClienteView" Theme="ThemeVerde" %>

<%@ Register Src="../../../Controls/ControlFecha.ascx" TagName="ControlFecha" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="auto-style6">
                <tr>
                    <td>
                        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSourceCliente" DataKeyNames="ClienteId" DefaultMode="Insert" OnItemInserted="FormView1_ItemInserted" OnItemUpdated="FormView1_ItemUpdated">
                            <EditItemTemplate>
                                ClienteId:
                        <asp:TextBox ID="ClienteIdTextBox" runat="server" Text='<%# Bind("ClienteId") %>' ReadOnly="True" />
                                <br />
                                Codigo:
                        <asp:TextBox ID="CodigoTextBox" runat="server" Text='<%# Bind("Codigo") %>' />
                                <br />
                                Nombre:
                        <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                                <br />
                                Apellidos:
                        <asp:TextBox ID="ApellidosTextBox" runat="server" Text='<%# Bind("Apellidos") %>' />
                                <br />
                                Direccion:
                        <asp:TextBox ID="DireccionTextBox" runat="server" Text='<%# Bind("Direccion") %>' />
                                <br />
                                Telefono:
                        <asp:TextBox ID="TelefonoTextBox" runat="server" Text='<%# Bind("Telefono") %>' />
                                <br />
                                FechaNacimiento:
                        <uc1:ControlFecha ID="ControlFecha1" runat="server" FechaSeleccionada='<%#Bind("FechaNacimiento") %>' />
                                <br />
                                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                Codigo:
                        <asp:TextBox ID="CodigoTextBox" runat="server" Text='<%# Bind("Codigo") %>' />
                                <br />
                                Nombre:
                        <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                                <br />
                                Apellidos:
                        <asp:TextBox ID="ApellidosTextBox" runat="server" Text='<%# Bind("Apellidos") %>' />
                                <br />
                                Direccion:
                        <asp:TextBox ID="DireccionTextBox" runat="server" Text='<%# Bind("Direccion") %>' />
                                <br />
                                Telefono:
                        <asp:TextBox ID="TelefonoTextBox" runat="server" Text='<%# Bind("Telefono") %>' />
                                <br />
                                FechaNacimiento:
                        <uc1:ControlFecha ID="ControlFecha1" runat="server" FechaSeleccionada='<%#Bind("FechaNacimiento") %>' />
                                <br />
                                <br />
                                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                            </InsertItemTemplate>
                            <ItemTemplate>
                                ClienteId:
                        <asp:Label ID="ClienteIdLabel" runat="server" Text='<%# Bind("ClienteId") %>' />
                                <br />
                                Codigo:
                        <asp:Label ID="CodigoLabel" runat="server" Text='<%# Bind("Codigo") %>' />
                                <br />
                                Nombre:
                        <asp:Label ID="NombreLabel" runat="server" Text='<%# Bind("Nombre") %>' />
                                <br />
                                Apellidos:
                        <asp:Label ID="ApellidosLabel" runat="server" Text='<%# Bind("Apellidos") %>' />
                                <br />
                                Direccion:
                        <asp:Label ID="DireccionLabel" runat="server" Text='<%# Bind("Direccion") %>' />
                                <br />
                                Telefono:
                        <asp:Label ID="TelefonoLabel" runat="server" Text='<%# Bind("Telefono") %>' />
                                <br />
                                FechaNacimiento:
                        <asp:Label ID="FechaNacimientoLabel" runat="server" Text='<%# Bind("FechaNacimiento") %>' />
                                <br />
                                Movimientos:
                        <asp:Label ID="MovimientosLabel" runat="server" Text='<%# Bind("Movimientos") %>' />
                                <br />

                            </ItemTemplate>
                        </asp:FormView>
                        <asp:ObjectDataSource ID="ObjectDataSourceCliente" runat="server" DataObjectTypeName="Cedesistemas.Model.Business.Entities.Clientes"
                            TypeName="Cedesistemas.Model.Service.AgenciasViajesApi"
                            SelectMethod="SelectClienteById" OldValuesParameterFormatString="original_{0}" UpdateMethod="UpdateClientes" InsertMethod="InsertCliente">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSourceListaClientes" AutoGenerateColumns="False" AllowPaging="True" DataKeyNames="ClienteId" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
                                <asp:BoundField DataField="ClienteId" HeaderText="ClienteId" SortExpression="ClienteId" />
                                <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                                <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" DataFormatString="{0:MMMM d, yyyy}" SortExpression="FechaNacimiento" />
                            </Columns>
                        </asp:GridView>
                        <asp:ObjectDataSource ID="ObjectDataSourceListaClientes" runat="server" DataObjectTypeName="Cedesistemas.Model.Business.Entities.Clientes" DeleteMethod="DeleteCliente"
                            InsertMethod="InsertCliente" OldValuesParameterFormatString="original_{0}"
                            SelectMethod="SelectAllClientes" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi"></asp:ObjectDataSource>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <asp:FileUpload ID="FileUpload1" runat="server" />

            <asp:Button ID="ButtonGurdar" runat="server" OnClick="ButtonGurdar_Click" Text="Button" />
        </ContentTemplate>
    </asp:UpdatePanel>



</asp:Content>
