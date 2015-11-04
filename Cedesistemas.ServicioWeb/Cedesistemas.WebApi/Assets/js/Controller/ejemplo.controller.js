var ejemplo =
{
    init: function () {
        
      //  $('#' + '<%= Button1.ClientID %>').on("click", ejemplo.buscarById);
       
    },
    buscarById: function (id) {

        bootbox.alert("Dato a buscar: "+id );

    },
    buscarByName: function () {
        
    }
};

ejemplo.init();


