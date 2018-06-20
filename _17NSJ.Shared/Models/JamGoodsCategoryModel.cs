using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class JamGoodsCategoryModel
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
        /// 表示順を取得または設定します。
        /// </summary>
        /// <value>表示順</value>
        [JsonProperty("DisplayOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int DisplayOrder { get; set; }
    }
}
