using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguridad.Model.Business.Entities;

namespace Seguridad.Model.ResourceAccess.Dao
{
    internal class UsuarioDao
    {

        public bool AuntenticarUsuario(string userName, string password)
        {
            using (SeguridadCedeEntities entities = new SeguridadCedeEntities())
            {
                return
                    entities.Usuarios.SingleOrDefault(p => p.UserName.Equals(userName) && p.Password.Equals(password)) != null;

            }

        }

        public void CreateUser(Usuarios usuario)
        {
            using (SeguridadCedeEntities entities = new SeguridadCedeEntities())
            {

                entities.Usuarios.Add(usuario);
                entities.SaveChanges();
            }
        }
    }
}
