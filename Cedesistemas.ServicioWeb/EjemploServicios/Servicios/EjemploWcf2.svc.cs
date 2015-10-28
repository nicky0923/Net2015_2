using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EjemploServicios.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EjemploWcf2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EjemploWcf2.svc or EjemploWcf2.svc.cs at the Solution Explorer and start debugging.
    public class EjemploWcf2 : IEjemploWcf
    {
        public void DoWork()
        {
        }


        public int CalcularDato(int valor1, int valor2)
        {
           int[] array = {valor1,valor2};

           return array.Min();
        }


        public IList<Dto.PersonaDto> SelectAllPersonas()
        {
            throw new NotImplementedException();
        }
    }
}
