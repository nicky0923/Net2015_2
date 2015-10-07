using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Cedesistemas.Web.Util
{
    public class BasePage: Page
    {
        protected override void OnPreInit(EventArgs e)
        {

            switch (Request.QueryString["theme"])
            {
                case "Blue":
                    Page.Theme = "ThemeAzul";
                    break;
                case "green":
                    Page.Theme = "ThemeVerde";
                    break;
            }

            base.OnPreInit(e);
        }

    }
}