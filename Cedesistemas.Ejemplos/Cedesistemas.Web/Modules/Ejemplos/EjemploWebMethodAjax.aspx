<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploWebMethodAjax.aspx.cs" Inherits="Cedesistemas.Web.Modules.Ejemplos.EjemploWebMethodAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" rel="stylesheet" integrity="sha256-MfvZlkHCEqatNoGiOXveE8FIwMzZg4W85qfrfIFBfYc= sha512-dTfge/zgoMYpP7QbHy4gWMEGsbsdZeCXz7irItjcC3sPUFtf0kuFbDz/ixG7ArTxmDjLXDmezHubeNikyKGVyQ==" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js" integrity="sha256-Sk3nkD6mLTMOF0EOpNtsIry+s1CsaqQC1rVLTAy+0yc= sha512-K1qjQ+NcF2TYO/eI3M6v8EiNYZfA95pQumfvcVrTHtwQVDG+aHRqLi/ETn2uB+1JqwYqVG3LIvdm9lj6imS/pQ==" crossorigin="anonymous"></script>
    
    <link href="../../Assets/Css/kendo.2013.3.1119/kendo.default.min.css" rel="stylesheet" />
    <link href="../../Assets/Css/kendo.2013.3.1119/kendo.common.min.css" rel="stylesheet" />
    <link href="../../Assets/Css/kendo.2013.3.1119/kendo.silver.min.css" rel="stylesheet" />

    <script src="../../Assets/js/kendo/2013.2.716/kendo.all.min.js"></script>

    <script src="../../Assets/js/ejemploAjax.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" value="Llamar servicio" onclick="consumirMetodoWeb();" />
        </div>

        <table class="table" id="Clientes">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Id</th>
                </tr>

            </thead>
            <tbody></tbody>
        </table>
        
        
        
          <div>
            <input type="button" class="btn btn-success" value="Llamar servicio" onclick="bootGrid();" />
        </div>
  
        
        <div id="gridCLientes"></div>

    </form>
</body>
</html>
