using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cedesistemas.Web.Util
{
    public class SessionManager
    {

        public static string SessionNombre {
            get
            {
                return (HttpContext.Current.Session["Nombre"] ?? string.Empty).ToString();

            }
            set
            {
                HttpContext.Current.Session["Nombre"] = value;
            }
        }

    }
}