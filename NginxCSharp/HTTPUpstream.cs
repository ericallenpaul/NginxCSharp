namespace NginxCSharp
{
    public partial class HTTPUpstream 
    {
        [Newtonsoft.Json.JsonProperty("peers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HTTPUpstreamPeerMap Peers { get; set; }
    
        /// <summary>The current number of idle &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_module.html#keepalive"&gt;keepalive&lt;/a&gt; connections.</summary>
        [Newtonsoft.Json.JsonProperty("keepalive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Keepalive { get; set; }
    
        /// <summary>The current number of servers removed from the group but still processing active client requests.</summary>
        [Newtonsoft.Json.JsonProperty("zombies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Zombies { get; set; }
    
        /// <summary>The name of the shared memory &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_module.html#zone"&gt;zone&lt;/a&gt; that keeps the group’s configuration and run-time state.</summary>
        [Newtonsoft.Json.JsonProperty("zone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone { get; set; }
    
        /// <summary>For the requests &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_module.html#queue"&gt;queue&lt;/a&gt;, the following data are provided:
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Queue Queue { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPUpstream FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPUpstream>(data);
        }
    
    }
}