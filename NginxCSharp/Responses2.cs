namespace NginxCSharp
{
    public partial class Responses2 
    {
        /// <summary>The number of responses with “&lt;code&gt;1xx&lt;/code&gt;” status codes.</summary>
        [Newtonsoft.Json.JsonProperty("1xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _1xx { get; set; }
    
        /// <summary>The number of responses with “&lt;code&gt;2xx&lt;/code&gt;” status codes.</summary>
        [Newtonsoft.Json.JsonProperty("2xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _2xx { get; set; }
    
        /// <summary>The number of responses with “&lt;code&gt;3xx&lt;/code&gt;” status codes.</summary>
        [Newtonsoft.Json.JsonProperty("3xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _3xx { get; set; }
    
        /// <summary>The number of responses with “&lt;code&gt;4xx&lt;/code&gt;” status codes.</summary>
        [Newtonsoft.Json.JsonProperty("4xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _4xx { get; set; }
    
        /// <summary>The number of responses with “&lt;code&gt;5xx&lt;/code&gt;” status codes.</summary>
        [Newtonsoft.Json.JsonProperty("5xx", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? _5xx { get; set; }
    
        /// <summary>The total number of responses sent to clients.</summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Responses2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Responses2>(data);
        }
    
    }
}