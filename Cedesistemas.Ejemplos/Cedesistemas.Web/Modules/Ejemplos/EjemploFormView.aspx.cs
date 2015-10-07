using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cedesistemas.Web.Modules
{
    public partial class EjemploFormView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numerador = int.Parse(TextBox1.Text);
            int denominador = int.Parse(TextBox2.Text);

            var resultado = numerador/denominador;

        }
    }
}