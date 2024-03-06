using STR_INTEGRACION_BPM_API.BL;
using STR_INTEGRACION_BPM_API.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace STR_INTEGRACION_BPM_API
{
    [RoutePrefix("api/membresia")]
    public class MembresiaController : ApiController
    {
        /*
        [Route]
        [HttpGet]
        public IHttpActionResult Get(string filtro, string id)
        {
            try
            {
                sQ_Asociado sQ_Asociado = new sQ_Asociado();
                var response = sQ_Asociado.ObtenerAsociado(filtro, id);

                return Json(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
        */

        [Route]
        [HttpGet]
        public IHttpActionResult Get(string carnet)
        {
            sQ_Asociado sQ_Asociado = new sQ_Asociado();
            var response = sQ_Asociado.ObtenerAsociado(carnet);

            return Ok(response);
        }

        [Route]
        [HttpPatch]
        public IHttpActionResult Patch(List<Membresia> membresias)
        {
            sQ_Asociado sQ_Asociado = new sQ_Asociado();
            var response = sQ_Asociado.ActualizarMembresia(membresias);

            return Ok(response);
        }
    }
}