<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Internal.Master" AutoEventWireup="true" CodeBehind="VuelosView.aspx.cs" Inherits="Cedesistemas.Web.Modules.Private.Administracion.VuelosView" %>
<%@ Register src="../../../Controls/ControlFecha.ascx" tagname="ControlFecha" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <table class="nav-justified">
        <tr>
            <td>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:FormView ID="FormViewVuelo" runat="server" DataSourceID="ObjectDataSourceVuelo" DefaultMode="Insert" DataKeyNames="VueloId" OnItemInserted="RefreshGridView" OnItemUpdated="RefreshGridView">
                    <EditItemTemplate>
                        <table class="nav-justified">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="CodigoTextBox" runat="server" Text='<%# Bind("Codigo") %>' />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo" runat="server" ControlToValidate="CodigoTextBox" ErrorMessage="El código es requerido" ValidationGroup="update">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Fecha Vuelo"></asp:Label>
                                </td>
                                <td>
                                    <uc1:ControlFecha ID="ControlFecha2" runat="server" FechaSeleccionada='<%# Bind("FechaVuelo") %>' />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Hora Vuelo"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="HoraVueloTextBox" runat="server" Text='<%# Bind("HoraVuelo") %>' />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo1" runat="server" ControlToValidate="HoraVueloTextBox" ErrorMessage="La hora es requerida" ValidationGroup="update">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Origen"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSourceCiudades" DataTextField="Nombre" DataValueField="CiudadId" SelectedValue='<%# Bind("CiudadIdOrigen") %>'>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Destino"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSourceCiudades" DataTextField="Nombre" DataValueField="CiudadId" SelectedValue='<%# Bind("CiudadIdDestino") %>'>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Nro Ejecutiva"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="NumeroPlazaEjecutivaTextBox" runat="server" Text='<%# Bind("NumeroPlazaEjecutiva") %>' TextMode="Number" />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo2" runat="server" ControlToValidate="NumeroPlazaEjecutivaTextBox" ErrorMessage="Valor plaza requerido" ValidationGroup="update">*</asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="NumeroPlazaEjecutivaTextBox" ErrorMessage="El valor debe estar entre 0 y 99" MaximumValue="99" MinimumValue="0" ValidationGroup="update">*</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Nro turista"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="NumeroPlazaTuristaTextBox" runat="server" Text='<%# Bind("NumeroPlazaTurista") %>' />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo3" runat="server" ControlToValidate="NumeroPlazaTuristaTextBox" ErrorMessage="Nro plaza turista requerido" ValidationGroup="update">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="Cadena"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="ObjectDataSourceCadenas" DataTextField="Nombre" DataValueField="CadenaId" SelectedValue='<%# Bind("CadenaId") %>'>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        <asp:ObjectDataSource ID="ObjectDataSourceCadenas" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllCadenas" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi"></asp:ObjectDataSource>
                        <br />
                        <br />
                        <asp:ObjectDataSource ID="ObjectDataSourceCiudades" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllCiudades" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi"></asp:ObjectDataSource>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="update" />
                        <br />
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" ValidationGroup="update" />
                        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <table class="nav-justified">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="CodigoTextBox" runat="server" Text='<%# Bind("Codigo") %>' />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo" runat="server" ControlToValidate="CodigoTextBox" ErrorMessage="El código es requerido" ValidationGroup="insertar">*</asp:RequiredFieldValidator>
                                    <asp:CustomValidator ID="CustomValidatorCodigo" runat="server" ControlToValidate="CodigoTextBox" ErrorMessage="EL código a existe" OnServerValidate="CustomValidatorCodigo_ServerValidate" ToolTip="EL código a existe" ValidationGroup="insertar">*</asp:CustomValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Fecha Vuelo"></asp:Label>
                                </td>
                                <td>
                                    <uc1:ControlFecha ID="ControlFecha2" runat="server"   FechaSeleccionada='<%# Bind("FechaVuelo") %>'/>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Hora Vuelo"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="HoraVueloTextBox" runat="server" Text='<%# Bind("HoraVuelo") %>' />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo1" runat="server" ControlToValidate="HoraVueloTextBox" ErrorMessage="La hora es requerida" ValidationGroup="insertar">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Origen"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSourceCiudades" DataTextField="Nombre" DataValueField="CiudadId" SelectedValue='<%# Bind("CiudadIdOrigen") %>'>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Destino"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSourceCiudades" DataTextField="Nombre" DataValueField="CiudadId" SelectedValue='<%# Bind("CiudadIdDestino") %>'>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Nro Ejecutiva"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="NumeroPlazaEjecutivaTextBox" runat="server" Text='<%# Bind("NumeroPlazaEjecutiva") %>' TextMode="Number" />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo2" runat="server" ControlToValidate="NumeroPlazaEjecutivaTextBox" ErrorMessage="Valor plaza requerido" ValidationGroup="insertar">*</asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="NumeroPlazaEjecutivaTextBox" ErrorMessage="El valor debe estar entre 0 y 99" MaximumValue="99" MinimumValue="0" ValidationGroup="insertar">*</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Nro turista"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="NumeroPlazaTuristaTextBox" runat="server" Text='<%# Bind("NumeroPlazaTurista") %>' />
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCodigo3" runat="server" ControlToValidate="NumeroPlazaTuristaTextBox" ErrorMessage="Nro plaza turista requerido" ValidationGroup="insertar">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="Cadena"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="ObjectDataSourceCadenas" DataTextField="Nombre" DataValueField="CadenaId" SelectedValue='<%# Bind("CadenaId") %>'>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        <asp:ObjectDataSource ID="ObjectDataSourceCadenas" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllCadenas"></asp:ObjectDataSource>
                        <br />
                        <br />
                        <asp:ObjectDataSource ID="ObjectDataSourceCiudades" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllCiudades"></asp:ObjectDataSource>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="insertar" />
                        <br />
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" ValidationGroup="insertar" />
                        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        VueloId:
                        <asp:Label ID="VueloIdLabel" runat="server" Text='<%# Bind("VueloId") %>' />
                        <br />
                        Codigo:
                        <asp:Label ID="CodigoLabel" runat="server" Text='<%# Bind("Codigo") %>' />
                        <br />
                        FechaVuelo:
                        <asp:Label ID="FechaVueloLabel" runat="server" Text='<%# Bind("FechaVuelo") %>' />
                        <br />
                        HoraVuelo:
                        <asp:Label ID="HoraVueloLabel" runat="server" Text='<%# Bind("HoraVuelo") %>' />
                        <br />
                        CiudadIdOrigen:
                        <asp:Label ID="CiudadIdOrigenLabel" runat="server" Text='<%# Bind("CiudadIdOrigen") %>' />
                        <br />
                        CiudadIdDestino:
                        <asp:Label ID="CiudadIdDestinoLabel" runat="server" Text='<%# Bind("CiudadIdDestino") %>' />
                        <br />
                        NumeroPlazaEjecutiva:
                        <asp:Label ID="NumeroPlazaEjecutivaLabel" runat="server" Text='<%# Bind("NumeroPlazaEjecutiva") %>' />
                        <br />
                        NumeroPlazaTurista:
                        <asp:Label ID="NumeroPlazaTuristaLabel" runat="server" Text='<%# Bind("NumeroPlazaTurista") %>' />
                        <br />
                        CadenaId:
                        <asp:Label ID="CadenaIdLabel" runat="server" Text='<%# Bind("CadenaId") %>' />
                        <br />
                        Cadenas:
                        <asp:Label ID="CadenasLabel" runat="server" Text='<%# Bind("Cadenas") %>' />
                        <br />
                        Ciudades:
                        <asp:Label ID="CiudadesLabel" runat="server" Text='<%# Bind("Ciudades") %>' />
                        <br />
                        Ciudades1:
                        <asp:Label ID="Ciudades1Label" runat="server" Text='<%# Bind("Ciudades1") %>' />
                        <br />
                        Movimientos:
                        <asp:Label ID="MovimientosLabel" runat="server" Text='<%# Bind("Movimientos") %>' />
                        <br />
                        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                        &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                    </ItemTemplate>
                </asp:FormView>
                <asp:ObjectDataSource ID="ObjectDataSourceVuelo" runat="server" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi" DataObjectTypeName="Cedesistemas.Model.Business.Entities.Vuelos" InsertMethod="InsertVuelo" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectVueloById" UpdateMethod="UpdateVuelos">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridViewVuelos" Name="id" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridViewVuelos" runat="server" DataSourceID="ObjectDataSourceLIstaVuelos" AutoGenerateColumns="False" DataKeyNames="VueloId" OnSelectedIndexChanged="GridViewVuelos_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="VueloId" HeaderText="VueloId" SortExpression="VueloId" />
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                        <asp:BoundField DataField="FechaVuelo" HeaderText="FechaVuelo" SortExpression="FechaVuelo" />
                        <asp:BoundField DataField="HoraVuelo" HeaderText="HoraVuelo" SortExpression="HoraVuelo" />
                        <asp:BoundField DataField="Ciudades1.Nombre" HeaderText="Ciudad Origen" SortExpression="Ciudades1.Nombre" />
                        <asp:BoundField DataField="Ciudades1.Departamentos.Nombre" HeaderText="Departamento Origen" SortExpression="Ciudades1.Departamentos.Nombre" />
                        <asp:BoundField DataField="Ciudades.Nombre" HeaderText="Ciudad Destino" SortExpression="Ciudades.Nombre" />
                        <asp:BoundField DataField="Ciudades.Departamentos.Nombre" HeaderText="Departamento Destino" SortExpression="Ciudades.Departamentos.Nombre" />
                        <asp:BoundField DataField="NumeroPlazaEjecutiva" HeaderText="NumeroPlazaEjecutiva" SortExpression="NumeroPlazaEjecutiva" />
                        <asp:BoundField DataField="NumeroPlazaTurista" HeaderText="NumeroPlazaTurista" SortExpression="NumeroPlazaTurista" />
                        <asp:BoundField DataField="CadenaId" HeaderText="CadenaId" SortExpression="CadenaId" />
                        <asp:BoundField DataField="Cadenas.Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSourceLIstaVuelos" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllVuelos"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
        </ContentTemplate>
    </asp:UpdatePanel>
   
</asp:Content>
