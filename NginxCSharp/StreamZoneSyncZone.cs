namespace NginxCSharp
{
    /// <summary>Synchronization status of a shared memory zone.</summary>
    
    public partial class StreamZoneSyncZone 
    {
        /// <summary>The number of records that need to be sent to the cluster.</summary>
        [Newtonsoft.Json.JsonProperty("records_pending", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Records_pending { get; set; }
    
        /// <summary>The total number of records stored in the shared memory zone.</summary>
        [Newtonsoft.Json.JsonProperty("records_total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Records_total { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamZoneSyncZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamZoneSyncZone>(data);
        }
    
    }
}