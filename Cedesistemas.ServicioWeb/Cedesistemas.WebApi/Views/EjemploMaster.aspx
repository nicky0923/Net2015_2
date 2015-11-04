<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Internal.Master" AutoEventWireup="true" CodeBehind="EjemploMaster.aspx.cs" Inherits="Cedesistemas.WebApi.Views.EjemploMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
        <link href="../Assets/Css/bootstrap.min.css" rel="stylesheet" />
        <link href="../Assets/Css/kendo.2013.3.1119/kendo.default.min.css" rel="stylesheet" />
        <link href="../Assets/Css/kendo.2013.3.1119/kendo.common.min.css" rel="stylesheet" />
        <link href="../Assets/Css/kendo.2013.3.1119/kendo.silver.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div>
    
        <Button type="button"  ID="Button1" onclick="consultar()" >Button</Button>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    
     <script src="../Assets/js/jquery.min.js"></script>
    <script src="../Assets/js/bootstrap.min.js"></script>
 
    <script src="../Assets/js/kendo/2013.3.1119/kendo.all.min.js"></script>
    <script src="../Assets/js/bootbox.min.js"></script>
    <script src="../Assets/js/Controller/ejemplo.controller.js"></script>
    <script>


        function consultar() {

            var control = $("#" + '<%=TextBox1.ClientID %>');

            ejemplo.buscarById(control.val());
            ;
            
        }

        

    </script>

</asp:Content>
