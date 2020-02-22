namespace NginxCSharp
{
    /// <summary>An array of strings.
    /// </summary>
    public partial class ArrayOfStrings : System.Collections.ObjectModel.Collection<string>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static ArrayOfStrings FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ArrayOfStrings>(data);
        }
    
    }
}