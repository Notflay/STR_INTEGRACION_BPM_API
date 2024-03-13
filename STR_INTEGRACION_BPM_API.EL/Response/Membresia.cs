using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace STR_INTEGRACION_BPM_API.EL
{
    public class Membresia
    {
        public string carnet { get; set; }
        public int secuencia { get; set; }
        public string cardCode { get; set; }
        public string role { get; set; }
        public string tipoDocumento { get; set; }
        public string tipoDocumentoDesc { get; set; }
        public string documento { get; set; }
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public string nombre { get; set; }
        public string segundoNombre { get; set; }
        public string tercerNombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string tipoFamiliar { get; set; }
        public string tipoFamiliarDesc { get; set; }
        public string tipoPostulante { get; set; }
        public string tipoPostulanteDesc { get; set; }
        public string fechaNacimiento { get; set; }
        public string fechaFallecimiento { get; set; }
        public string sexo { get; set; }
        public string sexoDesc { get; set; }
        public string estadoCivil { get; set; }
        public string estadoCivilDesc { get; set; }
        public string tipoSangre { get; set; }
        public string condicion { get; set; }
        public string condicionDesc { get; set; }
        public string categoria { get; set; }
        public string categoriaDesc { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaInicioCarnet { get; set; }
        public string fechaFinCarnet { get; set; }
        public string fechaEmisionCarnet { get; set; }
        public string direccionFiscal { get; set; }
        public string codigoPostalFiscal { get; set; }
        public string distritoFiscal { get; set; }
        public string provinciaFiscal { get; set; }
        public string paisResidencia { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string celular1 { get; set; }
        public string celular2 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string colegioPrimaria { get; set; }
        public string colegioSecundaria { get; set; }
        public string universidad { get; set; }
        public string profesion { get; set; }
        public string especialidad { get; set; }
        public string gradoAcademico { get; set; }
        public string centroLaboral { get; set; }
        public string cargoLaboral { get; set; }
        public string telefonoLaboral { get; set; }
        public string direccionLaboral { get; set; }
        public string codigoPostalLaboral { get; set; }
        public string distritoLaboral { get; set; }
        public string carnetReferencia { get; set; }
        public List<Contacto> contacto { get; set; }
        public string comentario { get; set; }
        public string avatar { get; set; }
        public string activo { get; set; }
        public string estado { get; set; }
        public string requiereADD { get; set; }
        // Vigencia de Procesamiento
        public int? mesVigencia { get; set; }
    }

    public class MembresiaAsociado
    {
        [JsonIgnore]
        public string carnet { get; set; }
        [JsonIgnore]
        public int secuencia { get; set; }
        [JsonProperty("CardCode")]
        public string cardCode { get; set; }
        //public string role { get; set; }
        [JsonProperty("U_BPP_BPTD")]
        public string tipoDocumento { get; set; }
        [JsonProperty("FederalTaxID")]
        public string documento { get; set; }
        /*
        [JsonProperty("FederalTaxID")]
        public string ruc { get; set; }*/
        [JsonProperty("CardName")]
        public string razonSocial { get; set; }
        [JsonProperty("U_BPP_BPNO")]
        public string nombre { get; set; }
        [JsonProperty("U_BPP_BPN2")]
        public string segundoNombre { get; set; }
        [JsonProperty("U_STR_TERCERNOMBRE")]
        public string tercerNombre { get; set; }
        [JsonProperty("U_BPP_BPAP")]
        public string paterno { get; set; }
        [JsonProperty("U_BPP_BPAM")]
        public string materno { get; set; }
        [JsonProperty("U_ST_TipoFamiliar")]
        public string tipoFamiliar { get; set; }
        [JsonProperty("U_ST_TipoPostulante")]
        public string tipoPostulante { get; set; }
        [JsonProperty("U_ST_FechaNac")]
        public string fechaNacimiento { get; set; }
        [JsonProperty("U_STR_FECDEFUNCION")]
        public string fechaFallecimiento { get; set; }
        [JsonProperty("U_ST_Sexo")]
        public string sexo { get; set; }
        [JsonProperty("U_ST_EstCivil")]
        public string estadoCivil { get; set; }
        [JsonProperty("U_ST_TSangre")]
        public string tipoSangre { get; set; }
        [JsonProperty("U_ST_Condicion")]
        public string condicion { get; set; }
        [JsonProperty("U_ST_CatAsoc")]
        public string categoria { get; set; }
        [JsonProperty("U_ST_FInicioMembrecia")]
        public string fechaIngreso { get; set; }
        [JsonProperty("U_ST_FecEmiCarnet")]
        public string fechaInicioCarnet { get; set; }
        [JsonProperty("U_ST_FecExpCarnet")]
        public string fechaFinCarnet { get; set; }
        [JsonProperty("U_STR_FECSOLICITUD_EC")]
        public string fechaEmisionCarnet { get; set; }
        
        [JsonProperty("Address")] 
        public string direccionFiscal { get; set; }
        [JsonProperty("ZipCode")]
        public string codigoPostalFiscal { get; set; }
        [JsonProperty("Block")]
        public string distritoFiscal { get; set; }
        [JsonProperty("City")]
        public string provinciaFiscal { get; set; }
        [JsonProperty("Country")]
        public string paisResidencia { get; set; }
        [JsonProperty("Phone1")]
        public string telefono1 { get; set; }
        [JsonProperty("Phone2")]
        public string telefono2 { get; set; }
        [JsonProperty("Cellular")]
        public string celular1 { get; set; }
        [JsonProperty("Fax")]
        public string celular2 { get; set; }
        [JsonProperty("EmailAddress")]
        public string email1 { get; set; }
        [JsonProperty("U_STR_EMAIL2")]
        public string email2 { get; set; }
        //public string colegioPrimaria { get; set; }
        [JsonProperty("U_STR_COLEGIOSECUNDARIA")]
        public string colegioSecundaria { get; set; }
        [JsonProperty("U_STR_UNIVERSIDAD")]
        public string universidad { get; set; }
        [JsonProperty("U_ST_Profesion")]
        public string profesion { get; set; }
        [JsonProperty("U_STR_ESPECIALIDAD")]
        public string especialidad { get; set; }
        [JsonProperty("U_STR_GRADOACADEMICO")]
        public string gradoAcademico { get; set; }
        [JsonProperty("U_ST_CentroTrab")]
        public string centroLaboral { get; set; }
        [JsonProperty("U_ST_CargoTrab")]
        public string cargoLaboral { get; set; }
        [JsonProperty("U_ST_TelefTrab")]
        public string telefonoLaboral { get; set; }
        
        [JsonProperty("MailAddress")]
        public string direccionLaboral { get; set; }
        [JsonProperty("MailZipCode")]
        public string codigoPostalLaboral { get; set; }
        public string distritoLaboral { get; set; }
        public List<BPAddresses> BPAddresses { get; set; }
        [JsonProperty("U_ST_CarnetRef")]
        public string carnetReferencia { get; set; }
        [JsonProperty("ContactEmployees")]
        public List<Contacto> contacto { get; set; }
        [JsonProperty("Notes")]
        public string comentario { get; set; }
        [JsonProperty("U_ST_RutaFoto")]
        public string avatar { get; set; }
        [JsonProperty("frozenFor")]
        public string activo { get; set; }
        [JsonProperty("U_Estado")]
        public string estado { get; set; }
        [JsonProperty("U_STR_FECPRCSOLI_ADD")]
        public string requiereADD { get; set; }
    }

    public class MemebresiaFamiliar { 
    
    }
    public class BPAddresses { 
        public int RowNum { get; set; }
        public string Street { get; set; }
        public string Block { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string BPCode { get; set; }
        public string Country { get; set; }
    }
}
