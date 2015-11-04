<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejemplos.aspx.cs" Inherits="Cedesistemas.WebApi.Views.Ejemplos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
            <link href="../Assets/Css/bootstrap.min.css" rel="stylesheet" />
        <link href="../Assets/Css/kendo.2013.3.1119/kendo.default.min.css" rel="stylesheet" />
        <link href="../Assets/Css/kendo.2013.3.1119/kendo.common.min.css" rel="stylesheet" />
        <link href="../Assets/Css/kendo.2013.3.1119/kendo.silver.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button type="button" ID="Button1" runat="server" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
    
    
     
    <script src="../Assets/js/jquery.min.js"></script>
    <script src="../Assets/js/bootstrap.min.js"></script>
 
    <script src="../Assets/js/kendo/2013.3.1119/kendo.all.min.js"></script>
    <script src="../Assets/js/bootbox.min.js"></script>
    <script src="../Assets/js/Controller/ejemplo.controller.js"></script>
</body>
</html>
