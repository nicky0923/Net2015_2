using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Web.Controls;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web.Modules.Private.Procesos
{
    public partial class Reservas : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void ButtonConsultar_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            BuscarPersona1.BuscarDatoTxt = TextBoxCliente.Text;

            //TextBox txt = BuscarPersona1.FindControl("TextBox1") as TextBox;
            //txt.Text = TextBoxCliente.Text;



            //Control uc = LoadControl("../../../Controls/BuscarPersona.ascx") as BuscarPersona;
            //Panel1.Controls.Add(uc);
        }

        protected void TextBoxCliente_TextChanged(object sender, EventArgs e)
        {

        }

        protected void MyMetodo(object sender, EventArgs e, Clientes objclientes)
        {
            Panel1.Visible = false;
            TextBoxCliente.Text = objclientes.Codigo;
            LabelNombre.Text = string.Format("{0} {1}", objclientes.Nombre, objclientes.Apellidos);

        }
    }
}