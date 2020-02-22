namespace NginxCSharp
{
    public partial class HTTPLocationZone 
    {
        /// <summary>The total number of client requests received from clients.</summary>
        [Newtonsoft.Json.JsonProperty("requests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Requests { get; set; }
    
        /// <summary>The total number of responses sent to clients and the number of responses with status codes “&lt;code&gt;1xx&lt;/code&gt;”, “&lt;code&gt;2xx&lt;/code&gt;”, “&lt;code&gt;3xx&lt;/code&gt;”, “&lt;code&gt;4xx&lt;/code&gt;”, and “&lt;code&gt;5xx&lt;/code&gt;”.</summary>
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Responses2 Responses { get; set; }
    
        /// <summary>The total number of requests completed without sending a response.</summary>
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
    
        public static HTTPLocationZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLocationZone>(data);
        }
    
    }
}