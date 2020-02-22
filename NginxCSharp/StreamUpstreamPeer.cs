using NginxCSharp.Enums;

namespace NginxCSharp
{
    public partial class StreamUpstreamPeer 
    {
        /// <summary>The ID of the server.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        /// <summary>An &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#server"&gt;address&lt;/a&gt; of the server.</summary>
        [Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server { get; set; }
    
        /// <summary>The &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#service"&gt;service&lt;/a&gt; parameter value of the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#server"&gt;server&lt;/a&gt; directive.</summary>
        [Newtonsoft.Json.JsonProperty("service", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Service { get; set; }
    
        /// <summary>The name of the server specified in the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#server"&gt;server&lt;/a&gt; directive.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>A boolean value indicating whether the server is a &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#backup"&gt;backup&lt;/a&gt; server.</summary>
        [Newtonsoft.Json.JsonProperty("backup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Backup { get; set; }
    
        /// <summary>&lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#weight"&gt;Weight&lt;/a&gt; of the server.</summary>
        [Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Weight { get; set; }
    
        /// <summary>Current state, which may be one of “&lt;code&gt;up&lt;/code&gt;”, “&lt;code&gt;down&lt;/code&gt;”, “&lt;code&gt;unavail&lt;/code&gt;”, “&lt;code&gt;checking&lt;/code&gt;”, or “&lt;code&gt;unhealthy&lt;/code&gt;”.</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public NginxStreamUpstreamPeerState? State { get; set; }
    
        /// <summary>The current number of connections.</summary>
        [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Active { get; set; }
    
        /// <summary>The &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#max_conns"&gt;max_conns&lt;/a&gt; limit for the server.</summary>
        [Newtonsoft.Json.JsonProperty("max_conns", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Max_conns { get; set; }
    
        /// <summary>The total number of client connections forwarded to this server.</summary>
        [Newtonsoft.Json.JsonProperty("connections", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Connections { get; set; }
    
        /// <summary>The average time to connect to the upstream server.</summary>
        [Newtonsoft.Json.JsonProperty("connect_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Connect_time { get; set; }
    
        /// <summary>The average time to receive the first byte of data.</summary>
        [Newtonsoft.Json.JsonProperty("first_byte_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? First_byte_time { get; set; }
    
        /// <summary>The average time to receive the last byte of data.</summary>
        [Newtonsoft.Json.JsonProperty("response_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Response_time { get; set; }
    
        /// <summary>The total number of bytes sent to this server.</summary>
        [Newtonsoft.Json.JsonProperty("sent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Sent { get; set; }
    
        /// <summary>The total number of bytes received from this server.</summary>
        [Newtonsoft.Json.JsonProperty("received", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Received { get; set; }
    
        /// <summary>The total number of unsuccessful attempts to communicate with the server.</summary>
        [Newtonsoft.Json.JsonProperty("fails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Fails { get; set; }
    
        /// <summary>How many times the server became unavailable for client connections (state “&lt;code&gt;unavail&lt;/code&gt;”) due to the number of unsuccessful attempts reaching the &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#max_fails"&gt;max_fails&lt;/a&gt; threshold.</summary>
        [Newtonsoft.Json.JsonProperty("unavail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Unavail { get; set; }
    
        [Newtonsoft.Json.JsonProperty("health_checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Health_checks2 Health_checks { get; set; }
    
        /// <summary>Total time the server was in the “&lt;code&gt;unavail&lt;/code&gt;”, “&lt;code&gt;checking&lt;/code&gt;”, and “&lt;code&gt;unhealthy&lt;/code&gt;” states.</summary>
        [Newtonsoft.Json.JsonProperty("downtime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Downtime { get; set; }
    
        /// <summary>The time when the server became “&lt;code&gt;unavail&lt;/code&gt;”, “&lt;code&gt;checking&lt;/code&gt;”, or “&lt;code&gt;unhealthy&lt;/code&gt;”, in the ISO 8601 format with millisecond resolution.</summary>
        [Newtonsoft.Json.JsonProperty("downstart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Downstart { get; set; }
    
        /// <summary>The time when the server was last selected to process a connection, in the ISO 8601 format with millisecond resolution.</summary>
        [Newtonsoft.Json.JsonProperty("selected", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Selected { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamUpstreamPeer FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamUpstreamPeer>(data);
        }
    
    }
}