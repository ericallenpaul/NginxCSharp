namespace NginxCSharp
{
    /// <summary>Array of stream upstream servers.</summary>
    
    public partial class StreamUpstreamPeerMap : System.Collections.ObjectModel.Collection<StreamUpstreamPeer>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamUpstreamPeerMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamUpstreamPeerMap>(data);
        }
    
    }
}