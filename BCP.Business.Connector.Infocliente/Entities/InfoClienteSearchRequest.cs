using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace BCP.Business.Connector.Infocliente.Entities
{
    [DataContract]
    public class InfoClienteSearchRequest
    {
        [JsonProperty(PropertyName = "canal", Order = 0)]
        public string Channel { get; set; }
        [JsonProperty(PropertyName = "operacionOrigen", Order = 1)]
        public string Operation { get; set; }
        [JsonProperty(PropertyName = "password", Order = 2)]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 3)]
        public string User { get; set; }
        [JsonProperty(PropertyName = "complemento", Order = 4)]
        public string DocumentComplement { get; set; }
        [JsonProperty(PropertyName = "extensionIdc", Order = 5)]
        public string DocumentExtension { get; set; }
        [JsonProperty(PropertyName = "idc", Order = 6)]
        public string DocumentNumber { get; set; }
        [JsonProperty(PropertyName = "tipoIdc", Order = 7)]
        public string DocumentType { get; set; }
    }
}
