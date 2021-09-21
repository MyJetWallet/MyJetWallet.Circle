using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Cards
{
    public class CreateCardRequest
    {
        [JsonProperty("idempotencyKey")] public string IdempotencyKey { get; internal set; }
        [JsonProperty("keyId")] public string KeyId { get; internal set; }
        [JsonProperty("encryptedData")] public string EncryptedData { get; internal set; }
        [JsonProperty("billingDetails")] public CardBillingDetails BillingDetails { get; internal set; }
        [JsonProperty("expMonth")] public int ExpMonth { get; internal set; }
        [JsonProperty("expYear")] public int ExpYear { get; internal set; }
        [JsonProperty("metadata")] public CardMetadata Metadata { get; internal set; }
    }
}