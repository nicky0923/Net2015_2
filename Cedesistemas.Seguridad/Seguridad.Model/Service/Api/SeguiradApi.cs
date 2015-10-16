using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguridad.Model.Business.Entities;
using Seguridad.Model.Business.Logic;

namespace Seguridad.Model.Service.Api
{
    public class SeguiradApi
    {

        public bool AuntenticarUsuario(string userName, string password)
        {
            return new UsuarioBl().AuntenticarUsuario(userName, password);
        }

        public void CreateUser(Usuarios usuario)
        {
            new UsuarioBl().CreateUser(usuario);

        }
    }
}
