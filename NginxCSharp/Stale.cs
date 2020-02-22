namespace NginxCSharp
{
    public partial class Stale 
    {
        /// <summary>The total number of expired responses read from the cache (see &lt;a href="https://nginx.org/en/docs/http/ngx_http_proxy_module.html#proxy_cache_use_stale"&gt;proxy_cache_use_stale&lt;/a&gt; and other “&lt;code&gt;*_cache_use_stale&lt;/code&gt;” directives).</summary>
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Responses { get; set; }
    
        /// <summary>The total number of bytes read from the cache.</summary>
        [Newtonsoft.Json.JsonProperty("bytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Stale FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Stale>(data);
        }
    
    }
}