namespace NginxCSharp
{
    public partial class Health_checks 
    {
        /// <summary>The total number of &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_hc_module.html#health_check"&gt;health check&lt;/a&gt; requests made.</summary>
        [Newtonsoft.Json.JsonProperty("checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Checks { get; set; }
    
        /// <summary>The number of failed health checks.</summary>
        [Newtonsoft.Json.JsonProperty("fails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Fails { get; set; }
    
        /// <summary>How many times the server became unhealthy (state “&lt;code&gt;unhealthy&lt;/code&gt;”).</summary>
        [Newtonsoft.Json.JsonProperty("unhealthy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Unhealthy { get; set; }
    
        /// <summary>Boolean indicating if the last health check request was successful and passed &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_hc_module.html#match"&gt;tests&lt;/a&gt;.</summary>
        [Newtonsoft.Json.JsonProperty("last_passed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Last_passed { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Health_checks FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Health_checks>(data);
        }
    
    }
}