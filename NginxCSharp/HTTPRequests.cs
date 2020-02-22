namespace NginxCSharp
{
    public partial class HTTPRequests 
    {
        /// <summary>The total number of client requests.</summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total { get; set; }
    
        /// <summary>The current number of client requests.</summary>
        [Newtonsoft.Json.JsonProperty("current", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Current { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPRequests FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPRequests>(data);
        }
    
    }
}