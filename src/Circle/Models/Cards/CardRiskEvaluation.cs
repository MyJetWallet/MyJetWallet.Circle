using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Cards
{
    [DataContract]
    public class CardRiskEvaluation
    {
        [JsonProperty("decision"), DataMember(Order = 1)]
        public string Decision { get; internal set; }

        [JsonProperty("reason"), DataMember(Order = 2)]
        public string Reason { get; internal set; }
    }
}