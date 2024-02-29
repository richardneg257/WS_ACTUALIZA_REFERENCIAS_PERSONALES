using Newtonsoft.Json;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    public class InfoOccupational
    {
        [JsonProperty(PropertyName = "datoLaboralId", Order = 0)]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "clienteId", Order = 1)]
        public long ClientId { get; set; }
        [JsonProperty(PropertyName = "situacionLaboralId", Order = 2)]
        public int EmploymentSituationId { get; set; }
        [JsonProperty(PropertyName = "situacionLaboralDes", Order = 3)]
        public string EmploymentSituation { get; set; }
        [JsonProperty(PropertyName = "nombreEmpresa", Order = 4)]
        public string CompanyName { get; set; }
        [JsonProperty(PropertyName = "nit", Order = 5)]
        public string Nit { get; set; }
        [JsonProperty(PropertyName = "cargoId", Order = 6)]
        public int PositionId { get; set; }
        [JsonProperty(PropertyName = "cargoDes", Order = 7)]
        public string Position { get; set; }
        [JsonProperty(PropertyName = "salario", Order = 8)]
        public decimal? Salary { get; set; }
        [JsonProperty(PropertyName = "codTelefonoId", Order = 9)]
        public int CodePhoneId { get; set; }
        [JsonProperty(PropertyName = "codTelefonoDes", Order = 10)]
        public string CodePhone { get; set; }
        [JsonProperty(PropertyName = "telefono", Order = 11)]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "anexoTelefono", Order = 12)]
        public string AnnexedPhone { get; set; }
        [JsonProperty(PropertyName = "estado", Order = 13)]
        public string State { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 14)]
        public string User { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 15)]
        public string ModificationDate { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 16)]
        public string CreationDate { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 17)]
        public string Channel { get; set; }
        [JsonProperty(PropertyName = "subcategoriaId", Order = 18)]
        public int SubCategoryId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaDes", Order = 19)]
        public string SubCategory { get; set; }
        [JsonProperty(PropertyName = "actividadId", Order = 20)]
        public int EconomicActivityId { get; set; }
        [JsonProperty(PropertyName = "actividadDes", Order = 21)]
        public string EconomicActivity { get; set; }
        [JsonProperty(PropertyName = "ciiuId", Order = 22)]
        public int CiiuId { get; set; }
        [JsonProperty(PropertyName = "ciiuDes", Order = 23)]
        public string Ciiu { get; set; }
        [JsonProperty(PropertyName = "celular", Order = 24)]
        public string Cellphone { get; set; }
        [JsonProperty(PropertyName = "correoElectronico", Order = 25)]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "cargoPublico", Order = 26)]
        public bool IsPositionPublic { get; set; }
        [JsonProperty(PropertyName = "cargo", Order = 27)]
        public string PositionName { get; set; }
        [JsonProperty(PropertyName = "periodo", Order = 28)]
        public string Period { get; set; }
        [JsonProperty(PropertyName = "negocioPropio", Order = 29)]
        public bool OwnBusiness { get; set; }
        [JsonProperty(PropertyName = "fechaLugarTrabajo", Order = 30)]
        public string CompanyDateAdmission { get; set; }
        [JsonProperty(PropertyName = "funcionarioPublico", Order = 31)]
        public bool IsPublicEmployee { get; set; }
        [JsonProperty(PropertyName = "parientePep", Order = 32)]
        public bool IsrelativePep { get; set; }
        [JsonProperty(PropertyName = "asociadoPep", Order = 33)]
        public bool IsAssociatedPep { get; set; }
        [JsonProperty(PropertyName = "institucionPublica", Order = 34)]
        public string PublicInstitution { get; set; }
        [JsonProperty(PropertyName = "paisCargoId", Order = 35)]
        public int CountryPositionId { get; set; }
        [JsonProperty(PropertyName = "paisCargoDes", Order = 36)]
        public string CountryPosition { get; set; }
    }
}
