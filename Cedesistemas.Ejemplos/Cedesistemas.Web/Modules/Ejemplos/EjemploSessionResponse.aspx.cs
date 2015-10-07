using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web.Modules
{
    public partial class EjemploSessionResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelResponse.Text = SessionManager.SessionNombre;
        }
    }
}