namespace NginxCSharp
{
    /// <summary>Status zones that use slab allocator.
    /// </summary>
    
    public partial class SlabZoneMap : System.Collections.Generic.Dictionary<string, SlabZone>
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static SlabZoneMap FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SlabZoneMap>(data);
        }
    
    }
}