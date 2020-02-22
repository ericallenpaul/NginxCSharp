namespace NginxCSharp
{
    public partial class SlabZone 
    {
        /// <summary>The number of free and used memory pages.</summary>
        [Newtonsoft.Json.JsonProperty("pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pages Pages { get; set; }
    
        /// <summary>Status data for memory slots (8, 16, 32, 64, 128, etc.)</summary>
        [Newtonsoft.Json.JsonProperty("slots", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, SlabZoneSlot> Slots { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static SlabZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SlabZone>(data);
        }
    
    }
}