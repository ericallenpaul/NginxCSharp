namespace NginxCSharp
{
    /// <summary>Status data for all HTTP
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_limit_req_module.html#limit_req_zone"&gt;limit_req zones&lt;/a&gt;.
    /// </summary>
    
    public partial class HTTPLimitReqZonesMap : System.Collections.Generic.Dictionary<string, HTTPLimitReqZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPLimitReqZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLimitReqZonesMap>(data);
        }
    
    }
}