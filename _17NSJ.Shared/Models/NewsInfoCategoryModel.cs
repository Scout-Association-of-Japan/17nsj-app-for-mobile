using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class NewsInfoCategoryModel
    {
        /// <summary>
        /// カテゴリーを取得または設定します。
        /// </summary>
        /// <value>カテゴリー</value>
        [JsonProperty("Category", NullValueHandling = NullValueHandling.Ignore)]
        public char Category { get; set; }

        /// <summary>
        /// カテゴリー名を取得または設定します。
        /// </summary>
        /// <value>カテゴリー名</value>
        [JsonProperty("CategoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// ラベルカラーを取得または設定します。
        /// </summary>
        /// <value>ラベルカラー</value>
        [JsonProperty("Color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// サムネイルURLを取得または設定します。
        /// </summary>
        /// <value>サムネイルURL</value>
        [JsonProperty("ThumbnailURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailURL { get; set; }
    }
}
