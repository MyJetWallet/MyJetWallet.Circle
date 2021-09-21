using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Cards
{
    public class CardMetadata
    {
        [JsonProperty("email")] public string Email { get; internal set; }
        [JsonProperty("phoneNumber")] public string PhoneNumber { get; internal set; }
        [JsonProperty("sessionId")] public string SessionId { get; internal set; }
        [JsonProperty("ipAddress")] public string IpAddress { get; internal set; }
    }
}