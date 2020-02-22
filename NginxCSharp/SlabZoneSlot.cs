namespace NginxCSharp
{
    public partial class SlabZoneSlot 
    {
        /// <summary>The current number of used memory slots.</summary>
        [Newtonsoft.Json.JsonProperty("used", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Used { get; set; }
    
        /// <summary>The current number of free memory slots.</summary>
        [Newtonsoft.Json.JsonProperty("free", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Free { get; set; }
    
        /// <summary>The total number of attempts to allocate memory of specified size.</summary>
        [Newtonsoft.Json.JsonProperty("reqs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Reqs { get; set; }
    
        /// <summary>The number of unsuccessful attempts to allocate memory of specified size.</summary>
        [Newtonsoft.Json.JsonProperty("fails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Fails { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static SlabZoneSlot FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SlabZoneSlot>(data);
        }
    
    }
}