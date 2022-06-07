using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Payouts
{
    [DataContract]
    public class RiskEvaluation
    {
        [JsonProperty("decision"), DataMember(Order = 1)]
        public RiskEvaluationType Decision { get; set; }

        [JsonProperty("reason"), DataMember(Order = 2)]
        public string Reason { get; set; }
    }
}