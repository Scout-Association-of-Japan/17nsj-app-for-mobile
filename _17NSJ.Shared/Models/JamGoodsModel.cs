using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class JamGoodsModel
    {
        /// <summary>
        /// カテゴリーを取得または設定します。
        /// </summary>
        /// <value>カテゴリー</value>
        [JsonProperty("Category", NullValueHandling = NullValueHandling.Ignore)]
        public char Category { get; set; }

        /// <summary>
        /// IDを取得または設定します。
        /// </summary>
        /// <value>ID</value>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        /// <summary>
        /// 表示順を取得または設定します。
        /// </summary>
        /// <value>表示順</value>
        [JsonProperty("DisplayOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// サムネイルURLを取得または設定します。
        /// </summary>
        /// <value>サムネイルURL</value>
        [JsonProperty("ThumbnailURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// 商品画像URLを取得または設定します。
        /// </summary>
        /// <value>商品画像URL</value>
        [JsonProperty("DetailImageURL", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailImageURL { get; set; }

        /// <summary>
        /// 在庫を取得または設定します。
        /// </summary>
        /// <value>在庫</value>
        [JsonProperty("Stock", NullValueHandling = NullValueHandling.Ignore)]
        public int Stock { get; set; }

        /// <summary>
        /// 在庫情報更新日時を取得または設定します。
        /// </summary>
        /// <value>在庫更新日時</value>
        [JsonProperty("StockUpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime StockUpdatedAt { get; set; }

        /// <summary>
        /// 品番を取得または設定します。
        /// </summary>
        /// <value>品番</value>
        [JsonProperty("PartsNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PartsNumber { get; set; }

        /// <summary>
        /// 品名を取得または設定します。
        /// </summary>
        /// <value>品名</value>
        [JsonProperty("GoodsName", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 値段を取得または設定します。
        /// </summary>
        /// <value>値段</value>
        [JsonProperty("Price", NullValueHandling = NullValueHandling.Ignore)]
        public int Price { get; set; }

        /// <summary>
        /// サイズを取得または設定します。
        /// </summary>
        /// <value>サイズ</value>
        [JsonProperty("Size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// 説明を取得または設定します。
        /// </summary>
        /// <value>説明</value>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 作成日時を取得または設定します。
        /// </summary>
        /// <value>作成日時</value>
        [JsonProperty("CreatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 作成者を取得または設定します。
        /// </summary>
        /// <value>作成者</value>
        [JsonProperty("CreatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 更新日時を取得または設定します。
        /// </summary>
        /// <value>更新日時</value>
        [JsonProperty("UpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 更新者を取得または設定します。
        /// </summary>
        /// <value>更新者</value>
        [JsonProperty("UpdatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        public string PriceText { get; set; }

        public string PriceTextColor { get; set; }
    }
}
