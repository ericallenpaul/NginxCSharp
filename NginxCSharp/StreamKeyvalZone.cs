namespace NginxCSharp
{
    /// <summary>Contents of a stream keyval shared memory zone when using the GET method.
    /// </summary>
    
    public partial class StreamKeyvalZone 
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamKeyvalZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamKeyvalZone>(data);
        }
    
    }
}