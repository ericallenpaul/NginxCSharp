namespace NginxCSharp
{
    /// <summary>An array of HTTP
    /// &lt;a href="https://nginx.org/en/docs/http/ngx_http_upstream_module.html#upstream"&gt;upstream servers&lt;/a&gt;.
    /// </summary>
    
    public partial class HTTPUpstreamPeerMap : System.Collections.ObjectModel.Collection<HTTPUpstreamPeer>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPUpstreamPeerMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPUpstreamPeerMap>(data);
        }
    
    }
}