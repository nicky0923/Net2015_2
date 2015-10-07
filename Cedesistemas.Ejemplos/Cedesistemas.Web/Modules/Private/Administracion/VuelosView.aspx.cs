using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.Service;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web.Modules.Private.Administracion
{
    public partial class VuelosView : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridViewVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormViewVuelo.ChangeMode(FormViewMode.Edit);
            FormViewVuelo.DataBind();
        }

        protected void FormViewVuelo_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {

        }



        protected void RefreshGridView(object sender, EventArgs e)
        {
          GridViewVuelos.DataBind();
        }

        protected void CustomValidatorCodigo_ServerValidate(object source, ServerValidateEventArgs args)
        {
            AgenciasViajesApi api = new AgenciasViajesApi();

            args.IsValid = api.SelectAllVuelos().SingleOrDefault(p => p.Codigo == args.Value) == null;

            

            

        }
    }
}