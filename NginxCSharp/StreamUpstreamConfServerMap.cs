namespace NginxCSharp
{
    /// <summary>An array of stream upstream servers for dynamic configuration.
    /// </summary>
    
    public partial class StreamUpstreamConfServerMap : System.Collections.ObjectModel.Collection<StreamUpstreamConfServer>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamUpstreamConfServerMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamUpstreamConfServerMap>(data);
        }
    
    }
}