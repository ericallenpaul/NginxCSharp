namespace NginxCSharp
{
    /// <summary>Status data for all
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_core_module.html#resolver_status_zone"&gt;resolver zones&lt;/a&gt;.
    /// </summary>
    
    public partial class ResolverZonesMap : System.Collections.Generic.Dictionary<string, ResolverZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static ResolverZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResolverZonesMap>(data);
        }
    
    }
}