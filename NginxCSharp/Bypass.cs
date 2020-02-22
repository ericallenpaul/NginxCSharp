namespace NginxCSharp
{
    public partial class Bypass 
    {
        /// <summary>The total number of responses not looked up in the cache due to the &lt;a href="https://nginx.org/en/docs/http/ngx_http_proxy_module.html#proxy_cache_bypass"&gt;proxy_cache_bypass&lt;/a&gt; and other “&lt;code&gt;*_cache_bypass&lt;/code&gt;” directives.</summary>
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Responses { get; set; }
    
        /// <summary>The total number of bytes read from the proxied server.</summary>
        [Newtonsoft.Json.JsonProperty("bytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes { get; set; }
    
        /// <summary>The total number of responses written to the cache.</summary>
        [Newtonsoft.Json.JsonProperty("responses_written", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Responses_written { get; set; }
    
        /// <summary>The total number of bytes written to the cache.</summary>
        [Newtonsoft.Json.JsonProperty("bytes_written", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes_written { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Bypass FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Bypass>(data);
        }
    
    }
}