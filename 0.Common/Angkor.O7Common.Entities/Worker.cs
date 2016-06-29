using System.Runtime.Serialization;

namespace Angkor.O7Common.Entities
{
    [DataContract]
    public class Worker
    {        
        [DataMember] public string Id { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public string Active { get; set; }
    }
}