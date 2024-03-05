using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STR_INTEGRACION_BPM_API.EL
{
    public class Asociado
    {
        public string carnet { get; set; }
        public int secuencia { get; set; }
        public string cardCode { get; set; }
        public string role { get; set; }
        public string tipoDocumento { get; set; }
        public string documento { get; set; }
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public string nombre { get; set; }
        public string segundoNombre { get; set; }
        public string tercerNombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string tipoFamiliar { get; set; }
        public string tipoPostulante { get; set; }
        public string fechaNacimiento { get; set; }
        public string fechaFallecimiento { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }
        public string tipoSangre { get; set; }
        public string condicion { get; set; }
        public string categoria { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaInicioCarnet { get; set; }
        public string fechaFinCarnet { get; set; }
        public string fechaEmisionCarnet { get; set; }
        public string direcciónFiscal { get; set; }
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
        public bool requiereADD { get; set; }
    }
}
