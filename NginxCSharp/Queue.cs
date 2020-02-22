namespace NginxCSharp
{
    public partial class Queue 
    {
        /// <summary>The current number of requests in the queue.</summary>
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Size { get; set; }
    
        /// <summary>The maximum number of requests that can be in the queue at the same time.</summary>
        [Newtonsoft.Json.JsonProperty("max_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Max_size { get; set; }
    
        /// <summary>The total number of requests rejected due to the queue overflow.</summary>
        [Newtonsoft.Json.JsonProperty("overflows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Overflows { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Queue FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Queue>(data);
        }
    
    }
}