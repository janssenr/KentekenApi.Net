using System.Collections.Generic;
using System.Runtime.Serialization;
using KentekenApi.Net.Rdw.Model;

namespace KentekenApi.Net.Rdw.Wrappers
{
    [DataContract]
    public class ResultWrapper
    {
        public List<KentekenView> Kentekens { get; set; }
    }
}
