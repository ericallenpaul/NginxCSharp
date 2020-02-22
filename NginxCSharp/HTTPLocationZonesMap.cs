namespace NginxCSharp
{
    /// <summary>Status data for all HTTP
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_api_module.html#status_zone"&gt;location zones&lt;/a&gt;.
    /// </summary>
    
    public partial class HTTPLocationZonesMap : System.Collections.Generic.Dictionary<string, HTTPLocationZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPLocationZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLocationZonesMap>(data);
        }
    
    }
}