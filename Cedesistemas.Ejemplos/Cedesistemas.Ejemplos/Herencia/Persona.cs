

using System;

namespace Cedesistemas.Ejemplos.Herencia
{
    internal class Persona
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual void Imprimir()
        {
            Console.WriteLine("El nombre es {0}",Nombre);
            Console.WriteLine("El Apellido es {0}",Apellido);
        }
    }
}
