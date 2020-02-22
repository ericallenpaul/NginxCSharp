namespace NginxCSharp
{
    public partial class Responses4 
    {
        /// <summary>The total number of successful responses.</summary>
        [Newtonsoft.Json.JsonProperty("noerror", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Noerror { get; set; }
    
        /// <summary>The total number of FORMERR (&lt;literal&gt;Format error&lt;/literal&gt;) responses.</summary>
        [Newtonsoft.Json.JsonProperty("formerr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Formerr { get; set; }
    
        /// <summary>The total number of SERVFAIL (&lt;literal&gt;Server failure&lt;/literal&gt;) responses.</summary>
        [Newtonsoft.Json.JsonProperty("servfail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Servfail { get; set; }
    
        /// <summary>The total number of NXDOMAIN (&lt;literal&gt;Host not found&lt;/literal&gt;) responses.</summary>
        [Newtonsoft.Json.JsonProperty("nxdomain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Nxdomain { get; set; }
    
        /// <summary>The total number of NOTIMP (&lt;literal&gt;Unimplemented&lt;/literal&gt;) responses.</summary>
        [Newtonsoft.Json.JsonProperty("notimp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Notimp { get; set; }
    
        /// <summary>The total number of REFUSED (&lt;literal&gt;Operation refused&lt;/literal&gt;) responses.</summary>
        [Newtonsoft.Json.JsonProperty("refused", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Refused { get; set; }
    
        /// <summary>The total number of timed out requests.</summary>
        [Newtonsoft.Json.JsonProperty("timedout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Timedout { get; set; }
    
        /// <summary>The total number of requests completed with an unknown error.</summary>
        [Newtonsoft.Json.JsonProperty("unknown", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Unknown { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Responses4 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Responses4>(data);
        }
    
    }
}