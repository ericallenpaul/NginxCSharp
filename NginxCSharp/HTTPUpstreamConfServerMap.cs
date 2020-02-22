namespace NginxCSharp
{
    /// <summary>An array of HTTP upstream servers for dynamic configuration.</summary>
    
    public partial class HTTPUpstreamConfServerMap : System.Collections.ObjectModel.Collection<HTTPUpstreamConfServer>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPUpstreamConfServerMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPUpstreamConfServerMap>(data);
        }
    
    }
}