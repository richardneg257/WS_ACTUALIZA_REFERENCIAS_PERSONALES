using BCP.Business.Connector.Infocliente.Entities;
using BCP.Framework.Logs;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BCP.Business.Connector.Infocliente.Managers.V2
{
    public class InfoClienteManager
    {
        private string BaseUrl { get; set; }
        private string SearchPath { get; set; }
        private string UpdatePath { get; set; }
        private string Channel { get; set; }
        private string User { get; set; }
        private string Password { get; set; }

        public InfoClienteManager()
        {
            this.BaseUrl = ConfigurationManager.AppSettings["InfoCliente.BaseUrl"].ToString();
            this.SearchPath = ConfigurationManager.AppSettings["InfoCliente.SearchPath"].ToString();
            this.UpdatePath = ConfigurationManager.AppSettings["InfoCliente.UpdatePath"].ToString();
            this.Channel = ConfigurationManager.AppSettings["InfoCliente.Channel"].ToString();
            this.User = ConfigurationManager.AppSettings["InfoCliente.User"].ToString();
            this.Password = ConfigurationManager.AppSettings["InfoCliente.Password"].ToString();
        }

        public async Task<InfoClienteSearchResponse> Search(string documentNumber, string documentExtension, string documentComplement, string documentType)
        {
            try
            {
                var infoClienteSearchRequest = new InfoClienteSearchRequest
                {
                    Channel = this.Channel,
                    Password = this.Password,
                    User = this.User,
                    DocumentComplement = documentComplement,
                    DocumentExtension = documentExtension,
                    DocumentNumber = documentNumber,
                    DocumentType = documentType
                };

                var requestJson = JsonConvert.SerializeObject(infoClienteSearchRequest);
                Logger.Debug("Inicio del metodo SearchClient V2 con valores de entrada: {0}", requestJson);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
                using (var client = new HttpClient())
                {
                    var stringContent = new StringContent(requestJson, Encoding.UTF8);
                    stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    client.BaseAddress = new Uri(this.BaseUrl);
                    using (var response = client.PostAsync(this.SearchPath, stringContent).Result)
                    {
                        using (var content = response.Content)
                        {
                            var result = await content.ReadAsStringAsync();
                            Logger.Debug("Fin del metodo SearchClient V2 con valores de respuesta: " + JsonConvert.SerializeObject(result));
                            return JsonConvert.DeserializeObject<InfoClienteSearchResponse>(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Fatal(
                    $"InfoClienteManager.Search() > DocumentNumber: {documentNumber}; DocumentExtension: {documentExtension}; " +
                    $"DocumentComplement: {documentComplement}; DocumentType: {documentType}; Exception: {ex.Message}");

                throw new Exception(ex.ToString());
            }
        }
    }
}
