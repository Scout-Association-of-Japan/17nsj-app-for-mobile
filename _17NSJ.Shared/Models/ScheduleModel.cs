using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class ScheduleModel
    {
        /// <summary>
        /// タイトルを取得または設定します。
        /// </summary>
        /// <value>PDFのURL</value>
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 時間範囲フラグを取得または設定します。
        /// </summary>
        /// <value>PDFのURL</value>
        [JsonProperty("HasRange", NullValueHandling = NullValueHandling.Ignore)]
        public bool HasRange { get; set; }

        /// <summary>
        /// 開始時間を取得または設定します。
        /// </summary>
        /// <value>PDFのURL</value>
        [JsonProperty("Start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Start { get; set; }

        /// <summary>
        /// ラベルカラーを取得または設定します。
        /// </summary>
        /// <value>PDFのURL</value>
        [JsonProperty("Color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// 終了時間を取得または設定します。
        /// </summary>
        /// <value>PDFのURL</value>
        [JsonProperty("End", NullValueHandling = NullValueHandling.Include)]
        public DateTime? End { get; set; }
    }
}

