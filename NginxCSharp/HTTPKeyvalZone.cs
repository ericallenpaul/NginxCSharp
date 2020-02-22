namespace NginxCSharp
{
    /// <summary>Contents of an HTTP keyval shared memory zone
    /// when using the GET method.
    /// </summary>
    
    public partial class HTTPKeyvalZone 
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static HTTPKeyvalZone FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPKeyvalZone>(data);
        }
    
    }
}