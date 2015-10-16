using Seguridad.Model.Business.Entities;
using Seguridad.Model.ResourceAccess.Dao;

namespace Seguridad.Model.Business.Logic
{
   internal class UsuarioBl
    {

       public bool AuntenticarUsuario(string userName, string password)
       {
           return new UsuarioDao().AuntenticarUsuario(userName, password);
       }

       public void CreateUser(Usuarios usuario)
       {
           new UsuarioDao().CreateUser(usuario);
       }
    }
}
