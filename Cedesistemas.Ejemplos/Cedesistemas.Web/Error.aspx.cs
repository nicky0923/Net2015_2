﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMensaje.Text = CustomApplicationManager.MessageApplication;
            CustomApplicationManager.MessageApplication = string.Empty;
        }
    }
}