
using System;

namespace Cedesistemas.Ejemplos.Herencia
{
    internal class Empleado : Persona
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("El cargo es {0}",Cargo);
            Console.WriteLine("El Salario es {0}",Salario);
        }
    }
}
