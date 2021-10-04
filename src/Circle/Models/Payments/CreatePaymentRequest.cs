using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Payments
{
    public class CreatePaymentRequest
    {
        [JsonProperty("idempotencyKey")] public string IdempotencyKey { get; internal set; }
        [JsonProperty("keyId")] public string KeyId { get; internal set; }
        [JsonProperty("metadata")] public Metadata Metadata { get; internal set; }
        [JsonProperty("amount")] public PaymentAmount Amount { get; internal set; }
        [JsonProperty("autoCapture")] public bool AutoCapture { get; internal set; }
        [JsonProperty("verification")] public string Verification { get; internal set; }
        [JsonProperty("source")] public PaymentSource Source { get; internal set; }
        [JsonProperty("description")] public string Description { get; internal set; }
        [JsonProperty("encryptedData")] public string EncryptedData { get; internal set; }
    }
}