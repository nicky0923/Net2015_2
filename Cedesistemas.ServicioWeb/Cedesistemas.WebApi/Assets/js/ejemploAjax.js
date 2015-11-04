





function consumirMetodoWeb() {

    $.ajax({
        url: "EjemploWebMethodAjax.aspx/SeleccionarClientes",
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (res) {
            //  debugger;
            //alert(res.d);
            console.log(res.d);

            var data = res.d;
            var table = $("#Clientes tbody");
            $.each(data, function (idx, elem) {
                console.log(elem.Nombre);
                console.log(elem.ClienteId);
                table.append("<tr><td>" + elem.Nombre + "</td><td>" + elem.ClienteId + "</td></tr>");
            });

        },
        error: function (res) {
            //debugger;
            alert("error");

        }
    });



}


function bootGrid() {

    var data;
    $.ajax({
        url: "EjemploWebMethodAjax.aspx/SeleccionarClientes",
        type: "POST",
        async: false,
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (res) {
            //  debugger;
            //alert(res.d);
            console.log(res.d);

            data = res.d;

        },
        error: function (res) {
            //debugger;
            alert("error");

        }
    });

    //var data2 = {
    //    Clientes: [
    //        {
    //            Nombre: "JOn",
    //            ClienteId: "12233"
    //        },
    //{
    //    Nombre: "Maria",
    //    ClienteId: "3333"
    //}
    //    ]


    //};



    $("#gridCLientes").kendoGrid({
        dataSource: {
            data: data,

            schema: {
                model: {
                    fields: {
                        ClienteId: { type: "number" },
                        Nombre: { type: "string" },
                    }
                }
            },
            pageSize: 20,
            serverPaging: true,
            serverFiltering: true,
            serverSorting: true
        },
        height: 550,
        filterable: true,
        sortable: true,
        pageable: true,
        groupable: true,
        editable: "popup",
        toolbar: ["create"],
        columns: [{
            field: "ClienteId",
            filterable: false
        },
            {
                field: "Nombre",
                title: "Nombre Ciente",

            },
             { command: ["edit", "destroy"], title: "&nbsp;", width: "250px" },
        ]
    });



}