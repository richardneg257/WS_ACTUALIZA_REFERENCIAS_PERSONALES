using Newtonsoft.Json;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    public class InfoPersonal
    {
        [JsonProperty(PropertyName = "datoPersonalId", Order = 0)]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "clienteId", Order = 1)]
        public long ClientId { get; set; }
        [JsonProperty(PropertyName = "fechaNac", Order = 2)]
        public string BirthDate { get; set; }
        [JsonProperty(PropertyName = "sexoId", Order = 3)]
        public int GenderId { get; set; }
        [JsonProperty(PropertyName = "sexoDes", Order = 4)]
        public string Gender { get; set; }
        [JsonProperty(PropertyName = "estadoCivilId", Order = 5)]
        public int CivilStateId { get; set; }
        [JsonProperty(PropertyName = "estadoCivilDes", Order = 6)]
        public string CivilState { get; set; }
        [JsonProperty(PropertyName = "nacionalidadId", Order = 7)]
        public int NationalityId { get; set; }
        [JsonProperty(PropertyName = "nacionalidadDes", Order = 8)]
        public string Nationality { get; set; }
        [JsonProperty(PropertyName = "profesionId", Order = 9)]
        public int ProfessionId { get; set; }
        [JsonProperty(PropertyName = "profesionDes", Order = 10)]
        public string Profession { get; set; }
        [JsonProperty(PropertyName = "gradoInstruccionId", Order = 11)]
        public int GradeInstructionId { get; set; }
        [JsonProperty(PropertyName = "gradoInstruccionDes", Order = 12)]
        public string GradeInstruction { get; set; }
        [JsonProperty(PropertyName = "codTelefonoId", Order = 13)]
        public int CodePhoneId { get; set; }
        [JsonProperty(PropertyName = "codTelefonoDes", Order = 14)]
        public string CodePhone { get; set; }
        [JsonProperty(PropertyName = "telefono", Order = 15)]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "anexoTelefono", Order = 16)]
        public string AnnexedPhone { get; set; }
        [JsonProperty(PropertyName = "codCelularId", Order = 17)]
        public int CodeCellphoneId { get; set; }
        [JsonProperty(PropertyName = "codCelularDes", Order = 18)]
        public string CodeCellphone { get; set; }
        [JsonProperty(PropertyName = "celular", Order = 19)]
        public string Cellphone { get; set; }
        [JsonProperty(PropertyName = "correoElectronico", Order = 20)]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "estado", Order = 21)]
        public string State { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 22)]
        public string User { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 23)]
        public string ModificationDate { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 24)]
        public string CreationDate { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 25)]
        public string Channel { get; set; }
        [JsonProperty(PropertyName = "residente", Order = 26)]
        public bool Residente { get; set; }
        [JsonProperty(PropertyName = "conyIdc", Order = 27)]
        public string ConyIdc { get; set; }
        [JsonProperty(PropertyName = "conyNombre", Order = 28)]
        public string ConyNombre { get; set; }
        [JsonProperty(PropertyName = "conyPaterno", Order = 29)]
        public string ConyPaterno { get; set; }
        [JsonProperty(PropertyName = "conyMaterno", Order = 30)]
        public string ConyMaterno { get; set; }
        [JsonProperty(PropertyName = "conyNacionalidadId", Order = 31)]
        public int conyNacionalidadId { get; set; }
        [JsonProperty(PropertyName = "conyNacionalidadDes", Order = 32)]
        public string conyNacionalidadDes { get; set; }
        [JsonProperty(PropertyName = "conyResidente", Order = 33)]
        public bool conyResidente { get; set; }
        [JsonProperty(PropertyName = "banco1Id", Order = 34)]
        public int Banco1Id { get; set; }
        [JsonProperty(PropertyName = "banco1Des", Order = 35)]
        public string Banco1Des { get; set; }
        [JsonProperty(PropertyName = "producto1Id", Order = 36)]
        public int Producto1Id { get; set; }
        [JsonProperty(PropertyName = "producto1Des", Order = 37)]
        public string Producto1Des { get; set; }
        [JsonProperty(PropertyName = "banco2Id", Order = 38)]
        public int Banco2Id { get; set; }
        [JsonProperty(PropertyName = "banco2Des", Order = 39)]
        public string Banco2Des { get; set; }
        [JsonProperty(PropertyName = "producto2Id", Order = 40)]
        public int Producto2Id { get; set; }
        [JsonProperty(PropertyName = "producto2Des", Order = 41)]
        public string Producto2Des { get; set; }
        [JsonProperty(PropertyName = "banco3Id", Order = 42)]
        public int Banco3Id { get; set; }
        [JsonProperty(PropertyName = "producto3Id", Order = 43)]
        public int Producto3Id { get; set; }
        [JsonProperty(PropertyName = "producto3Des", Order = 44)]
        public string Producto3Des { get; set; }
        [JsonProperty(PropertyName = "refper1Nombre", Order = 45)]
        public string Refper1Nombre { get; set; }
        [JsonProperty(PropertyName = "refper1Direccion", Order = 46)]
        public string Refper1Direccion { get; set; }
        [JsonProperty(PropertyName = "refper1Telefono", Order = 47)]
        public string Refper1Telefono { get; set; }
        [JsonProperty(PropertyName = "refper2Nombre", Order = 48)]
        public string Refper2Nombre { get; set; }
        [JsonProperty(PropertyName = "refper2Direccion", Order = 49)]
        public string Refper2Direccion { get; set; }
        [JsonProperty(PropertyName = "refper2Telefono", Order = 50)]
        public string Refper2Telefono { get; set; }
        [JsonProperty(PropertyName = "refper3Nombre", Order = 51)]
        public string Refper3Nombre { get; set; }
        [JsonProperty(PropertyName = "refper3Direccion", Order = 52)]
        public string Refper3Direccion { get; set; }
        [JsonProperty(PropertyName = "refper3Telefono", Order = 53)]
        public string Refper3Telefono { get; set; }
        [JsonProperty(PropertyName = "refcom1Nombre", Order = 54)]
        public string Refcom1Nombre { get; set; }
        [JsonProperty(PropertyName = "refcom1Direccion", Order = 55)]
        public string Refcom1Direccion { get; set; }
        [JsonProperty(PropertyName = "refcom1Telefono", Order = 56)]
        public string Refcom1Telefono { get; set; }
        [JsonProperty(PropertyName = "refcom2Nombre", Order = 57)]
        public string Refcom2Nombre { get; set; }
        [JsonProperty(PropertyName = "refcom2Direccion", Order = 58)]
        public string Refcom2Direccion { get; set; }
        [JsonProperty(PropertyName = "refcom2Telefono", Order = 59)]
        public string Refcom2Telefono { get; set; }
        [JsonProperty(PropertyName = "refcom3Nombre", Order = 60)]
        public string Refcom3Nombre { get; set; }
        [JsonProperty(PropertyName = "refcom3Direccion", Order = 61)]
        public string Refcom3Direccion { get; set; }
        [JsonProperty(PropertyName = "refcom3Telefono", Order = 62)]
        public string Refcom3Telefono { get; set; }
        [JsonProperty(PropertyName = "conyComplementoIdc", Order = 63)]
        public string ConyComplementoIdc { get; set; }
        [JsonProperty(PropertyName = "segmentoSocialId", Order = 64)]
        public int SegmentoSocialId { get; set; }
        [JsonProperty(PropertyName = "segmentoSocialDes", Order = 65)]
        public string segmentoSocialDes { get; set; }
        [JsonProperty(PropertyName = "tipoCuentaId", Order = 66)]
        public int TipoCuentaId { get; set; }
        [JsonProperty(PropertyName = "tipoCuentaDes", Order = 67)]
        public string TipoCuentaDes { get; set; }
        [JsonProperty(PropertyName = "tipoClienteId", Order = 68)]
        public int TipoClienteId { get; set; }
        [JsonProperty(PropertyName = "tipoClienteDes", Order = 69)]
        public string TipoClienteDes { get; set; }
        [JsonProperty(PropertyName = "tipoBancaId", Order = 70)]
        public int TipoBancaId { get; set; }
        [JsonProperty(PropertyName = "tipoBancaDes", Order = 71)]
        public string TipoBancaDes { get; set; }
        [JsonProperty(PropertyName = "correspondencia", Order = 72)]
        public string Correspondencia { get; set; }
        [JsonProperty(PropertyName = "magnitudEmpresaId", Order = 73)]
        public int MagnitudEmpresaId { get; set; }
        [JsonProperty(PropertyName = "magnitudEmpresaDes", Order = 74)]
        public string MagnitudEmpresaDes { get; set; }
        [JsonProperty(PropertyName = "nombreComercial", Order = 75)]
        public string NombreComercial { get; set; }
        [JsonProperty(PropertyName = "codigoSbs", Order = 76)]
        public string CodigoSbs { get; set; }
        [JsonProperty(PropertyName = "funcionarioNegocios", Order = 77)]
        public string FuncionarioNegocios { get; set; }
        [JsonProperty(PropertyName = "residenciaPais", Order = 78)]
        public int ResidenciaPais { get; set; }
        [JsonProperty(PropertyName = "residenciaPaisDes", Order = 79)]
        public string ResidenciaPaisDes { get; set; }
        [JsonProperty(PropertyName = "residenciaConyPais", Order = 80)]
        public string ResidenciaConyPais { get; set; }
        [JsonProperty(PropertyName = "residenciaConyPaisDes", Order = 81)]
        public string ResidenciaConyPaisDes { get; set; }
        [JsonProperty(PropertyName = "banco1Otro", Order = 82)]
        public string Banco1Otro { get; set; }
        [JsonProperty(PropertyName = "banco2Otro", Order = 83)]
        public string Banco2Otro { get; set; }
        [JsonProperty(PropertyName = "banco3Otro", Order = 84)]
        public string Banco3Otro { get; set; }
        [JsonProperty(PropertyName = "fax", Order = 85)]
        public string Fax { get; set; }
        [JsonProperty(PropertyName = "limitacion", Order = 86)]
        public bool Limitacion { get; set; }
        [JsonProperty(PropertyName = "tipoLimitacion", Order = 87)]
        public int tipoLimitacion { get; set; }
        [JsonProperty(PropertyName = "desmaterializacion", Order = 88)]
        public string desmaterializacion { get; set; }
        [JsonProperty(PropertyName = "direccionDesmaterializacion", Order = 89)]
        public int DireccionDesmaterializacion { get; set; }
        [JsonProperty(PropertyName = "conyFechaNac", Order = 90)]
        public string ConyFechaNac { get; set; }
        [JsonProperty(PropertyName = "conyProfesionId", Order = 91)]
        public int ConyProfesionId { get; set; }
        [JsonProperty(PropertyName = "conyProfesionDes", Order = 92)]
        public string ConyProfesionDes { get; set; }
        [JsonProperty(PropertyName = "conySituacionLabId", Order = 93)]
        public int ConySituacionLabId { get; set; }
        [JsonProperty(PropertyName = "conySituacionLabDes", Order = 94)]
        public string ConySituacionLabDes { get; set; }
        [JsonProperty(PropertyName = "conyNombreEmp", Order = 95)]
        public string ConyNombreEmp { get; set; }
        [JsonProperty(PropertyName = "conyCargoId", Order = 96)]
        public int ConyCargoId { get; set; }
        [JsonProperty(PropertyName = "conyCargoDes", Order = 97)]
        public string ConyCargoDes { get; set; }
        [JsonProperty(PropertyName = "conyIngreso", Order = 98)]
        public decimal ConyIngreso { get; set; }
        [JsonProperty(PropertyName = "conyFechaIng", Order = 99)]
        public string ConyFechaIng { get; set; }
        [JsonProperty(PropertyName = "conyTelefono", Order = 100)]
        public string ConyTelefono { get; set; }
        [JsonProperty(PropertyName = "conyOtrosIngresos", Order = 101)]
        public decimal ConyOtrosIngresos { get; set; }
        [JsonProperty(PropertyName = "nroNitPersonal", Order = 102)]
        public string NroNitPersonal { get; set; }
        [JsonProperty(PropertyName = "razonSocialPersonal", Order = 103)]
        public string RazonSocialPersonal { get; set; }
        [JsonProperty(PropertyName = "estadoNit", Order = 104)]
        public int EstadoNit { get; set; }
        [JsonProperty(PropertyName = "estadoNitDes", Order = 105)]
        public string EstadoNitDes { get; set; }
        [JsonProperty(PropertyName = "lugarNacimiento", Order = 106)]
        public int LugarNacimiento { get; set; }
        [JsonProperty(PropertyName = "lugarNacimientoDes", Order = 107)]
        public string LugarNacimientoDes { get; set; }
    }
}
