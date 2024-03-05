using STR_INTEGRACION_BPM_API.SQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STR_INTEGRACION_BPM_API.EL;
using System.Data;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace STR_INTEGRACION_BPM_API.BL
{
    public class sQ_Asociado
    {
        HanaADOHelper hash = new HanaADOHelper();
        /*
        public ConsultationResponse<Asociado> ObtenerAsociado2(string filtro, string id) 
        {
            var respIncorrect = "No Hay Proveedores";

            try
            {
                List<Asociado> list = hash.GetResultAsType(sQ_QueryManager.Generar(sQ_query.get_Asociado), dc =>
                {
                    return new Asociado()
                    {
                        nombre = dc["U_BPP_BPNO"],
                        segundoNombre = dc["U_BPP_BPN2"],   
                    };
                }, id).ToList();

                return Global.ReturnOk(list, respIncorrect);
            }
            catch (Exception ex)
            {
                return Global.ReturnError<Asociado>(ex);
            }
        }*/
        public ConsultationResponse ObtenerAsociado(string filtro, string id)
        {
            try
            {
                DataTable result = hash.GetDataTableQry(sQ_QueryManager.Generar(sQ_query.get_Asociado), filtro, id);

                JToken data = JToken.FromObject(result);

                return Global.ReturnOk(data);
            }
            catch (Exception ex)
            {
                return Global.ReturnError(ex);
            }
        }
    }
}
