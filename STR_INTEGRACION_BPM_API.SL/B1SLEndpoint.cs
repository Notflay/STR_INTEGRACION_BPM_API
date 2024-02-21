using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STR_INTEGRACION_BPM_API.SL
{
    public class B1SLEndpoint : B1SLTransactions
    {
        public override void Get()
        {
            throw new NotImplementedException();
        }

        public dynamic Get<T>(string resource)
        {
            var rslt = default(RestSharp.IRestResponse);
            rslt = sLInteract.httpGET(getBasePath() + resource, SessionId);

            var objeto = System.Text.Json.JsonSerializer.Deserialize<T>(rslt.Content);

            return objeto;
        }

        public override U POST<U>(string strJSON)
        {
            throw new NotImplementedException();
        }

    }
}
