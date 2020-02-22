namespace NginxCSharp
{
    public partial class Sessions 
    {
        /// <summary>The total number of sessions completed with &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_core_module.html#var_status"&gt;status codes&lt;/a&gt; “&lt;code&gt;2xx&lt;/code&gt;”.</summary>
        [Newtonsoft.Json.JsonProperty("2xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _2xx { get; set; }
    
        /// <summary>The total number of sessions completed with &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_core_module.html#var_status"&gt;status codes&lt;/a&gt; “&lt;code&gt;4xx&lt;/code&gt;”.</summary>
        [Newtonsoft.Json.JsonProperty("4xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _4xx { get; set; }
    
        /// <summary>The total number of sessions completed with &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_core_module.html#var_status"&gt;status codes&lt;/a&gt; “&lt;code&gt;5xx&lt;/code&gt;”.</summary>
        [Newtonsoft.Json.JsonProperty("5xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _5xx { get; set; }
    
        /// <summary>The total number of completed client sessions.</summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Sessions FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Sessions>(data);
        }
    
    }
}