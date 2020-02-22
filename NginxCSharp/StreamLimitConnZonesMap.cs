namespace NginxCSharp
{
    /// <summary>Status data for all stream
    /// &lt;a href="https://nginx.org/en/docs/stream/ngx_stream_limit_conn_module.html#limit_conn_zone"&gt;limit_conn zones&lt;/a&gt;.
    /// </summary>
    
    public partial class StreamLimitConnZonesMap : System.Collections.Generic.Dictionary<string, StreamLimitConnZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamLimitConnZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamLimitConnZonesMap>(data);
        }
    
    }
}