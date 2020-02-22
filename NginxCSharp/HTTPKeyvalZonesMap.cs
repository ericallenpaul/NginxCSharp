namespace NginxCSharp
{
    /// <summary>Contents of all HTTP keyval shared memory zones.
    /// </summary>
    
    public partial class HTTPKeyvalZonesMap : System.Collections.Generic.Dictionary<string, HTTPKeyvalZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPKeyvalZonesMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPKeyvalZonesMap>(data);
        }
    
    }
}