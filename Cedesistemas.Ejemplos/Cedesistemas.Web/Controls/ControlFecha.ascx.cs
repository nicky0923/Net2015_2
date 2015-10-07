using System;
namespace Cedesistemas.Web.Controls
{
    public partial class ControlFecha : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        public DateTime? FechaSeleccionada
        {
            get
            {

                if (!string.IsNullOrEmpty(TextBoxFecha.Text))
                {
                    DateTime outDT;
                    bool valida = DateTime.TryParse(TextBoxFecha.Text, out outDT);
                    if (valida)
                    {
                        return DateTime.Parse(TextBoxFecha.Text);
                    }
                    return null;
                }
                return null;
            }
            set
            {
                if (value != null) TextBoxFecha.Text = value.Value.ToString("yyyy/MM/dd");
                
            }
        }


    }
}