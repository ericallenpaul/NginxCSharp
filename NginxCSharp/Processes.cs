namespace NginxCSharp
{
    public partial class Processes 
    {
        /// <summary>The total number of abnormally terminated and respawned child processes.</summary>
        [Newtonsoft.Json.JsonProperty("respawned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Respawned { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Processes FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Processes>(data);
        }
    
    }
}