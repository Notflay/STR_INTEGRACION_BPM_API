using STR_INTEGRACION_BPM_API.SQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STR_INTEGRACION_BPM_API.EL;
using STR_INTEGRACION_BPM_API.SL;
using System.Data;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Text.Json;

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
        public ConsultationResponse ObtenerAsociado2(string filtro, string id)
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

        public ConsultationResponse ObtenerAsociado(string id)
        {
            try
            {
                List<Membresia> result = hash.GetResultAsType<Membresia>(sQ_QueryManager.Generar(sQ_query.get_Asociado), dc =>
                {
                    return new Membresia()
                    {
                        carnet = dc["carnet"],
                        secuencia = Convert.ToInt32(dc["secuencia"]),
                        cardCode = dc["cardCode"],
                        role = dc["role"],
                        tipoDocumento = dc["tipoDocumento"],
                        documento = dc["documento"],
                        ruc = dc["ruc"],
                        razonSocial = dc["razonSocial"],
                        nombre = dc["nombre"],
                        segundoNombre = dc["segundoNombre"],
                        tercerNombre = dc["tercerNombre"],
                        paterno = dc["paterno"],
                        materno = dc["materno"],
                        tipoFamiliar = dc["tipoFamiliar"],
                        tipoPostulante = dc["tipoPostulante"],
                        fechaNacimiento = dc["fechaNacimiento"],
                        fechaFallecimiento = dc["fechaFallecimiento"],
                        sexo = dc["sexo"],
                        estadoCivil = dc["estadoCivil"],
                        tipoSangre = dc["tipoSangre"],
                        condicion = dc["condicion"],
                        categoria = dc["categoria"],
                        fechaIngreso = dc["fechaIngreso"],
                        fechaInicioCarnet = dc["fechaInicioCarnet"],
                        fechaFinCarnet = dc["fechaFinCarnet"],
                        fechaEmisionCarnet = dc["fechaEmisionCarnet"],
                        direccionFiscal = dc["direcciónFiscal"],
                        codigoPostalFiscal = dc["codigoPostalFiscal"],
                        distritoFiscal = dc["distritoFiscal"],
                        provinciaFiscal = dc["provinciaFiscal"],
                        paisResidencia = dc["paisResidencia"],
                        telefono1 = dc["telefono1"],
                        telefono2 = dc["telefono2"],
                        celular1 = dc["celular1"],
                        celular2 = dc["celular2"],
                        email1 = dc["email1"],
                        email2 = dc["email2"],
                        colegioPrimaria = dc["colegioPrimaria"],
                        colegioSecundaria = dc["colegioSecundaria"],
                        universidad = dc["universidad"],
                        profesion = dc["profesion"],
                        especialidad = dc["especialidad"],
                        gradoAcademico = dc["gradoAcademico"],
                        centroLaboral = dc["centroLaboral"],
                        cargoLaboral = dc["cargoLaboral"],
                        telefonoLaboral = dc["telefonoLaboral"],
                        direccionLaboral = dc["direccionLaboral"],
                        codigoPostalLaboral = dc["codigoPostalLaboral"],
                        distritoLaboral = dc["distritoLaboral"],
                        carnetReferencia = dc["carnetReferencia"],
                        comentario = dc["comentario"],
                        avatar = dc["avatar"] != null ? $@"{dc["avatar"]}" : null,
                        activo = dc["activo"],
                        estado = dc["estado"],
                        requiereADD = dc["fechaProcesoSolicitud"],
                        contacto = dc["cardCode"] != null ? ObtenerContactos(dc["cardCode"]) : null
                    };
                }, id).ToList();

                JToken data = JToken.FromObject(result);

                return Global.ReturnOk(data);
            }
            catch (Exception ex)
            {
                return Global.ReturnError(ex);
            }
        }

        public List<Contacto> ObtenerContactos(string id)
        {
            List<Contacto> list = new List<Contacto>();

            try
            {
               list = hash.GetResultAsType<Contacto>(sQ_QueryManager.Generar(sQ_query.get_Contactos), dc =>
               {
                   return new Contacto
                   {
                       CntctCode = Convert.ToInt32(dc["CntctCode"]),
                       CardCode = dc["CardCode"],
                       Name = dc["Name"],
                       Position = dc["Position"],
                       Address = dc["Address"],
                       Tel1 = dc["Tel1"],
                       Tel2 = dc["Tel2"],
                       Cellolar = dc["Cellolar"],
                       Fax = dc["Fax"],
                       E_MailL = dc["E_MailL"],
                       Pager = dc["Pager"],
                       Notes1 = dc["Notes1"],
                       Notes2 = dc["Notes2"],
                       DataSource = dc["DataSource"],
                       UserSign = Convert.ToInt32(dc["UserSign"]),
                       Password = dc["Password"],
                       LogInstanc = Convert.ToInt32(dc["LogInstanc"]),
                       ObjType = dc["ObjType"],
                       BirthPlace = dc["BirthPlace"],
                       BirthDate = dc["BirthDate"],
                       Gender = dc["Gender"],
                       Profession = dc["Profession"],
                       updateDate = dc["updateDate"],
                       updateTime = dc["updateTime"],
                       Title = dc["Title"],
                       BirthCity = dc["BirthCity"],
                       Active = dc["Active"],
                       FirstName = dc["FirstName"],
                       MiddleName = dc["MiddleName"],
                       LastName = dc["LastName"],
                       BirthState = dc["BirthState"],
                       ResidCity = dc["ResidCity"],
                       ResidCntry = dc["ResidCntry"],
                       ResidState = dc["ResidState"],
                       NFeRcpn = dc["NFeRcpn"],
                       EmlGrpCode = dc["EmlGrpCode"],
                       BlockComm = dc["BlockComm"],
                       FiscalCode = dc["FiscalCode"],
                       CtyPrvsYr = dc["CtyPrvsYr"],
                       SttPrvsYr = dc["SttPrvsYr"],
                       CtyCdPrvsY = dc["CtyCdPrvsY"],
                       CtyCurYr = dc["CtyCurYr"],
                       SttCurYr = dc["SttCurYr"],
                       CtyCdCurYr = dc["CtyCdCurYr"],
                       NotResdSch = dc["NotResdSch"],
                       CtyFsnCode = dc["CtyFsnCode"],
                       NaturalPer = dc["NaturalPer"],
                       DPPStatus = dc["DPPStatus"],
                       CreateDate = dc["CreateDate"],
                       CreateTS = Convert.ToInt32(dc["CreateTS"]),
                       U_AvalSN = dc["U_AvalSN"],
                   };
               },id).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ConsultationResponse ActualizarMembresia(List<Membresia> membresias) {
            try
            {
                string json = System.Text.Json.JsonSerializer.Serialize(membresias);
                string s = "";
                List<MembresiaUpdate> _membresias = System.Text.Json.JsonSerializer.Deserialize<List<MembresiaUpdate>>(json);

                // Divide entre Asociados Y Familiares  ---- 
                for (int i = 0; i < _membresias.Count; i++)
                {
                    if (_membresias[i].secuencia == 0)
                    {
                        ActualizarAsociado(_membresias[i]);
                    }
                    else {
                        ActualizarFamiliar(_membresias[i]);
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ActualizarAsociado(MembresiaUpdate asociado) 
        {
            try
            {
                BPAddresses adress1 = null;
                BPAddresses adress2 = null;
                // Obtiene las direcciones -- Obtiene Rownum de los que vaa a actualizar
                asociado.BPAddresses = new List<BPAddresses>();
                /*
                if (asociado.direccionFiscal != null | asociado.codigoPostalFiscal != null | asociado.distritoFiscal != null | asociado.provinciaFiscal != null)
                {
                    // Obtiene RowNuw de dirección
                    string rowNum = hash.GetValueSql(sQ_QueryManager.Generar(sQ_query.get_LineDirec), asociado.cardCode, "FISCAL");
                    adress1 = new BPAddresses()
                    {
                        RowNum = Convert.ToInt32(rowNum),
                        Block = asociado.distritoFiscal,
                        BPCode = asociado.cardCode,
                        City = asociado.provinciaFiscal,
                        Street = asociado.direccionFiscal,
                        ZipCode = asociado.codigoPostalFiscal,
                        Country = asociado.paisResidencia,
                    };

                    asociado.direccionFiscal = null;
                    asociado.provinciaFiscal = null;
                    asociado.codigoPostalFiscal = null;
                    asociado.paisResidencia = null;
                    asociado.distritoFiscal = null;

                    asociado.BPAddresses.Add(adress1);
                }*/
                if (asociado.direccionLaboral != null | asociado.distritoLaboral != null | asociado.codigoPostalLaboral != null)
                {
                    string rowNum = hash.GetValueSql(sQ_QueryManager.Generar(sQ_query.get_LineDirec), asociado.cardCode, "LABORAL");
                    adress2 = new BPAddresses()
                    {
                        RowNum = Convert.ToInt32(rowNum),
                        Block = asociado.distritoLaboral,
                        BPCode = asociado.cardCode,
                        //City = asociado.provinciaFiscal,
                        Street = asociado.direccionLaboral,
                        ZipCode = asociado.codigoPostalLaboral,
                    };

                    asociado.direccionLaboral = null;
                    asociado.distritoLaboral = null;
                    asociado.codigoPostalLaboral = null;

                    asociado.BPAddresses.Add(adress2);
                }

                // Una vez obtiene toda las direcciones hace el envio por Service Layer la creación. 
                var jsonSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Newtonsoft.Json.Formatting.Indented
                };

                //string json = System.Text.Json.JsonSerializer.Serialize(asociado);
                string json = JsonConvert.SerializeObject(asociado, jsonSettings);

                B1SLEndpoint b1SLEndpoint = new B1SLEndpoint();
                b1SLEndpoint.Patch($"/BusinessPartners('{asociado.cardCode}')", json);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ActualizarFamiliar(MembresiaUpdate familiar)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }        
        }
    }
}
