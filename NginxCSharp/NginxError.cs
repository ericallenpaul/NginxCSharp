namespace NginxCSharp
{
    /// <summary>nginx error object.
    /// </summary>
    
    public partial class NginxError 
    {
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }
    
        /// <summary>The ID of the request, equals the value of the &lt;a href="https://nginx.org/en/docs/http/ngx_http_core_module.html#var_request_id"&gt;$request_id&lt;/a&gt; variable.</summary>
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Request_id { get; set; }
    
        /// <summary>Link to reference documentation.</summary>
        [Newtonsoft.Json.JsonProperty("href", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Href { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static NginxError FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<NginxError>(data);
        }
    
    }
}