using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Wallets
{
    public class CreateWalletRequest
    {
        [JsonProperty("idempotencyKey")] public string IdempotencyKey { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
    }
}