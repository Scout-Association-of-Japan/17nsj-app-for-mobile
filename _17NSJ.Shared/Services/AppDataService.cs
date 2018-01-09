using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using _17NSJ.Constants;
using _17NSJ.Exceptions;
using _17NSJ.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace _17NSJ.Services
{
    public class AppDataService
    {
        public async Task<MobileAppConfigModel> GetAppConfigAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}mobile_app_config"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MobileAppConfigModel>(responseText);
        }

        public async Task<ObservableCollection<NewsInfoCategoryModel>> GetNewsCategoriesAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}news_categories"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<NewsInfoCategoryModel>>(responseText);
        }

        public async Task<ObservableCollection<NewsInfoModel>> GetNewsAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}news"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<NewsInfoModel>>(responseText);
        }

        public async Task<ObservableCollection<ActivityCategoryModel>> GetActivityCategoriesAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}activity_categories"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<ActivityCategoryModel>>(responseText);
        }

        public async Task<ObservableCollection<ActivityModel>> GetActivitiesAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}activities"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<ActivityModel>>(responseText);
        }

        public async Task<ObservableCollection<MovieModel>> GetMoviesAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}movies"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<MovieModel>>(responseText);
        }

        public async Task<ObservableCollection<DocumentModel>> GetDocumentsAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}documents"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<DocumentModel>>(responseText);
        }

        public async Task<ObservableCollection<NewspaperModel>> GetNewspapersAsync()
        {
            HttpResponseMessage response = await GetAsyncBase(new Uri($"{SecretConstants.ApiUrl}newspapers"));
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ObservableCollection<NewspaperModel>>(responseText);
        }

        private async Task<HttpResponseMessage> GetAsyncBase(Uri uri)
        {
            if (string.IsNullOrEmpty((Application.Current as App).Token))
            {
                (Application.Current as App).Token = await new AuthService().GetToken();
            }

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
            catch
            {
                // todo:例外時のロギング
                throw new OutOfServiceException();
            }
        }
    }
}
