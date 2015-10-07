using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web.Modules.Private.Maestros
{
    public partial class ClienteView : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager1.RegisterPostBackControl(ButtonGurdar);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)GridView1.SelectedValue;

            AgenciasViajesApi api = new AgenciasViajesApi();

            Clientes cliente = api.SelectClienteById(id);

            GridView2.AutoGenerateColumns = true;
            GridView2.DataSource = cliente.Movimientos;
            GridView2.DataBind();

            FormView1.ChangeMode(FormViewMode.Edit);
            FormView1.DataBind();
        }

        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void ButtonGurdar_Click(object sender, EventArgs e)
        {
            
        }
    }
}