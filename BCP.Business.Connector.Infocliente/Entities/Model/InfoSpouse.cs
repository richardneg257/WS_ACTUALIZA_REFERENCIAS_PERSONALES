using Newtonsoft.Json;
using System;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    public class InfoSpouse
    {
        [JsonProperty(PropertyName = "datoConyugeId", Order = 0)]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "clienteId", Order = 1)]
        public long ClientId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaId", Order = 2)]
        public int SubCategoryId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaDes", Order = 3)]
        public string SubCategory { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralUnoId", Order = 4)]
        public int EmploymentSituationId { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralUnoDes", Order = 5)]
        public string EmploymentSituation { get; set; }
        [JsonProperty(PropertyName = "actividadUnoId", Order = 6)]
        public int EconomicActivityId { get; set; }
        [JsonProperty(PropertyName = "actividadUnoDes", Order = 7)]
        public string EconomicActivity { get; set; }
        [JsonProperty(PropertyName = "ciiuUnoId", Order = 8)]
        public Int32 CiiuId { get; set; }
        [JsonProperty(PropertyName = "ciiuUnoDes", Order = 9)]
        public string Ciiu { get; set; }
        [JsonProperty(PropertyName = "estado", Order = 10)]
        public string State { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 11)]
        public string User { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 12)]
        public string ModificationDate { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 13)]
        public string CreationDate { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 14)]
        public string Channel { get; set; }
    }
}
