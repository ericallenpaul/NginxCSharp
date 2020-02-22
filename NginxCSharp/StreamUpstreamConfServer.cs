namespace NginxCSharp
{
    /// <summary>Dynamically configurable parameters of a stream upstream
    /// &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#server"&gt;server&lt;/a&gt;:
    /// </summary>
    
    public partial class StreamUpstreamConfServer 
    {
        /// <summary>The ID of the stream upstream server. The ID is assigned automatically and cannot be changed.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#server"&gt;address&lt;/a&gt; parameter of the stream upstream server. When adding a server, it is possible to specify it as a domain name. In this case, changes of the IP addresses that correspond to a domain name will be monitored and automatically applied to the upstream configuration without the need of restarting nginx. This requires the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_core_module.html#resolver"&gt;resolver&lt;/a&gt; directive in the “&lt;code&gt;stream&lt;/code&gt;” block. See also the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#resolve"&gt;resolve&lt;/a&gt; parameter of the stream upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#service"&gt;service&lt;/a&gt; parameter of the stream upstream server. This parameter cannot be changed.</summary>
        [Newtonsoft.Json.JsonProperty("service", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Service { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#weight"&gt;weight&lt;/a&gt; parameter of the stream upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Weight { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#max_conns"&gt;max_conns&lt;/a&gt; parameter of the stream upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("max_conns", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Max_conns { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#max_fails"&gt;max_fails&lt;/a&gt; parameter of the stream upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("max_fails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Max_fails { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#fail_timeout"&gt;fail_timeout&lt;/a&gt; parameter of the stream upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("fail_timeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fail_timeout { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#slow_start"&gt;slow_start&lt;/a&gt; parameter of the stream upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("slow_start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Slow_start { get; set; }
    
        /// <summary>When &lt;code&gt;true&lt;/code&gt;, adds a &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#backup"&gt;backup&lt;/a&gt; server. This parameter cannot be changed.</summary>
        [Newtonsoft.Json.JsonProperty("backup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Backup { get; set; }
    
        /// <summary>Same as the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#down"&gt;down&lt;/a&gt; parameter of the stream upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("down", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Down { get; set; }
    
        /// <summary>Parent server ID of the resolved server. The ID is assigned automatically and cannot be changed.</summary>
        [Newtonsoft.Json.JsonProperty("parent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Parent { get; set; }
    
        /// <summary>Hostname of the resolved server. The hostname is assigned automatically and cannot be changed.</summary>
        [Newtonsoft.Json.JsonProperty("host", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Host { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamUpstreamConfServer FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamUpstreamConfServer>(data);
        }
    
    }
}