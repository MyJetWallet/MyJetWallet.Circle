using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models
{
    [DataContract]
    public class RiskEvaluation
    {
        [JsonProperty("decision"), DataMember(Order = 1)]
        public string Decision { get; internal set; }

        [JsonProperty("reason"), DataMember(Order = 2)]
        public string Reason { get; internal set; }
    }
}