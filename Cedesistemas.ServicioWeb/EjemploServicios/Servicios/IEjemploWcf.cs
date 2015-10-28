using EjemploServicios.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EjemploServicios.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEjemploWcf" in both code and config file together.
    [ServiceContract]
    public interface IEjemploWcf
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int CalcularDato(int valor1, int valor2);

        [OperationContract]
        IList<PersonaDto> SelectAllPersonas();
    }
}
