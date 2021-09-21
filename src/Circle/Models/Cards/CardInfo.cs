using MyJetWallet.Circle.Converters;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Cards
{
    public class CardInfo
    {
        [JsonProperty("id")] public string Id { get; internal set; }

        [JsonProperty("status"), JsonConverter(typeof(CardStatusConverter))]
        public string Status { get; internal set; }

        [JsonProperty("billingDetails")] public CardBillingDetails BillingDetails { get; internal set; }
        [JsonProperty("expMonth")] public int ExpMonth { get; internal set; }
        [JsonProperty("expYear")] public int ExpYear { get; internal set; }
        [JsonProperty("network")] public string Network { get; internal set; }
        [JsonProperty("last4")] public string Last4 { get; internal set; }
        [JsonProperty("bin")] public string Bin { get; internal set; }
        [JsonProperty("issuerCountry")] public string IssuerCountry { get; internal set; }

        [JsonProperty("fundingType"), JsonConverter(typeof(CardFundingTypeConverter))]
        public CardFundingType FundingType { get; internal set; }

        [JsonProperty("fingerprint")] public string Fingerprint { get; internal set; }

        [JsonProperty("errorCode"), JsonConverter(typeof(CardVerificationErrorConverter))]
        public CardVerificationError ErrorCode { get; internal set; }

        [JsonProperty("verification")] public CardVerification Verification { get; internal set; }
        [JsonProperty("riskEvaluation")] public CardRiskEvaluation RiskEvaluation { get; internal set; }
        [JsonProperty("metadata")] public CardMetadata Metadata { get; internal set; }
        [JsonProperty("createDate")] public string CreateDate { get; internal set; }
        [JsonProperty("updateDate")] public string UpdateDate { get; internal set; }
    }
}