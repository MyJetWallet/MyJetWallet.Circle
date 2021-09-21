using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Cards
{
    public class CardVerification
    {
        [JsonProperty("avs")] public string Avs { get; internal set; }
        [JsonProperty("cvv")] public string Cvv { get; internal set; }
    }
}