namespace NginxCSharp
{
    public partial class HTTPCache 
    {
        /// <summary>The current size of the cache.</summary>
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Size { get; set; }
    
        /// <summary>The limit on the maximum size of the cache specified in the configuration.</summary>
        [Newtonsoft.Json.JsonProperty("max_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Max_size { get; set; }
    
        /// <summary>A boolean value indicating whether the “cache loader” process is still loading data from disk into the cache.</summary>
        [Newtonsoft.Json.JsonProperty("cold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Cold { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Hit Hit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stale", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Stale Stale { get; set; }
    
        [Newtonsoft.Json.JsonProperty("updating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Updating Updating { get; set; }
    
        [Newtonsoft.Json.JsonProperty("revalidated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Revalidated Revalidated { get; set; }
    
        [Newtonsoft.Json.JsonProperty("miss", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Miss Miss { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expired", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Expired Expired { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bypass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Bypass Bypass { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPCache FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPCache>(data);
        }
    
    }
}