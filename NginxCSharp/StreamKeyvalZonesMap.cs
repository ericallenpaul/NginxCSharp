namespace NginxCSharp
{
    /// <summary>Contents of all stream keyval shared memory zones.
    /// </summary>
    
    public partial class StreamKeyvalZonesMap : System.Collections.Generic.Dictionary<string, StreamKeyvalZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamKeyvalZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamKeyvalZonesMap>(data);
        }
    
    }
}