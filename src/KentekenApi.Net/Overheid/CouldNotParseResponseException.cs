using System.Runtime.Serialization;

namespace KentekenApi.Net.Overheid
{
    [DataContract]
    public class CouldNotParseResponseException
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
    }
}
