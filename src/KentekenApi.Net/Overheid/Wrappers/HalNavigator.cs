using System.Runtime.Serialization;

namespace KentekenApi.Net.Overheid.Wrappers
{
    [DataContract]
    public class HalNavigator
    {
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public HalLink Self { get; set; }

        [DataMember(Name = "next", EmitDefaultValue = false)]
        public HalLink Next { get; set; }

        [DataMember(Name = "first", EmitDefaultValue = false)]
        public HalLink First { get; set; }

        [DataMember(Name = "last", EmitDefaultValue = false)]
        public HalLink Last { get; set; }
    }
}
