﻿using STR_INTEGRACION_BPM_API.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace STR_INTEGRACION_BPM_API.SL
{
    internal class B1SLLoginDAO
    {
        public int add(object obj) { throw new NotImplementedException(); }

        public object read(string id)
        {
            return new B1SLLogin
            {
                CompanyDB = WebConfigurationManager.AppSettings["CompanyDB"],
                UserName = WebConfigurationManager.AppSettings["UserName"],
                Password = WebConfigurationManager.AppSettings["Password"]
            };

        }

        public object readAll() { throw new NotImplementedException(); }

        public int update(object obj) { throw new NotImplementedException(); }
    }
}
