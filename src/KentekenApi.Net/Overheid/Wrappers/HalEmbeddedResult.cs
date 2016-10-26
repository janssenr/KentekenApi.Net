using System.Collections.Generic;
using System.Runtime.Serialization;
using KentekenApi.Net.Overheid.Model;

namespace KentekenApi.Net.Overheid.Wrappers
{
    [DataContract]
    public sealed class HalEmbeddedResult
    {
        [DataMember(Name = "kenteken", EmitDefaultValue = false)]
        public List<KentekenView> Kenteken { get; set; }
    }
}
