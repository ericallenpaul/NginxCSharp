namespace NginxCSharp
{
    /// <summary>Status information of stream upstream server groups.</summary>
    
    public partial class StreamUpstreamMap : System.Collections.Generic.Dictionary<string, StreamUpstream>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamUpstreamMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamUpstreamMap>(data);
        }
    
    }
}