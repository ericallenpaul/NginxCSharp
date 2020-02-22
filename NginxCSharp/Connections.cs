namespace NginxCSharp
{
    /// <summary>The number of accepted, dropped, active, and idle connections.
    /// </summary>
    
    public partial class Connections 
    {
        /// <summary>The total number of accepted client connections.</summary>
        [Newtonsoft.Json.JsonProperty("accepted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Accepted { get; set; }
    
        /// <summary>The total number of dropped client connections.</summary>
        [Newtonsoft.Json.JsonProperty("dropped", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Dropped { get; set; }
    
        /// <summary>The current number of active client connections.</summary>
        [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Active { get; set; }
    
        /// <summary>The current number of idle client connections.</summary>
        [Newtonsoft.Json.JsonProperty("idle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Idle { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Connections FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Connections>(data);
        }
    
    }
}