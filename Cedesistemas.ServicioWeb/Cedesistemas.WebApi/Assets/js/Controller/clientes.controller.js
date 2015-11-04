var clientes = {
    url: "http://localhost:20790/api/clientes",
    init: function () {

        console.log("Paso 1");
        $("#btnconsumirClientes").on("click", clientes.selectClientes);

    },
    selectClientes: function () {


        var crudServiceBaseUrl = "http://localhost:20790/api/clientes/",
                      dataSource = new kendo.data.DataSource({

                          transport:
                          {
                              read: {
                                  
                                  url: crudServiceBaseUrl,
                                  typedataType: "json"
                              },
                              update: {
                                  url: function(options) {
                                      return crudServiceBaseUrl + options.models[0].ClienteId;
                                  },
                                  typedataType: "json",
                                  type: "PUT",
                                  contentType: "application/json",
                                  
                              },
                              destroy:{
                                  url: function (options) {
                                      return crudServiceBaseUrl + options.models[0].ClienteId;
                                  },
                                  typedataType: "json",
                                  type: "DELETE",
                                  contentType: "application/json",
                              },
                              create: {
                                  url: crudServiceBaseUrl,
                                  typedataType: "json",
                                  type: "POST",
                                  contentType: "application/json",

                              },
                              parameterMap: function (options, operation) {
                                  if (operation !== "read" && options.models) {


                                      console.log(options.models[0]);
                                       return JSON.stringify(options.models[0]);
                                      //return { models: kendo.stringify(options.models) };
                                  }
                                  return null;
                              }
                          },
                          batch: true,
                          pageSize: 20,
                          schema: {
                              model: {
                                  id: "ClienteId",
                                  fields: {
                                      ClienteId: { type: "number", editable: false },
                                      Codigo: { type: "string" },
                                      Nombre: { type: "string" },
                                      Apellidos: { type: "string" },
                                      FechaNacimiento: { type: "date" }

                                  }
                              }
                          }
                      });

        $("#gridClientes").kendoGrid({
            dataSource: dataSource,
            pageable: true,
            height: 550,
            toolbar: ["create"],
            columns: [
              
                {
                    field: "Codigo",
                    title: "Código Cliente"
                },
                {
                    field: "Nombre",
                    title: "Nombre Cliente"
                }, {
                    field: "Apellidos",
                    title: "Apellidos Cliente"
                },
                {
                    field: "FechaNacimiento",
                    title: "Fecha Nacimiento",
                    format: "{0:MM/dd/yyyy}"
                },

                { command: ["edit", "destroy"], title: "&nbsp;", width: "250px" }],
            editable: "popup"
        });


        //$("#gridClientes").kendoGrid({
        //    dataSource: {
        //        type: "json",
        //        transport: {
        //            read: clientes.url
        //        },
        //        schema: {
        //            model: {
        //                fields: {
        //                    ClienteId: { type: "number" },
        //                    Codigo: { type: "string" },
        //                    Nombre: { type: "string" },
        //                    Apellidos: { type: "string" },
        //                    FechaNacimiento: { type: "date" }

        //                }
        //            }
        //        },
        //        pageSize: 20,
        //        serverPaging: true,
        //       // serverFiltering: true,
        //       // serverSorting: true
        //    },
        //    height: 550,
        //    filterable: true,
        //    sortable: true,
        //    pageable: true,
        //    columns: [
        //    {
        //        field: "ClienteId",
        //        filterable: false
        //    },
        //     {
        //         field: "Nombre",
        //         title: "Nombre Cliente"
        //     }, {
        //         field: "Apellidos",
        //         title: "Apellidos Cliente"
        //     },
        //     {
        //         field: "FechaNacimiento",
        //         title: "Fecha Nacimiento",
        //         format: "{0:MM/dd/yyyy}"
        //     }
        //    ]
        //});


        //var data;
        //$.ajax({
        //    url: clientes.url,
        //    type: "GET",
        //    async: false,
        //    dataType: "json",
        //    contentType: "application/json; charset=utf-8",
        //    success: function (res) {

        //      var cantidad =   res.length;
        //        bootbox.alert("Cantidad: " + cantidad);

        //    },
        //    error: function (res) {

        //        debugger;
        //    }
        //});

    },

};


clientes.init();