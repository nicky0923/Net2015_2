using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web.Modules
{
    public partial class EjemploApplicationResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMensaje.Text = CustomApplicationManager.MessageApplication;
        }
    }
}