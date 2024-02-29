using Newtonsoft.Json;

namespace BCP.Business.Connector.Infocliente.Entities.Model
{
    public class InfoOccupationalExtended
    {
        [JsonProperty(PropertyName = "datoLaboralExtendidoId", Order = 0)]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "clienteId", Order = 1)]
        public long ClientId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaDosId", Order = 2)]
        public int SubcategoriaDosId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaDosDes", Order = 3)]
        public string SubcategoriaDosDes { get; set; }
        [JsonProperty(PropertyName = "subcategoriaTresId", Order = 4)]
        public int SubcategoriaTresId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaTresDes", Order = 5)]
        public string SubcategoriaTresDes { get; set; }
        [JsonProperty(PropertyName = "subcategoriaCuatroId", Order = 6)]
        public int SubcategoriaCuatroId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaCuatroDes", Order = 7)]
        public string SubcategoriaCuatroDes { get; set; }
        [JsonProperty(PropertyName = "subcategoriaCincoId", Order = 8)]
        public int SubcategoriaCincoId { get; set; }
        [JsonProperty(PropertyName = "subcategoriaCincoDes", Order = 9)]
        public string SubcategoriaCincoDes { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralDosId", Order = 10)]
        public int SituacionlaboralDosId { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralDosDes", Order = 11)]
        public string SituacionlaboralDosDes { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralTresId", Order = 12)]
        public int SituacionlaboralTresId { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralTresDes", Order = 13)]
        public string SituacionlaboralTresDes { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralCuatroId", Order = 14)]
        public int SituacionlaboralCuatroId { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralCuatroDes", Order = 15)]
        public string SituacionlaboralCuatroDes { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralCincoId", Order = 16)]
        public int SituacionlaboralCincoId { get; set; }
        [JsonProperty(PropertyName = "situacionlaboralCincoDes", Order = 17)]
        public string SituacionlaboralCincoDes { get; set; }
        [JsonProperty(PropertyName = "actividadDosId", Order = 18)]
        public int ActividadDosId { get; set; }
        [JsonProperty(PropertyName = "actividadDosDes", Order = 19)]
        public string ActividadDosDes { get; set; }
        [JsonProperty(PropertyName = "actividadTresId", Order = 20)]
        public int ActividadTresId { get; set; }
        [JsonProperty(PropertyName = "actividadTresDes", Order = 21)]
        public string ActividadTresDes { get; set; }
        [JsonProperty(PropertyName = "actividadCuatroId", Order = 22)]
        public int ActividadCuatroId { get; set; }
        [JsonProperty(PropertyName = "actividadCuatroDes", Order = 23)]
        public string ActividadCuatroDes { get; set; }
        [JsonProperty(PropertyName = "actividadCincoId", Order = 24)]
        public int ActividadCincoId { get; set; }
        [JsonProperty(PropertyName = "actividadCincoDes", Order = 25)]
        public string ActividadCincoDes { get; set; }
        [JsonProperty(PropertyName = "ciiuDosId", Order = 26)]
        public int CiiuDosId { get; set; }
        [JsonProperty(PropertyName = "ciiuDosDes", Order = 27)]
        public string CiiuDosDes { get; set; }
        [JsonProperty(PropertyName = "ciiuTresId", Order = 28)]
        public int CiiuTresId { get; set; }
        [JsonProperty(PropertyName = "ciiuTresDes", Order = 29)]
        public string CiiuTresDes { get; set; }
        [JsonProperty(PropertyName = "ciiuCuatroId", Order = 30)]
        public int CiiuCuatroId { get; set; }
        [JsonProperty(PropertyName = "ciiuCuatroDes", Order = 31)]
        public string CiiuCuatroDes { get; set; }
        [JsonProperty(PropertyName = "ciiuCincoId", Order = 32)]
        public int CiiuCincoId { get; set; }
        [JsonProperty(PropertyName = "ciiuCincoDes", Order = 33)]
        public string CiiuCincoDes { get; set; }
        [JsonProperty(PropertyName = "estado", Order = 34)]
        public string State { get; set; }
        [JsonProperty(PropertyName = "usuario", Order = 34)]
        public string User { get; set; }
        [JsonProperty(PropertyName = "canal", Order = 35)]
        public string Channel { get; set; }
        [JsonProperty(PropertyName = "fechaCreacion", Order = 36)]
        public string CreationDate { get; set; }
        [JsonProperty(PropertyName = "fechaUltimaModificacion", Order = 37)]
        public string ModificationDate { get; set; }
    }
}
