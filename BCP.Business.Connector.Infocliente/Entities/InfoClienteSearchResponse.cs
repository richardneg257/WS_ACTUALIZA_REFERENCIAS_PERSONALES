using BCP.Business.Connector.Infocliente.Entities.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BCP.Business.Connector.Infocliente.Entities
{
    public class InfoClienteSearchResponse
    {
        [JsonProperty(PropertyName = "exito", Order = 0)]
        public bool Success { get; set; }
        [JsonProperty(PropertyName = "codigo", Order = 1)]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "operacion", Order = 2)]
        public string Operation { get; set; }
        [JsonProperty(PropertyName = "mensaje", Order = 3)]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "InfoCliente", Order = 4)]
        public Info Info { get; set; }
        [JsonProperty(PropertyName = "InfoDatoLaboral", Order = 5)]
        public InfoOccupational InfoOccupational { get; set; }
        [JsonProperty(PropertyName = "InfoDireccion", Order = 6)]
        public List<InfoAddress> InfoAddress { get; set; }
        [JsonProperty(PropertyName = "InfoDatoPersonal", Order = 7)]
        public InfoPersonal InfoPersonal { get; set; }
        [JsonProperty(PropertyName = "InfoDatoConyuge", Order = 8)]
        public InfoSpouse InfoSpouse { get; set; }
        [JsonProperty(PropertyName = "InfoDatoLaboralExtendido", Order = 9)]
        public InfoOccupationalExtended InfoOccupationalExtended { get; set; }
        [JsonProperty(PropertyName = "InfoRelacionEmpresaPEP", Order = 10)]
        public List<InfoRelationCompanyPEP> InfoRelationCompanyPEP { get; set; }
        [JsonProperty(PropertyName = "InfoRelacionSocioPEP", Order = 11)]
        public List<InfoRelationPartnerPEP> InfoRelationPartnerPEP { get; set; }
        [JsonProperty(PropertyName = "error", Order = 12)]
        public List<InfoError> Errors { get; set; }
    }
}
