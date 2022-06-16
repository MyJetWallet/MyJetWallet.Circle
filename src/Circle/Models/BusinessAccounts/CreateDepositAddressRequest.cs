using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Payments
{
    public class CreateDepositAddressRequest
    {
        [JsonProperty("idempotencyKey")] public string IdempotencyKey { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
        [JsonProperty("chain")] public string Chain { get; set; }
    }
    
}