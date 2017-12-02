using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using _17NSJ.Constants;
using _17NSJ.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace _17NSJ.Services
{
    public class AppDataService
    {
        public async Task<MobileAppConfigModel> GetAppConfigAsync()
        {
            if (string.IsNullOrEmpty((Application.Current as App).Token))
            {
                (Application.Current as App).Token = await new AuthService().GetToken();
            }

            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}mobile_app_config"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MobileAppConfigModel>(responseText);
        }

        public async Task<ObservableCollection<NewsCategoryModel>> GetNewsCategoriesAsync()
        {
            if (string.IsNullOrEmpty((Application.Current as App).Token))
            {
                (Application.Current as App).Token = await new AuthService().GetToken();
            }

            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}news_categories"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<NewsCategoryModel>>(responseText);
        }

        public async Task<ObservableCollection<NewsInfoModel>> GetNewsAsync()
        {
            if (string.IsNullOrEmpty((Application.Current as App).Token))
            {
                (Application.Current as App).Token = await new AuthService().GetToken();
            }

            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}news"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<NewsInfoModel>>(responseText);
        }

        public async Task<ObservableCollection<ActivityModel>> GetActivitiesAsync()
        {
            if (string.IsNullOrEmpty((Application.Current as App).Token))
            {
                (Application.Current as App).Token = await new AuthService().GetToken();
            }

            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}activities"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<ActivityModel>>(responseText);
        }




        private async Task<HttpResponseMessage> GetAsyncBase(Uri uri)
        {
            try
            {
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate };
                HttpResponseMessage response;

                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", (Application.Current as App).Token);
                    response = await client.GetAsync(uri);
                }

                if ((response.StatusCode == HttpStatusCode.BadRequest) ||
                    (response.StatusCode == HttpStatusCode.Unauthorized))
                {
                    // TODO トークン切れかもしれないとき
                    return response;
                }

                response.EnsureSuccessStatusCode();

                return response;
            }
            catch (Exception e)
            {
                // TODO 失敗した時の処理
                e.ToString();
                return null;
            }
        }
    }
}
