using System.Runtime.Serialization;

namespace KentekenApi.Net.Rdw
{
    [DataContract]
    public class CouldNotParseResponseException
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
    }
}
