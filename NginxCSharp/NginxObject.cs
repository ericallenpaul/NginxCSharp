namespace NginxCSharp
{
    /// <summary>General information about nginx:
    /// </summary>
    
    public partial class NginxObject 
    {
        /// <summary>Version of nginx.</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }
    
        /// <summary>Name of nginx build.</summary>
        [Newtonsoft.Json.JsonProperty("build", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Build { get; set; }
    
        /// <summary>The address of the server that accepted status request.</summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get; set; }
    
        /// <summary>The total number of configuration &lt;a href="https://nginx.org/en/docs/control.html#reconfiguration"&gt;reloads&lt;/a&gt;.</summary>
        [Newtonsoft.Json.JsonProperty("generation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Generation { get; set; }
    
        /// <summary>Time of the last reload of configuration, in the ISO 8601 format with millisecond resolution.</summary>
        [Newtonsoft.Json.JsonProperty("load_timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Load_timestamp { get; set; }
    
        /// <summary>Current time in the ISO 8601 format with millisecond resolution.</summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Timestamp { get; set; }
    
        /// <summary>The ID of the worker process that handled status request.</summary>
        [Newtonsoft.Json.JsonProperty("pid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pid { get; set; }
    
        /// <summary>The ID of the master process that started the &lt;a href="https://nginx.org/en/docs/http/ngx_http_status_module.html#pid"&gt;worker process&lt;/a&gt;.</summary>
        [Newtonsoft.Json.JsonProperty("ppid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Ppid { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static NginxObject FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<NginxObject>(data);
        }
    
    }
}