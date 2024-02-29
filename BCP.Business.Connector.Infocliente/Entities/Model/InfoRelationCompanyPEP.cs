using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    [DataContract]
    public class InfoRelationCompanyPEP
    {
        [JsonProperty(PropertyName = "empresaPepId", Order = 0)]
        public int empresaPepId { get; set; }
        [JsonProperty(PropertyName = "clienteId", Order = 1)]
        public int clienteId { get; set; }
        [JsonProperty(PropertyName = "tipoPepId", Order = 2)]
        public int tipoPepId { get; set; }
        [JsonProperty(PropertyName = "tipoPepDes", Order = 3)]
        public string tipoPepDes { get; set; }
        [JsonProperty(PropertyName = "nombreEmpresa", Order = 4)]
        public string nombreEmpresa { get; set; }
        [JsonProperty(PropertyName = "nit", Order = 5)]
        public string nit { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 6)]
        public string usuario { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 7)]
        public string fechaUltimaModificacion { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 8)]
        public string fechaCreacion { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 9)]
        public string canal { get; set; }
    }
}
