namespace NginxCSharp
{
    /// <summary>Status information of all HTTP
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_module.html#zone"&gt;dynamically configurable&lt;/a&gt;
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_module.html#upstream"&gt;groups&lt;/a&gt;.
    /// </summary>
    
    public partial class HTTPUpstreamMap : System.Collections.Generic.Dictionary<string, HTTPUpstream>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPUpstreamMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPUpstreamMap>(data);
        }
    
    }
}