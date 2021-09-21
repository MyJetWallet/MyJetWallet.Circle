using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Cards
{
    public class CardRiskEvaluation
    {
        [JsonProperty("decision")] public string Decision { get; internal set; }
        [JsonProperty("reason")] public string Reason { get; internal set; }
    }
}