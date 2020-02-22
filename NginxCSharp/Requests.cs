namespace NginxCSharp
{
    public partial class Requests 
    {
        /// <summary>The total number of requests to resolve names to addresses.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Name { get; set; }
    
        /// <summary>The total number of requests to resolve SRV records.</summary>
        [Newtonsoft.Json.JsonProperty("srv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Srv { get; set; }
    
        /// <summary>The total number of requests to resolve addresses to names.</summary>
        [Newtonsoft.Json.JsonProperty("addr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Addr { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Requests FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Requests>(data);
        }
    
    }
}