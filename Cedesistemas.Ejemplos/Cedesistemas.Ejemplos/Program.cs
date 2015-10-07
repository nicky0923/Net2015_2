using System;
using System.Collections.Generic;
using Cedesistemas.Ejemplos.Estructuras;
using Cedesistemas.Ejemplos.Herencia;

namespace Cedesistemas.Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region EjemploPolimorfismo

            //Persona empleado = new Empleado
            //{
            //    Nombre = "John Fernando",
            //    Apellido = "Henao López",
            //    Salario = 655533,
            //    Cargo = "Arquitecto de software"
            //};
            //Persona estudiante = new Estudiante
            //{
            //    Nombre = "Juan Esteban",
            //    Apellido = "Henao Jurado",
            //    Carrera = "Futbolista",
            //    Semestre = "1-2005"
            //};

            //IList<Persona> arregloPersonas = new List<Persona>();
            //arregloPersonas.Add(empleado);
            //arregloPersonas.Add(estudiante);
            //foreach (var item in arregloPersonas)
            //{
            //    item.Imprimir();
            //}

    




            #endregion

            #region EjemploEstructurasClases

            StructTercero structTercero = new StructTercero
            {
                Id = 0,
                Nit = "90078899",
                RazonSocial = "Conexus202"
            };

            Tercero tercero = new Tercero
            {
                Id = 0,
                Nit = "90078899",
                RazonSocial = "Cedesistemas"
            };

            try
            {
                new Program().CambiarInformacionTercero(structTercero);
                new Program().CambiarInformacionTercero(tercero);
            }
            catch (Exception e)
            {
                    
                throw new Exception(e.Message);
            }
          

            #endregion

            #region TiposDatos

            int? enteroNull = null;
            float? floatNull = null;

            int valor = enteroNull ?? 20;

            #endregion

            Console.ReadLine();

        }

        public void CambiarInformacionTercero(StructTercero structTercero)
        {
            // es mala practica tener este try sabiendo que en el program
            // ya se esta controlando el error
            try
            {
                structTercero.Id++;
                structTercero.RazonSocial = "No tiene razón social";

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
           
        }

        public void CambiarInformacionTercero(Tercero tercero)
        {
            tercero.Id ++;
            tercero.RazonSocial = "No tiene razón social";
        }
    }
}
