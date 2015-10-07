using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cedesistemas.Web.Modules
{
    public partial class EjemploViewState : System.Web.UI.Page
    {

        public string DatoViewState {
            get
            {

                return (ViewState["Dato"] ?? string.Empty).ToString();
            }
            set
            {
                ViewState["Dato"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DatoViewState))
            {
                TextBoxNombre.Text = DatoViewState;
            }
        }

        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {
            DatoViewState = TextBoxNombre.Text;
        }
    }
}