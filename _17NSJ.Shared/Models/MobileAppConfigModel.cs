using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class MobileAppConfigModel
    {
        /// <summary>
        /// 強制的にアップデートするかを取得または設定します。
        /// </summary>
        /// <value>強制的にアップデートするか</value>
        [JsonProperty("ForceUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public bool ForceUpdate { get; set; }

        /// <summary>
        /// iOSバージョンを取得または設定します。
        /// </summary>
        /// <value>iOSバージョン</value>
        [JsonProperty("iOSVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string iOSVersion { get; set; }

        /// <summary>
        /// Droidバージョンを取得または設定します。
        /// </summary>
        /// <value>Droidバージョン</value>
        [JsonProperty("DroidVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string DroidVersion { get; set; }

        /// <summary>
        /// iOSStoreURLを取得または設定します。
        /// </summary>
        /// <value>iOSStoreURL</value>
        [JsonProperty("iOSStoreURL", NullValueHandling = NullValueHandling.Ignore)]
        public string iOSStoreURL { get; set; }

        /// <summary>
        /// DroidStoreURLを取得または設定します。
        /// </summary>
        /// <value>DroidStoreURL</value>
        [JsonProperty("DroidStoreURL", NullValueHandling = NullValueHandling.Ignore)]
        public string DroidStoreURL { get; set; }
    }
}
