using MyJetWallet.Circle.Models.Payouts;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Payments
{
    public class CreateTransferRequest
    {
        [JsonProperty("idempotencyKey")] public string IdempotencyKey { get; set; }
        [JsonProperty("amount")] public CircleAmount Amount { get; set; }

        [JsonProperty("destination")] public CreateTransferDestination Destination { get; set; }
    }
}