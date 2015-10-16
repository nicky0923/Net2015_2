

namespace Seguridad
{
    using System.Web.Security;
    using Model.Business.Entities.Dto;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Web;
    public class CedeSiteMapProvider : StaticSiteMapProvider
    {
        private readonly object _lock = new object(); //El objeto tipo lock se utiliza para controlar secciones de codigo critico, Exclusión.
        private SiteMapNode _root;
        private string _aplicationName;
        private const bool AuthenticationWindows = false;
        private bool _block;
        private string _userName;


        public override void Initialize(string name, NameValueCollection attributes)
        {
            base.Initialize(name, attributes);
            if (attributes != null) _aplicationName = attributes["Applicattion"];
            //  authenticationWindows = bool.Parse((attributes["IsWindowsAuthentication"] ?? "false").ToString());
            _userName = HttpContext.Current.User.Identity.Name;
        }

        public override SiteMapNode BuildSiteMap()
        {
            lock (_lock)
            {
                if (_root != null && HttpContext.Current.User.Identity.Name == _userName)
                {
                    return _root;
                }

                _userName = HttpContext.Current.User.Identity.Name;
                //GetSiteMapNodeRootID trae el ID del nodo raíz
                Clear();
                _root = CreateSiteMap(GetSiteMapNodeRootId());
                try
                {
                    // ReSharper disable AssignNullToNotNullAttribute
                    AddNode(_root, null);
                    // ReSharper restore AssignNullToNotNullAttribute
                }
                catch { }

                return _root;
            }
        }

        protected override SiteMapNode GetRootNodeCore()
        {
            lock (_lock)
            {
                if (!_block)
                {
                    _block = true;
                    BuildSiteMap();
                    _block = false;   //Para que una vez que construya el siteMap no lo repita.                  
                }
                return _root;
            }
        }

        private SiteMapNode CreateSiteMap(string idNodo)
        {
            SiteMapNode nodo = GetSiteMapNode(idNodo);
            if (HasChilds(idNodo)) //Verifica si tiene hijos
            {
                //Recorre el nodo y se envía al método GetChildsNodeId, con el MISMO idNodo que entró con el fin de encotrar todos sus hijos (1.1).
                string[] childs = GetChildsNodeId(idNodo);
                foreach (string idNodoChild in childs)
                {
                    //Después de tener todos los "niveles" de los nodos, se crea el SiteMap.
                    SiteMapNode hijo = CreateSiteMap(idNodoChild);
                    //nodo.ChildNodes.Add(hijo);
                    if (IsAccessibleToUser(HttpContext.Current, hijo))
                    {
                        try
                        {
                            AddNode(hijo, nodo);
                        }
                        catch { } //Catch con excepción de tipo Blind
                    }
                }
            }
            //Si este es el nodo raíz, trae los hijos de este gracias al idNodo
            return nodo;
        }

        public string[] GetChildsNodeId(string idNodo)
        {
            IList<MenuDto> lista = CedeSiteMapCache.GetInstance(_aplicationName).ListaMenu;
            //Esta sentencia no va a la BD, trabaja sobre la lista MenuDTO
            var query = from p in lista
                        where p.ParentId.ToString() == idNodo
                        select p.Id;
            return query.ToArray();
        }

        private bool HasChilds(string idNodo)
        {
            //Verifica que si tenga hijos
            IList<MenuDto> lista = CedeSiteMapCache.GetInstance(_aplicationName).ListaMenu;
            var query = from p in lista
                        where p.ParentId.ToString() == idNodo
                        select p;

            if (query.Count() > 0)
            {
                return true;
            }
            return false;
        }

        private SiteMapNode GetSiteMapNode(string idNodo)
        {
            IList<MenuDto> lista = CedeSiteMapCache.GetInstance(_aplicationName).ListaMenu;
            //Aquí se crea el nodo como tal con los parámetros de la lista MenuDTO que ya estan listos desde la BD.
            var query = from p in lista
                        where p.Id == idNodo
                        select new SiteMapNode(this, p.Id, p.Url, p.Nombre, p.Descripcion, p.Roles, null, null, null);
            return query.First();
            //query.First() es el primer dato tipo SiteMapNode.
        }

        private string GetSiteMapNodeRootId()
        {
            //Obtiene el ID del Root, es decir el priemer nodo.
            IList<MenuDto> lista = CedeSiteMapCache.GetInstance(_aplicationName).ListaMenu;
            var query = from p in lista
                        where p.ParentId == null
                        select p.Id;
            return query.First();
        }

        public override bool IsAccessibleToUser(HttpContext context, SiteMapNode node)
        {
            //Obtiene a partir del userName los roles para ese usuario.
            string userName = context.User.Identity.Name;
            if (AuthenticationWindows)
            {
                userName = ExtractPureUsername(context.User.Identity.Name);
            }



            string[] rolesxUsuario = Roles.GetRolesForUser(userName);

            //return T/F dependiendo si hay nodos que contengan el rol.
            foreach (string rol in rolesxUsuario)
            {
                if (node.Roles.Contains(rol))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Extrae el nombre de usuario sin dominio
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private string ExtractPureUsername(string username)
        {
            string[] parts = username.Split('@');
            if (parts.Length == 2)
            {
                return parts[0];
            }

            parts = username.Split('\\');
            if (parts.Length == 2)
            {
                return parts[1];
            }

            return username;
        }
    }
}