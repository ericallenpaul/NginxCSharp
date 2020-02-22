﻿namespace NginxCSharp
{
    public partial class Expired 
    {
        /// <summary>The total number of expired responses not taken from the cache.</summary>
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Responses { get; set; }
    
        /// <summary>The total number of bytes read from the proxied server.</summary>
        [Newtonsoft.Json.JsonProperty("bytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes { get; set; }
    
        /// <summary>The total number of responses written to the cache.</summary>
        [Newtonsoft.Json.JsonProperty("responses_written", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Responses_written { get; set; }
    
        /// <summary>The total number of bytes written to the cache.</summary>
        [Newtonsoft.Json.JsonProperty("bytes_written", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bytes_written { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Expired FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Expired>(data);
        }
    
    }
}