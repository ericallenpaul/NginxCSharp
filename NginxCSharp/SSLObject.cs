namespace NginxCSharp
{
    public partial class SSLObject 
    {
        /// <summary>The total number of successful SSL handshakes.</summary>
        [Newtonsoft.Json.JsonProperty("handshakes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Handshakes { get; set; }
    
        /// <summary>The total number of failed SSL handshakes.</summary>
        [Newtonsoft.Json.JsonProperty("handshakes_failed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Handshakes_failed { get; set; }
    
        /// <summary>The total number of session reuses during SSL handshake.</summary>
        [Newtonsoft.Json.JsonProperty("session_reuses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Session_reuses { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static SSLObject FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SSLObject>(data);
        }
    
    }
}