namespace NginxCSharp
{
    /// <summary>Status data for all HTTP
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_limit_conn_module.html#limit_conn_zone"&gt;limit_conn zones&lt;/a&gt;.
    /// </summary>
    
    public partial class HTTPLimitConnZonesMap : System.Collections.Generic.Dictionary<string, HTTPLimitConnZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPLimitConnZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLimitConnZonesMap>(data);
        }
    
    }
}