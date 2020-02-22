namespace NginxCSharp
{
    /// <summary>Contents of an HTTP keyval shared memory zone
    /// when using the POST or PATCH methods.
    /// </summary>
    
    public partial class HTTPKeyvalZonePostPatch 
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPKeyvalZonePostPatch FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPKeyvalZonePostPatch>(data);
        }
    
    }
}