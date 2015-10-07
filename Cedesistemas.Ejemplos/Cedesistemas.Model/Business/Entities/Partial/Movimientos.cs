using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedesistemas.Model.Business.Entities
{
    public partial class Movimientos
    {

        public string NombreAgencia {
            get
            {
                return Agencias != null ? Agencias.Nombre : string.Empty;
            }
            set
            {
                

            }
        }

    }
}
