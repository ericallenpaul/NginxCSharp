namespace NginxCSharp
{
    /// <summary>Statistics of DNS requests and responses per particular
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_core_module.html#resolver_status_zone"&gt;resolver zone&lt;/a&gt;.
    /// </summary>
    
    public partial class ResolverZone 
    {
        [Newtonsoft.Json.JsonProperty("requests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Requests Requests { get; set; }
    
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Responses4 Responses { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static ResolverZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResolverZone>(data);
        }
    
    }
}