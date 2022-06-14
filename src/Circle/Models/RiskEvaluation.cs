using MyJetWallet.Circle.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models
{
    [DataContract]
    public class RiskEvaluation
    {
        [JsonProperty("decision"), DataMember(Order = 1)]
        [JsonConverter(typeof(RiskEvaluationTypeConverter))]
        public RiskEvaluationType Decision { get; set; }

        [JsonProperty("reason"), DataMember(Order = 2)]
        public string Reason { get; set; }
    }
}