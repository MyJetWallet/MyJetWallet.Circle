using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Cards
{
    public class CardBillingDetails
    {
        [JsonProperty("name")] public string Name { get; internal set; }
        [JsonProperty("city")] public string City { get; internal set; }
        [JsonProperty("country")] public string Country { get; internal set; }
        [JsonProperty("line1")] public string Line1 { get; internal set; }
        [JsonProperty("line2")] public string Line2 { get; internal set; }
        [JsonProperty("district")] public string District { get; internal set; }
        [JsonProperty("postalCode")] public string PostalCode { get; internal set; }
    }
}