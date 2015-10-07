using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Cedesistemas.Web.Util
{
    public class LogManager
    {
        public void CreateLog(string mensaje)
        {

            // Create a new stream to write to the file 
            StreamWriter sw = new StreamWriter(@"D:\\LogCede\Log.txt", true);
            // Write a string to the file 
            sw.WriteLine("{0} >>>> {1}", DateTime.Now, mensaje);
            // Close Strem
            sw.Flush();
            sw.Close();



        }
    }
}