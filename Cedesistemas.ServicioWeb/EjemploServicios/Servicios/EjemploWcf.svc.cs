using EjemploServicios.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EjemploServicios.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EjemploWcf" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EjemploWcf.svc or EjemploWcf.svc.cs at the Solution Explorer and start debugging.
    public class EjemploWcf : IEjemploWcf
    {
        public void DoWork()
        {
        }


        public int CalcularDato(int valor1, int valor2)
        {
            int[] arreglo = { valor1, valor2 };

            return arreglo.Max();

        }


        public IList<PersonaDto> SelectAllPersonas()
        {
           IList<PersonaDto> listado = new List<PersonaDto>();

            listado.Add(new PersonaDto
            {
                Nombre = "Juan Esteban",
                Apellidos = "Henao",
                FechaNacimiento = new DateTime(2002, 9, 23)
            });

            listado.Add(new PersonaDto
            {
                Nombre = "Patricia",
                Apellidos = "Martinez",
                FechaNacimiento = new DateTime(1984, 8, 14)
            });


            return listado;
        }
    }
}
