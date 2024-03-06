using Newtonsoft.Json.Linq;
using STR_INTEGRACION_BPM_API.BL;
using STR_INTEGRACION_BPM_API.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace STR_INTEGRACION_BPM_API
{
    [RoutePrefix("api/asociado")]
    public class AsociadoController : ApiController
    {
        /*
        [Route]
        [HttpGet]
        public IHttpActionResult Get(string filtro, string id)
        {
           sQ_Asociado sQ_Asociado = new sQ_Asociado();
           var response = sQ_Asociado.ObtenerAsociado(filtro, id);

           return Ok(response);
        }
        */
        /*
        [Route]
        [HttpGet]
        public IHttpActionResult Get(string carnet)
        {
            sQ_Asociado sQ_Asociado = new sQ_Asociado();
            var response = sQ_Asociado.ObtenerAsociado(carnet);

            return Ok(response);
        }*/
    }
}