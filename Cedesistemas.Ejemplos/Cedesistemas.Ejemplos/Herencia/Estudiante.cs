using System;

namespace Cedesistemas.Ejemplos.Herencia
{
    internal class Estudiante:Persona
    {
        public string Carrera { get; set; }
        public string Semestre { get; set; }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("La carrera es {0}", Carrera);
            Console.WriteLine("El semestre es {0}", Semestre);

        }
    }
}
