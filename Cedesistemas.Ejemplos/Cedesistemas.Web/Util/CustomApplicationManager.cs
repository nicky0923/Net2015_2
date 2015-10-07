using System.Web;

namespace Cedesistemas.Web.Util
{
    public class CustomApplicationManager
    {

        public static string MessageApplication
        {
            get
            {
                return (HttpContext.Current.Application["Mensaje"] ?? string.Empty).ToString();
            }
            set
            {
                HttpContext.Current.Application["Mensaje"] = value;

            }

        }

      
    }
}