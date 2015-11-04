using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploConsumoConsola.ServiceEsteban;

namespace EjemploConsumoConsola
{
    class Program
    {
        static void Main(string[] args)
        {


            using (ServiceEsteban.Service1SoapClient client = new Service1SoapClient())
            {

                string valor = client.GetInfoNombrePropietarioCupon("AF54HT98");

                Console.WriteLine(valor);
                Console.Read();
            }
        }
    }
}
