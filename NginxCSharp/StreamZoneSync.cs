namespace NginxCSharp
{
    public partial class StreamZoneSync 
    {
        /// <summary>Synchronization information per each shared memory zone.</summary>
        [Newtonsoft.Json.JsonProperty("zones", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, StreamZoneSyncZone> Zones { get; set; }
    
        /// <summary>Synchronization information per node in a cluster.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Status Status { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamZoneSync FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamZoneSync>(data);
        }
    
    }
}