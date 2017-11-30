using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class MobileAppConfigModel
    {
        /// <summary>
        /// バージョンを取得または設定します。
        /// </summary>
        /// <value>バージョン</value>
        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 強制的にアップデートするかを取得または設定します。
        /// </summary>
        /// <value>強制的にアップデートするか</value>
        [JsonProperty("ForceUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public bool ForceUpdate { get; set; }
    }
}
