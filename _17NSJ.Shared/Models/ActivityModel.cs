using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class ActivityModel
    {
        /// <summary>
        /// アクセストークンを取得または設定します。
        /// </summary>
        /// <value>アクセストークン</value>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

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
        /// Gets or sets the created at.
        /// </summary>
        /// <value>The created at.</value>
        [JsonProperty("CreatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        [JsonProperty("CreatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>The updated at.</value>
        [JsonProperty("UpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the updated by.
        /// </summary>
        /// <value>The updated by.</value>
        [JsonProperty("UpdatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedBy { get; set; }

        /// <summary>
        /// ラベルカラーを取得または設定します。
        /// </summary>
        /// <value>ラベルカラー</value>
        [JsonProperty("Color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
    }
}
