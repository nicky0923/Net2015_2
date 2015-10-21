using EjemploServicios.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EjemploServicios.Servicios
{
    /// <summary>
    /// Summary description for EjemploAsmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EjemploAsmx : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

         [WebMethod]
        public int CalcularMayor(int valor1, int valor2)
        {

            int[] arreglo = {valor1, valor2};

            return arreglo.Max();

        }

        [WebMethod]
        public List<PersonaDto> SelectAllPersonas()
        {
            List<PersonaDto> listado = new List<PersonaDto>();

            listado.Add(new PersonaDto
            {
                Nombre = "Juan Esteban",
                Apellidos = "Henao",
                FechaNacimiento = new DateTime(2002,9,23)
            });

            listado.Add(new PersonaDto
            {
                Nombre = "Patricia",
                Apellidos = "Martinez",
                FechaNacimiento = new DateTime(1984, 8, 14)
            });


            return listado;

        }
        [WebMethod(MessageName = "SelectAllPersonasAdd")]
        public List<PersonaDto> SelectAllPersonas(PersonaDto personaDto)
        {
            List<PersonaDto> listado = new List<PersonaDto>();

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

            listado.Add(personaDto);

            return listado;

        }

    }
}
