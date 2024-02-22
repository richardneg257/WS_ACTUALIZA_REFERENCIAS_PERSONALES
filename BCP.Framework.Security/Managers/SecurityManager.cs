using BCP.Business.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace BCP.Framework.Security.Managers
{
    public class SecurityManager
    {
        private readonly string _url;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _publicToken;
        private readonly string _segCryptName;
        private readonly string _appUserId;
        private readonly string _shortName;
        private readonly bool _isLocal;

        public SecurityManager(string url, string userName, string password, string publicToken, bool isLocal, string segCryptName, string appUserId, string shortName)
        {
            _url = url;
            _userName = userName;
            _password = password;
            _publicToken = publicToken;
            _isLocal = isLocal;
            _segCryptName = segCryptName;
            _appUserId = appUserId;
            _shortName = shortName;
        }

        public string EncryptDecrypt(bool encrypt, string text)
        {
            try
            {

                if (_isLocal)
                {
                    return SegCrypt.EncryptDecrypt(encrypt, text);
                }

                else
                {
                    SecurityRequest securityRequest = new SecurityRequest()
                    {
                        publicToken = _publicToken,
                        Text = text,
                        Encrypt = encrypt,
                        appUserId = _appUserId,
                        SegCryptName = _segCryptName
                    };

                    var json = Json.ToObject(securityRequest);
                    var content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                    var httpClientHandler = new HttpClientHandler
                    {
                        ClientCertificateOptions = ClientCertificateOption.Manual,
                        ServerCertificateCustomValidationCallback =
                        (httpRequestMessage, cert, cetChain, policyErrors) =>
                        {
                            return true;
                        }
                    };
                    HttpClient httpClient = new HttpClient(httpClientHandler);
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", Convert.ToBase64String(Encoding.Default.GetBytes(_userName + ":" + _password)));
                    httpClient.DefaultRequestHeaders.Add("Correlation-Id", Headers.GetCorrelationId(_shortName));
                    var response = httpClient.PostAsync(new Uri(_url), content).Result;
                    var securityResponse = JsonD.ToObject<IResponse<SecurityResponse>>(response.Content.ReadAsStringAsync().Result);
                    if (securityResponse.State == "00")
                        return securityResponse.Data.Text;
                    throw new Exception(securityResponse.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
