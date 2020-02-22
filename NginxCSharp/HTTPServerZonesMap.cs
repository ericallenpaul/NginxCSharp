namespace NginxCSharp
{
    /// <summary>Status data for all HTTP
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_api_module.html#status_zone"&gt;status zones&lt;/a&gt;.
    /// </summary>
    
    public partial class HTTPServerZonesMap : System.Collections.Generic.Dictionary<string, HTTPServerZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPServerZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPServerZonesMap>(data);
        }
    
    }
}