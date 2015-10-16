using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seguridad.Model.Business.Entities.Dto;

namespace Seguridad
{
    internal class CedeSiteMapCache
    {




        private static CedeSiteMapCache instance;
        internal IList<MenuDto> ListaMenu;
        private static DateTime fechaCreacion;
        internal CedeSiteMapCache(string applicationName)
        {
            fechaCreacion = DateTime.Now;
            ListaMenu = new List<MenuDto>(); // llmar el modelo para traerlo de la base de datos

            string[] todos = { "Administrador", "Usuario" };
            string[] admin = { "Administrador" };
            ListaMenu.Add(new MenuDto
            {
                Id = "1",
                Descripcion = "Menu padre",
                Nombre = "Menu Padre",
                ParentId = null,
                Roles = todos,
                Url = @"~/Principal.aspx"
                

            });
            ListaMenu.Add(new MenuDto
            {
                Id = "2",
                Descripcion = "Maestros",
                Nombre = "Maestros",
                ParentId = 1,
                Roles = todos,
                Url = @"",
                


            });
            ListaMenu.Add(new MenuDto
            {
                Id = "3",
                Descripcion = "CLientes",
                Nombre = "CLientes",
                ParentId = 2,
                Roles = admin,
                Url = @"~/Modules/Private/Maestros/ClienteView.aspx"


            });
            ListaMenu.Add(new MenuDto
            {
                Id = "4",
                Descripcion = "Procesos",
                Nombre = "Procesos",
                ParentId = 1,
                Roles = todos,
                Url = @""


            });


        }
        public static CedeSiteMapCache GetInstance(string applicationName)
        {

            if (instance == null || HasExpired())
            {
                instance = new CedeSiteMapCache(applicationName);
                return instance;
            }
            return instance;


        }

        private static bool HasExpired()
        {
            // TODO: Poner en IT-Configuration
            int minutos = 15;
            TimeSpan tiempoTranscurrido = TimeSpan.FromMinutes((double)minutos);
            DateTime fechaExpiracion = fechaCreacion.Add(tiempoTranscurrido);
            if (DateTime.Now > fechaExpiracion)
            {
                return true;
            }
            return false;
        }

    }
}