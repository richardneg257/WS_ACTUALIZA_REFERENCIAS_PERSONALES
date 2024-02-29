using Newtonsoft.Json;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    public class InfoAddress
    {
        [JsonProperty(PropertyName = "direccionId", Order = 0)]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "clienteid", Order = 1)]
        public long ClientId { get; set; }
        [JsonProperty(PropertyName = "direccion", Order = 2)]
        public string Address { get; set; }
        [JsonProperty(PropertyName = "tipoDireccionId", Order = 3)]
        public int TypeId { get; set; }
        [JsonProperty(PropertyName = "tipoDireccionDes", Order = 4)]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "tipoViviendaId", Order = 5)]
        public int TipoViviendaId { get; set; }
        [JsonProperty(PropertyName = "tipoViviendaDes", Order = 6)]
        public string TipoViviendaDes { get; set; }
        [JsonProperty(PropertyName = "tipoDefinicionDireccionId", Order = 7)]
        public int TipoDefinicionDireccionId { get; set; }
        [JsonProperty(PropertyName = "tipoDefinicionDireccionDes", Order = 8)]
        public string TipoDefinicionDireccionDes { get; set; }
        [JsonProperty(PropertyName = "numeroDireccion", Order = 9)]
        public string NumeroDireccion { get; set; }
        [JsonProperty(PropertyName = "manzanaDireccion", Order = 10)]
        public string ManzanaDireccion { get; set; }
        [JsonProperty(PropertyName = "loteDireccion", Order = 11)]
        public string LoteDireccion { get; set; }
        [JsonProperty(PropertyName = "tipoDepartamentoId", Order = 12)]
        public int TipoDepartamentoId { get; set; }
        [JsonProperty(PropertyName = "tipoDepartamentoDes", Order = 13)]
        public string TipoDepartamentoDes { get; set; }
        [JsonProperty(PropertyName = "numeroDepartamento", Order = 14)]
        public string NumeroDepartamento { get; set; }
        [JsonProperty(PropertyName = "urbanizacionId", Order = 15)]
        public int UrbanizacionId { get; set; }
        [JsonProperty(PropertyName = "urbanizacionDes", Order = 16)]
        public string UrbanizacionDes { get; set; }
        [JsonProperty(PropertyName = "nombreUrbanizacion", Order = 17)]
        public string NombreUrbanizacion { get; set; }
        [JsonProperty(PropertyName = "sectorUrbanizacionId", Order = 18)]
        public int SectorUrbanizacionId { get; set; }
        [JsonProperty(PropertyName = "sectorUrbanizacionDes", Order = 19)]
        public string SectorUrbanizacionDes { get; set; }
        [JsonProperty(PropertyName = "nombreSectorUrbanizacion", Order = 20)]
        public string NombreSectorUrbanizacion { get; set; }
        [JsonProperty(PropertyName = "departamentoId", Order = 21)]
        public int DepartamentoId { get; set; }
        [JsonProperty(PropertyName = "departamentoDes", Order = 22)]
        public string DepartamentoDes { get; set; }
        [JsonProperty(PropertyName = "provinciaId", Order = 23)]
        public int ProvinciaId { get; set; }
        [JsonProperty(PropertyName = "provinciaDes", Order = 24)]
        public string ProvinciaDes { get; set; }
        [JsonProperty(PropertyName = "distritoId", Order = 25)]
        public int DistritoId { get; set; }
        [JsonProperty(PropertyName = "distritoDes", Order = 26)]
        public string DistritoDes { get; set; }
        [JsonProperty(PropertyName = "estado", Order = 27)]
        public string State { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 28)]
        public string User { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 29)]
        public string ModificationDate { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 30)]
        public string CreationDate { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 31)]
        public string Channel { get; set; }
        [JsonProperty(PropertyName = "latitudDomi", Order = 32)]
        public double LatitudDomi { get; set; }
        [JsonProperty(PropertyName = "longitudDomi", Order = 33)]
        public double LongitudDomi { get; set; }
    }
}
