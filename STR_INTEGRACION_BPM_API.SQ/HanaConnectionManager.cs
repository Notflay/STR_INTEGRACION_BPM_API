using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sap.Data.Hana;
using System.Configuration;

namespace STR_INTEGRACION_BPM_API.SQ
{
    public class HanaConnectionManager
    {
        private HanaConnection hanaConnection = null;

        public HanaConnection GetConnection()
        {
            hanaConnection = new HanaConnection(ConfigurationManager.ConnectionStrings["hanaRamo"].ConnectionString);
            return hanaConnection;
        }

        public void OpenConnection()
        {
            hanaConnection.Open();
        }

        public void CloseConnection()
        {
            hanaConnection.Close();
            hanaConnection = null;
        }
    }
}
