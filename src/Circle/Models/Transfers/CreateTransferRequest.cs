using MyJetWallet.Circle.Models.Payouts;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Transfers
{
    public class CreateTransferRequest
    {
        [JsonProperty("idempotencyKey")] public string IdempotencyKey { get; set; }
        [JsonProperty("source")] public TransferSource Source { get; set; }

        [JsonProperty("destination")] public TransferDestination Destination { get; set; }
        [JsonProperty("amount")] public CircleAmount Amount { get; set; }
    }
}