using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cedesistemas.Web.MasterPage
{
    public partial class Internal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("{0}?theme={1}", Request.Url, DropDownList1.SelectedValue));
        }

        
    }
}