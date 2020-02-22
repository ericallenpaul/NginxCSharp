namespace NginxCSharp
{
    public partial class StreamUpstream 
    {
        [Newtonsoft.Json.JsonProperty("peers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StreamUpstreamPeerMap Peers { get; set; }
    
        /// <summary>The current number of servers removed from the group but still processing active client connections.</summary>
        [Newtonsoft.Json.JsonProperty("zombies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Zombies { get; set; }
    
        /// <summary>The name of the shared memory &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_upstream_module.html#zone"&gt;zone&lt;/a&gt; that keeps the group’s configuration and run-time state.</summary>
        [Newtonsoft.Json.JsonProperty("zone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamUpstream FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamUpstream>(data);
        }
    
    }
}