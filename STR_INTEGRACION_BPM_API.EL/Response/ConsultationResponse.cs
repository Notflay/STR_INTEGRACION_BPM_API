using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STR_INTEGRACION_BPM_API.EL
{
    public class ConsultationResponse
    {
        public string CodRespuesta { get; set; }
        public string DescRespuesta { get; set; }
        public JToken Result { get; set; }
        //public string Token { get; set; }
    }
}
