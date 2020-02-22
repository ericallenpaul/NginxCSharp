namespace NginxCSharp
{
    /// <summary>Contents of a stream keyval shared memory zone
    /// when using the POST or PATCH methods.
    /// </summary>
    
    public partial class StreamKeyvalZonePostPatch 
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StreamKeyvalZonePostPatch FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamKeyvalZonePostPatch>(data);
        }
    
    }
}