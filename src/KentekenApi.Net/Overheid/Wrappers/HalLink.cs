using System;
using System.Runtime.Serialization;

namespace KentekenApi.Net.Overheid.Wrappers
{
    [DataContract]
    public class HalLink
    {
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public Uri Href { get; set; }

        public override string ToString()
        {
            return Href.ToString();
        }
    }
}
