using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class ActivityModel
    {
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        [JsonProperty("Category", NullValueHandling = NullValueHandling.Ignore)]
        public char Category { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the outline.
        /// </summary>
        /// <value>The outline.</value>
        [JsonProperty("Outline", NullValueHandling = NullValueHandling.Ignore)]
        public string Outline { get; set; }

        /// <summary>
        /// Gets or sets the media URL.
        /// </summary>
        /// <value>The media URL.</value>
        [JsonProperty("MediaURL", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaURL { get; set; }

        /// <summary>
        /// Gets or sets the relational URL.
        /// </summary>
        /// <value>The relational URL.</value>
        [JsonProperty("RelationalURL", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationalURL { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail URL.
        /// </summary>
        /// <value>The thumbnail URL.</value>
        [JsonProperty("ThumbnailURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// Gets or sets a the can waitable.
        /// </summary>
        /// <value><c>true</c> if can waitable; otherwise, <c>false</c>.</value>
        [JsonProperty("CanWaitable", NullValueHandling = NullValueHandling.Ignore)]
        public bool CanWaitable { get; set; }

        /// <summary>
        /// Gets or sets a the is closed.
        /// </summary>
        /// <value><c>true</c> if is closed; otherwise, <c>false</c>.</value>
        [JsonProperty("IsClosed", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Gets or sets the waiting time.
        /// </summary>
        /// <value>The waiting time.</value>
        [JsonProperty("WaitingTime", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitingTime { get; set; }

        /// <summary>
        /// Gets or sets the is available.
        /// </summary>
        /// <value>The is available.</value>
        [JsonProperty("IsAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>The updated at.</value>
        [JsonProperty("UpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// ラベルカラーを取得または設定します。
        /// </summary>
        /// <value>ラベルカラー</value>
        [JsonProperty("Color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// 期間を取得または設定します。
        /// </summary>
        /// <value>期間</value>
        [JsonProperty("Term", NullValueHandling = NullValueHandling.Ignore)]
        public string Term { get; set; }

        /// <summary>
        /// 場所を取得または設定します。
        /// </summary>
        /// <value>場所</value>
        [JsonProperty("Location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// マップのURLを取得または設定します。
        /// </summary>
        /// <value>マップのURL</value>
        [JsonProperty("MapURL", NullValueHandling = NullValueHandling.Ignore)]
        public string MapURL { get; set; }

        /// <summary>
        /// 待機情報の更新日時を取得または設定します。
        /// </summary>
        /// <value>待機情報の更新日時</value>
        [JsonProperty("WaitingInfoUpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime WaitingInfoUpdatedAt { get; set; }

        /// <summary>
        /// 緯度を取得または設定します。
        /// </summary>
        /// <value>緯度</value>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        /// <summary>
        /// 経度を取得または設定します。
        /// </summary>
        /// <value>経度</value>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the color of the waiting info background.
        /// </summary>
        /// <value>The color of the waiting info background.</value>
        public string WaitingInfoBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the state of the waiting info.
        /// </summary>
        /// <value>The state of the waiting info.</value>
        public string WaitingInfoState { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <value>The name of the category.</value>
        public string CategoryName { get; set; }
    }
}
