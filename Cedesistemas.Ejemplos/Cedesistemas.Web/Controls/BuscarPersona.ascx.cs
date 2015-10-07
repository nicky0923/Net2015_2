using System;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Web.Controls
{
    public partial class BuscarPersona : System.Web.UI.UserControl
    {

        public string BuscarDatoTxt {
            get
            {
                return TextBox1.Text;

            }
            set
            {
                TextBox1.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public delegate void MyDelegate(object sender, EventArgs e, Clientes objClientes);

        public event MyDelegate MyEvento;


        
        

        protected void ButtonAcceptar_Click(object sender, EventArgs e)
        {
            
            if (MyEvento != null)
            {
                if (GridView1.SelectedDataKey != null)
                {
                    Clientes cliente = new Clientes
                    {
                        ClienteId =  (int)GridView1.SelectedDataKey[0],
                        Nombre = GridView1.SelectedDataKey[1].ToString(),
                        Apellidos = GridView1.SelectedDataKey[2].ToString(),
                        Codigo = GridView1.SelectedDataKey[3].ToString(),

                    };
                


                    MyEvento(sender,e,cliente);
                }
            }
        }
    }
}