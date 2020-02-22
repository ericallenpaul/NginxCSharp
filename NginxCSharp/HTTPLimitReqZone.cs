namespace NginxCSharp
{
    public partial class HTTPLimitReqZone 
    {
        /// <summary>The total number of requests that were neither limited nor accounted as limited.</summary>
        [Newtonsoft.Json.JsonProperty("passed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Passed { get; set; }
    
        /// <summary>The total number of requests that were delayed.</summary>
        [Newtonsoft.Json.JsonProperty("delayed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Delayed { get; set; }
    
        /// <summary>The total number of requests that were rejected.</summary>
        [Newtonsoft.Json.JsonProperty("rejected", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rejected { get; set; }
    
        /// <summary>The total number of requests accounted as delayed in the &lt;a href="https://nginx.org/en/docs/http/ngx_http_limit_req_module.html#limit_req_dry_run"&gt;dry run&lt;/a&gt; mode.</summary>
        [Newtonsoft.Json.JsonProperty("delayed_dry_run", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Delayed_dry_run { get; set; }
    
        /// <summary>The total number of requests accounted as rejected in the &lt;a href="https://nginx.org/en/docs/http/ngx_http_limit_req_module.html#limit_req_dry_run"&gt;dry run&lt;/a&gt; mode.</summary>
        [Newtonsoft.Json.JsonProperty("rejected_dry_run", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rejected_dry_run { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPLimitReqZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLimitReqZone>(data);
        }
    
    }
}