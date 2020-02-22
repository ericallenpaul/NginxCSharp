namespace NginxCSharp
{
    /// <summary>Status information of all HTTP caches configured by 
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_proxy_module.html#proxy_cache_path"&gt;proxy_cache_path&lt;/a&gt;
    /// and other “&lt;code&gt;*_cache_path&lt;/code&gt;” directives.
    /// </summary>
    
    public partial class HTTPCachesMap : System.Collections.Generic.Dictionary<string, HTTPCache>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPCachesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPCachesMap>(data);
        }
    
    }
}