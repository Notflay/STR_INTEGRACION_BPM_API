using Newtonsoft.Json.Linq;
using STR_INTEGRACION_BPM_API.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STR_INTEGRACION_BPM_API.BL
{
    public class Global
    {
        
        public static ConsultationResponse ReturnError(Exception ex)
        {
            return new ConsultationResponse
            {
                CodRespuesta = "99",
                DescRespuesta = ex.Message,

            };
        }

        public static ConsultationResponse ReturnOk(JToken data)
        {
            string respOk = "OK";
            return new ConsultationResponse
            {
                CodRespuesta = data != null ? "00" : "22",
                DescRespuesta = data != null ? respOk : "No se encontró información",
                Result = data
            };
        }
    }
}
