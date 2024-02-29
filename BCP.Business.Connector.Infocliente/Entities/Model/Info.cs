using Newtonsoft.Json;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    public class Info
    {
        [JsonProperty(PropertyName = "clienteId", Order = 0)]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "paterno", Order = 1)]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "materno", Order = 2)]
        public string SecondLastName { get; set; }
        [JsonProperty(PropertyName = "nombre", Order = 3)]
        public string Names { get; set; }
        [JsonProperty(PropertyName = "idc", Order = 4)]
        public string Document { get; set; }
        [JsonProperty(PropertyName = "estado", Order = 5)]
        public string State { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 6)]
        public string User { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 7)]
        public string DateModification { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 8)]
        public string DateCreation { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 9)]
        public string Channel { get; set; }
        [JsonProperty(PropertyName = "origen", Order = 10)]
        public string Origin { get; set; }
        [JsonProperty(PropertyName = "complemento", Order = 11)]
        public string DocumentComplement { get; set; }
        [JsonProperty(PropertyName = "alias", Order = 12)]
        public string Alias { get; set; }
        [JsonProperty(PropertyName = "cic", Order = 13)]
        public string Cic { get; set; }
    }
}
