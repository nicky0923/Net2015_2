using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web.Modules
{
    public partial class EjemploApplicationRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {
            CustomApplicationManager.MessageApplication = TextBoxMensaje.Text;
            Response.Redirect("EjemploApplicationResponse.aspx");
        }
    }
}