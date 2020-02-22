namespace NginxCSharp
{
    public partial class Hit 
    {
        /// <summary>The total number of &lt;a href="https://nginx.org/en/docs/http/ngx_http_proxy_module.html#proxy_cache_valid"&gt;valid&lt;/a&gt; responses read from the cache.</summary>
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Responses { get; set; }
    
        /// <summary>The total number of bytes read from the cache.</summary>
        [Newtonsoft.Json.JsonProperty("bytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Hit FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Hit>(data);
        }
    
    }
}