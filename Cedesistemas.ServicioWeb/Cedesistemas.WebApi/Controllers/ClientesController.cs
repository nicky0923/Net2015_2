using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.Service;

namespace Cedesistemas.WebApi.Controllers
{
    public class ClientesController : ApiController
    {
        // GET api/clientes
        public HttpResponseMessage Get()
        {
            try
            {

                var body = new AgenciasViajesApi().SelectAllClientes();
                if (body != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, body);
                }
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content =
                        new StringContent(string.Format("Error: {0} -- Error Asociado{1}", ex.Message,
                            ex.InnerException != null ? ex.InnerException.Message : ""))
                };
                return response;
            }


           
        }

        // GET api/clientes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/clientes
        public void Post(Clientes value)
        {
        }

        // PUT api/clientes/5
        public void Put(int id, Clientes value)
        {
        }

        // DELETE api/clientes/5
        public void Delete(int id)
        {
        }
    }
}
