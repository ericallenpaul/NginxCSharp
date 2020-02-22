namespace NginxCSharp
{
    public partial class Status 
    {
        /// <summary>The number of bytes received by this node.</summary>
        [Newtonsoft.Json.JsonProperty("bytes_in", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes_in { get; set; }
    
        /// <summary>The number of messages received by this node.</summary>
        [Newtonsoft.Json.JsonProperty("msgs_in", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Msgs_in { get; set; }
    
        /// <summary>The number of messages sent by this node.</summary>
        [Newtonsoft.Json.JsonProperty("msgs_out", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Msgs_out { get; set; }
    
        /// <summary>The number of bytes sent by this node.</summary>
        [Newtonsoft.Json.JsonProperty("bytes_out", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes_out { get; set; }
    
        /// <summary>The number of peers this node is connected to.</summary>
        [Newtonsoft.Json.JsonProperty("nodes_online", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Nodes_online { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Status FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(data);
        }
    
    }
}