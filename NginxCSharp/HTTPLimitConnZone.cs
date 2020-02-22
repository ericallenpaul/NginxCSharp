namespace NginxCSharp
{
    public partial class HTTPLimitConnZone 
    {
        /// <summary>The total number of connections that were neither limited nor accounted as limited.</summary>
        [Newtonsoft.Json.JsonProperty("passed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Passed { get; set; }
    
        /// <summary>The total number of connections that were rejected.</summary>
        [Newtonsoft.Json.JsonProperty("rejected", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rejected { get; set; }
    
        /// <summary>The total number of connections accounted as rejected in the &lt;a href="https://nginx.org/en/docs/http/ngx_http_limit_conn_module.html#limit_conn_dry_run"&gt;dry run&lt;/a&gt; mode.</summary>
        [Newtonsoft.Json.JsonProperty("rejected_dry_run", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rejected_dry_run { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPLimitConnZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLimitConnZone>(data);
        }
    
    }
}