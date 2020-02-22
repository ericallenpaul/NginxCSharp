namespace NginxCSharp
{
    public partial class Revalidated 
    {
        /// <summary>The total number of expired and revalidated responses read from the cache (see &lt;a href="https://nginx.org/en/docs/http/ngx_http_proxy_module.html#proxy_cache_revalidate"&gt;proxy_cache_revalidate&lt;/a&gt; and other “&lt;code&gt;*_cache_revalidate&lt;/code&gt;” directives.</summary>
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Responses { get; set; }
    
        /// <summary>The total number of bytes read from the cache.</summary>
        [Newtonsoft.Json.JsonProperty("bytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Revalidated FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Revalidated>(data);
        }
    
    }
}