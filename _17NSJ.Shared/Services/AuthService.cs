using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using _17NSJ.Constants;
using _17NSJ.Models;
using Newtonsoft.Json;

namespace _17NSJ.Services
{
    public class AuthService
    {
        public async Task<string> GetToken()
        {
            try
            {
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate };
                HttpResponseMessage response;

                using (var client = new HttpClient(handler))
                {

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var authContent = new StringContent($"grant_type=password&username={SecretConstants.UserId}&password={SecretConstants.Password}");

                    authContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                    response = await client.PostAsync(SecretConstants.AuthUrl, authContent);
                }

                if ((response.StatusCode == HttpStatusCode.BadRequest) ||
                    (response.StatusCode == HttpStatusCode.Unauthorized))
                {
                    return null;
                }

                response.EnsureSuccessStatusCode();

                var responseText = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<AuthResultModel>(responseText).Token;
            }
            catch(Exception)
            {
                // TODO 例外時のロギング
                return string.Empty;
            }
        }

    }
}
