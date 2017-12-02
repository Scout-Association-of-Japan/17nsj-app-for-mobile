using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class NewsInfoModel
    {
        /// <summary>
        /// カテゴリーを取得または設定します。
        /// </summary>
        /// <value>ユーザーID</value>
        [JsonProperty("Category", NullValueHandling = NullValueHandling.Ignore)]
        public char Category { get; set; }

        /// <summary>
        /// 通し番号を取得または設定します。
        /// </summary>
        /// <value>通し番号</value>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        /// <summary>
        /// 著者を取得または設定します。
        /// </summary>
        /// <value>著者</value>
        [JsonProperty("Author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// タイトルを取得または設定します。
        /// </summary>
        /// <value>タイトル</value>
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 概要を取得または設定します。
        /// </summary>
        /// <value>概要</value>
        [JsonProperty("Outline", NullValueHandling = NullValueHandling.Ignore)]
        public string Outline { get; set; }

        /// <summary>
        /// メディアURLを取得または設定します。
        /// </summary>
        /// <value>メディアURL</value>
        [JsonProperty("MediaURL", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaURL { get; set; }

        /// <summary>
        /// 関連URLを取得または設定します。
        /// </summary>
        /// <value>関連URL</value>
        [JsonProperty("RelationalURL", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationalURL { get; set; }

        /// <summary>
        /// サムネイルURLを取得または設定します。
        /// </summary>
        /// <value>サムネイルURL</value>
        [JsonProperty("ThumbnailURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// 配信日時を取得または設定します。
        /// </summary>
        /// <value>配信日時</value>
        [JsonProperty("CreatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 有効フラグを取得または設定します。
        /// </summary>
        /// <value>有効フラグ</value>
        [JsonProperty("IsAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// ラベルカラーを取得または設定します。
        /// </summary>
        /// <value>ラベルカラー</value>
        [JsonProperty("Color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
    }
}
