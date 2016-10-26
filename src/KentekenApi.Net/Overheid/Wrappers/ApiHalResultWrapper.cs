using System.Runtime.Serialization;

namespace KentekenApi.Net.Overheid.Wrappers
{
    [DataContract]
    public class ApiHalResultWrapper
    {
        [DataMember(Name = "totalItemCount", EmitDefaultValue = false)]
        public int TotalItemCount { get; set; }

        [DataMember(Name = "pageCount", EmitDefaultValue = false)]
        public int PageCount { get; set; }

        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public HalNavigator Links { get; set; }

        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        public HalEmbeddedResult Embedded { get; set; }
    }
}
