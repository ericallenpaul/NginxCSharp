namespace NginxCSharp
{
    public partial class StreamServerZone 
    {
        /// <summary>The number of client connections that are currently being processed.</summary>
        [Newtonsoft.Json.JsonProperty("processing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Processing { get; set; }
    
        /// <summary>The total number of connections accepted from clients.</summary>
        [Newtonsoft.Json.JsonProperty("connections", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Connections { get; set; }
    
        /// <summary>The total number of completed sessions, and the number of sessions completed with status codes “&lt;code&gt;2xx&lt;/code&gt;”, “&lt;code&gt;4xx&lt;/code&gt;”, or “&lt;code&gt;5xx&lt;/code&gt;”.</summary>
        [Newtonsoft.Json.JsonProperty("sessions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Sessions Sessions { get; set; }
    
        /// <summary>The total number of connections completed without creating a session.</summary>
        [Newtonsoft.Json.JsonProperty("discarded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Discarded { get; set; }
    
        /// <summary>The total number of bytes received from clients.</summary>
        [Newtonsoft.Json.JsonProperty("received", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Received { get; set; }
    
        /// <summary>The total number of bytes sent to clients.</summary>
        [Newtonsoft.Json.JsonProperty("sent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Sent { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamServerZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamServerZone>(data);
        }
    
    }
}