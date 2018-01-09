using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class DocumentModel
    {
        /// <summary>
        /// IDを取得または設定します。
        /// </summary>
        /// <value>ID</value>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        /// <summary>
        /// Titleを取得または設定します。
        /// </summary>
        /// <value>Title</value>
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Outlineを取得または設定します。
        /// </summary>
        /// <value>Outline</value>
        [JsonProperty("Outline", NullValueHandling = NullValueHandling.Ignore)]
        public string Outline { get; set; }

        /// <summary>
        /// ThumbnailURLを取得または設定します。
        /// </summary>
        /// <value>ThumbnailURL</value>
        [JsonProperty("ThumbnailURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// URLを取得または設定します。
        /// </summary>
        /// <value>URL</value>
        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        /// <summary>
        /// IsAvailableを取得または設定します。
        /// </summary>
        /// <value>IsAvailable</value>
        [JsonProperty("IsAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// CreatedAtを取得または設定します。
        /// </summary>
        /// <value>CreatedAt</value>
        [JsonProperty("CreatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// CreatedByを取得または設定します。
        /// </summary>
        /// <value>CreatedBy</value>
        [JsonProperty("CreatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// UpdatedAtを取得または設定します。
        /// </summary>
        /// <value>UpdatedAt</value>
        [JsonProperty("UpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// UpdatedByを取得または設定します。
        /// </summary>
        /// <value>UpdatedBy</value>
        [JsonProperty("UpdatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }
    }
}
