using Newtonsoft.Json;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    public class InfoError
    {
        [JsonProperty(PropertyName = "nivel", Order = 2)]
        public string Level { get; set; }
        [JsonProperty(PropertyName = "error", Order = 3)]
        public string Message { get; set; }
    }
}
