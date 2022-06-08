using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Payouts
{
    public class CreatePayoutRequest
    {
        [JsonProperty("idempotencyKey")] public string IdempotencyKey { get; set; }
        [JsonProperty("metadata")] public PayoutMetadata Metadata { get; set; }
        [JsonProperty("amount")] public PayoutAmount Amount { get; set; }
        [JsonProperty("source")] public PayoutSource Source { get; set; }
        [JsonProperty("destination")] public PayoutDestination Destination { get; set; }
    }
}