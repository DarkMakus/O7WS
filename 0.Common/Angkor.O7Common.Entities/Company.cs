using System.Runtime.Serialization;

namespace Angkor.O7Common.Entities
{
    [DataContract]
    public class Company
    {
        [DataMember] public Branch[] Branches { get; set; }
        [DataMember] public string Id { get; set; }
        [DataMember] public string Description { get; set; }
    }
}