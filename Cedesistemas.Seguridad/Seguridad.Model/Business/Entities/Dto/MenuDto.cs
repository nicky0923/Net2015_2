
namespace Seguridad.Model.Business.Entities.Dto
{
    public class MenuDto
    {
        public string Id
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public string[] Roles
        {
            get;
            set;
        }

        public int? ParentId
        {
            get;
            set;
        }
    }
}
