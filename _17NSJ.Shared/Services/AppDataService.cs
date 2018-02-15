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
            // トークンが空のときは取得
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
                    // トークン切れかもしれないとき、トークンを再度取得
                    (Application.Current as App).Token = await new AuthService().GetToken();

                    try
                    {
                        // ハンドラを使いまわしするとDispose例外になるので再作成
                        var reHandler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate };

                        using (var client = new HttpClient(reHandler))
                        {
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", (Application.Current as App).Token);
                            response = await client.GetAsync(uri);
                        }

                        response.EnsureSuccessStatusCode();
                        return response;
                    }
                    catch
                    {
                        //２回目でも成功コード以外ならサービス提供外
                        // TODO 例外時のロギング
                        throw new OutOfServiceException();
                    }
                }

                response.EnsureSuccessStatusCode();
                return response;
            }
            catch
            {
                // TODO 例外時のロギング
                throw new OutOfServiceException();
            }
        }
    }
}
