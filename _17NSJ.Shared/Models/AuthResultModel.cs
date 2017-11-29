using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class AuthResultModel
    {
        /// <summary>
        /// アクセストークンを取得または設定します。
        /// </summary>
        /// <value>アクセストークン</value>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
    }
}
