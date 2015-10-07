using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cedesistemas.Web.Modules
{
    public partial class EjemploControles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCambiar_Click(object sender, EventArgs e)
        {
            //TextBox1.Visible = !TextBox1.Visible;
            TextBox1.TextMode = TextBoxMode.Password;
            
        }

        protected void TextBoxAtributos_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = TextBoxAtributos.Text;
        }

        protected void ImageButtonCalendario_Click(object sender, ImageClickEventArgs e)
        {
            PanelCalendario.Visible = true;
        }

        protected void CalendarFecha_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxFecha.Text = CalendarFecha.SelectedDate.ToShortDateString();
            PanelCalendario.Visible = false;

        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Wizard wizard = sender as Wizard;

            
        }
    }
}