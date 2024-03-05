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
using System.Xml.Linq;

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
                List<Asociado> result = hash.GetResultAsType<Asociado>(sQ_QueryManager.Generar(sQ_query.get_Asociado), dc =>
                {
                    return new Asociado()
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
                        direcciónFiscal = dc["direcciónFiscal"],
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
                        avatar = dc["avatar"],
                        activo = dc["activo"],
                        estado = dc["estado"],
                        requiereADD = Convert.ToInt32(dc["fechaProcesoSolicitud"]) == 1,
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

        public JToken ObtenerContactos(string id)
        {
            try
            {
                DataTable result = hash.GetDataTableQry(sQ_QueryManager.Generar(sQ_query.get_Contactos), id);

                JToken data = JToken.FromObject(result);

                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
