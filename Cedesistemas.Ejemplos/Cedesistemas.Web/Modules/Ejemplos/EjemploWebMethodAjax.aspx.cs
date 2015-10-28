using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.Service;

namespace Cedesistemas.Web.Modules.Ejemplos
{
    public partial class EjemploWebMethodAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        [WebMethod]
        [WebInvoke(Method = "GET",ResponseFormat = WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.WrappedRequest,UriTemplate = "/SeleccionarClientes")]
        public static IList<Clientes> SeleccionarClientes()
        {

            AgenciasViajesApi api = new AgenciasViajesApi();

            return api.SelectAllClientes();
        }

    }
}