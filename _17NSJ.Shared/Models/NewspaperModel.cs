using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class NewspaperModel
    {
        /// <summary>
        /// IDを取得または設定します。
        /// </summary>
        /// <value>ID</value>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        /// <summary>
        /// タイトルを取得または設定します。
        /// </summary>
        /// <value>タイトル</value>
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// PDFのURLを取得または設定します。
        /// </summary>
        /// <value>PDFのURL</value>
        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        /// <summary>
        /// サムネイルURLを取得または設定します。
        /// </summary>
        /// <value>サムネイルURL</value>
        [JsonProperty("ThumbnailURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// 登録日時を取得または設定します。
        /// </summary>
        /// <value>登録日時</value>
        [JsonProperty("CreatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
    }
}

