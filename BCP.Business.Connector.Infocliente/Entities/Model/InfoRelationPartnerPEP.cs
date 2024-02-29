using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    [DataContract]
    public class InfoRelationPartnerPEP
    {
        [JsonProperty(PropertyName = "empresaPepId", Order = 0)]
        public int empresaPepId { get; set; }
        [JsonProperty(PropertyName = "clienteId", Order = 1)]
        public int clienteId { get; set; }
        [JsonProperty(PropertyName = "tipoPepId", Order = 2)]
        public int tipoPepId { get; set; }
        [JsonProperty(PropertyName = "tipoPepDes", Order = 3)]
        public string tipoPepDes { get; set; }
        [JsonProperty(PropertyName = "idcParSoc", Order = 4)]
        public string idcParSoc { get; set; }
        [JsonProperty(PropertyName = "extensionIdcParSoc", Order = 5)]
        public string extensionIdcParSoc { get; set; }
        [JsonProperty(PropertyName = "tipoIdcParSoc", Order = 6)]
        public string tipoIdcParSoc { get; set; }
        [JsonProperty(PropertyName = "complementoParSoc", Order = 7)]
        public string complementoParSoc { get; set; }
        [JsonProperty(PropertyName = "apPaternoParSoc", Order = 8)]
        public string apPaternoParSoc { get; set; }
        [JsonProperty(PropertyName = "apMaternoParSoc", Order = 9)]
        public string apMaternoParSoc { get; set; }
        [JsonProperty(PropertyName = "nombresParSoc", Order = 10)]
        public string nombresParSoc { get; set; }
        [JsonProperty(PropertyName = "nacionalidadParSocId", Order = 11)]
        public int nacionalidadParSocId { get; set; }
        [JsonProperty(PropertyName = "nacionalidadParSocDes", Order = 12)]
        public string nacionalidadParSocDes { get; set; }
        [JsonProperty(PropertyName = "parentescoParSocId", Order = 13)]
        public int parentescoParSocId { get; set; }
        [JsonProperty(PropertyName = "parentescoParSocDes", Order = 14)]
        public string parentescoParSocDes { get; set; }
        [JsonProperty(PropertyName = "tipoVinculoParSocId", Order = 15)]
        public int tipoVinculoParSocId { get; set; }
        [JsonProperty(PropertyName = "tipoVinculoParSocDes", Order = 16)]
        public string tipoVinculoParSocDes { get; set; }
        [JsonProperty(PropertyName = "nomInstiOrganiParSoc", Order = 17)]
        public string nomInstiOrganiParSoc { get; set; }
        [JsonProperty(PropertyName = "cargoOficioParSoc", Order = 18)]
        public string cargoOficioParSoc { get; set; }
        [JsonProperty(PropertyName = "periodoParSoc", Order = 19)]
        public string periodoParSoc { get; set; }
        [JsonProperty(PropertyName = "paisCargoParSocId", Order = 20)]
        public int paisCargoParSocId { get; set; }
        [JsonProperty(PropertyName = "paisCargoParSocDes", Order = 21)]
        public string paisCargoParSocDes { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 22)]
        public string usuario { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 23)]
        public string fechaUltimaModificacion { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 24)]
        public string fechaCreacion { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 25)]
        public string canal { get; set; }
    }
}
