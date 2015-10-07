<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Internal.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="Cedesistemas.Web.Modules.Private.Procesos.Reservas" %>

<%@ Register Src="../../../Controls/BuscarPersona.ascx" TagName="BuscarPersona" TagPrefix="uc1" %>

<%@ Register Src="../../../Controls/ControlFecha.ascx" TagName="ControlFecha" TagPrefix="uc2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            <asp:Label ID="Label2" runat="server" Text="GARGANDO .............."></asp:Label>
            <br />

            <br />
        </ProgressTemplate>
    </asp:UpdateProgress>

       <table class="nav-justified" id="divMovimientos">


                            <tr>

                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Cliente"></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="ButtonConsultar" CssClass="glyphicon glyphicon-search" OnClick="ButtonConsultar_Click" runat="server" Text=".." />
                                    <asp:TextBox ID="TextBoxCliente" runat="server" OnTextChanged="TextBoxCliente_TextChanged"></asp:TextBox>
                                    <asp:Panel ID="Panel1" runat="server" Visible="False" ScrollBars="Vertical">
                                        <uc1:BuscarPersona ID="BuscarPersona1" runat="server" OnMyEvento="MyMetodo" />
                                    </asp:Panel>
                                </td>
                                <td>
                                    <asp:Label ID="LabelNombre" runat="server"></asp:Label>
                                </td>
                            </tr>


                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Agencia"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListAgencias" runat="server" DataSourceID="ObjectDataSourceAgencias" DataTextField="Nombre" DataValueField="AgenciaId">
                                    </asp:DropDownList>
                                    <asp:ObjectDataSource ID="ObjectDataSourceAgencias" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllAgencias" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi"></asp:ObjectDataSource>
                                </td>
                                <td rowspan="3">
                                    <asp:GridView ID="GridViewServicios" runat="server">
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Hoteles"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListHoteless" runat="server" DataSourceID="ObjectDataSourceHoteles" DataTextField="Nombre" DataValueField="HotelId">
                                    </asp:DropDownList>
                                    <asp:ObjectDataSource ID="ObjectDataSourceHoteles" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllHoteles" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi"></asp:ObjectDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Vuelos"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListVuelos" runat="server" DataSourceID="ObjectDataSourceVuelos" DataTextField="Codigo" DataValueField="VueloId">
                                    </asp:DropDownList>
                                    <asp:ObjectDataSource ID="ObjectDataSourceVuelos" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectAllVuelos" TypeName="Cedesistemas.Model.Service.AgenciasViajesApi"></asp:ObjectDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Fecha Salida"></asp:Label>
                                </td>
                                <td>
                                    <uc2:ControlFecha ID="ControlFechaSalida" runat="server" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Fecha Llegada"></asp:Label>
                                </td>
                                <td>
                                    <uc2:ControlFecha ID="ControlFechaLlegada" runat="server" />
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" class="btn btn-success" Text="Guardar" />
                                    <asp:Button ID="Button3" runat="server" Text="Limpiar" class="btn btn-danger" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
            

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            
              
            <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="921px">
                <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Reservas" Height="100%" Width="600px">
                    <ContentTemplate>
                   

                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="listados reservas">

                    <ContentTemplate>
                    </ContentTemplate>
                </cc1:TabPanel>

            </cc1:TabContainer>


        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
