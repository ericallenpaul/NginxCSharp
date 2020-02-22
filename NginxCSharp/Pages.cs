namespace NginxCSharp
{
    public partial class Pages 
    {
        /// <summary>The current number of used memory pages.</summary>
        [Newtonsoft.Json.JsonProperty("used", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Used { get; set; }
    
        /// <summary>The current number of free memory pages.</summary>
        [Newtonsoft.Json.JsonProperty("free", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Free { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Pages FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Pages>(data);
        }
    
    }
}