namespace NginxCSharp
{
    /// <summary>Status information for all stream
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_api_module.html#status_zone"&gt;status zones&lt;/a&gt;.
    /// </summary>
    
    public partial class StreamServerZonesMap : System.Collections.Generic.Dictionary<string, StreamServerZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamServerZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamServerZonesMap>(data);
        }
    
    }
}