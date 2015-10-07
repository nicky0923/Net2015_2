using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Cedesistemas.Web.Util;

namespace Cedesistemas.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            try
            {
                Exception error = Server.GetLastError();

                string message = (error.InnerException ?? error).Message;

                LogManager logManager = new LogManager();

                logManager.CreateLog(message);

                CustomApplicationManager.MessageApplication = @message;

                Response.Redirect("~/Error.aspx");

            }
            catch
            {

            }
           



        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}