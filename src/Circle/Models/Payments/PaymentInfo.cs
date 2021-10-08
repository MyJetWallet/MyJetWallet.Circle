using System.Runtime.Serialization;
using MyJetWallet.Circle.Converters;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Payments
{
    [DataContract]
    public class PaymentInfo
    {
        [JsonProperty("id"), DataMember(Order = 1)]
        public string Id { get; internal set; }

        [JsonProperty("type"), DataMember(Order = 2)]
        public string Type { get; internal set; }

        [JsonProperty("merchantId"), DataMember(Order = 3)]
        public string MerchantId { get; internal set; }

        [JsonProperty("merchantWalletId"), DataMember(Order = 4)]
        public string MerchantWalletId { get; internal set; }

        [JsonProperty("amount"), DataMember(Order = 5)]
        public PaymentAmount Amount { get; internal set; }

        [JsonProperty("source"), DataMember(Order = 6)]
        public PaymentSource Source { get; internal set; }

        [JsonProperty("description"), DataMember(Order = 7)]
        public string Description { get; internal set; }

        [JsonProperty("status"), JsonConverter(typeof(PaymentStatusConverter)), DataMember(Order = 8)]
        public PaymentStatus Status { get; internal set; }

        [JsonProperty("captured"), DataMember(Order = 9)]
        public bool Captured { get; internal set; }

        [JsonProperty("captureAmount"), DataMember(Order = 10)]
        public PaymentAmount CaptureAmount { get; internal set; }

        [JsonProperty("captureDate"), DataMember(Order = 11)]
        public string CaptureDate { get; internal set; }

        [JsonProperty("fees"), DataMember(Order = 12)]
        public PaymentAmount Fees { get; internal set; }

        [JsonProperty("trackingRef"), DataMember(Order = 13)]
        public string TrackingRef { get; internal set; }

        [JsonProperty("errorCode"), JsonConverter(typeof(PaymentErrorCodeConverter)), DataMember(Order = 14)]
        public PaymentErrorCode? ErrorCode { get; internal set; }

        [JsonProperty("metadata"), DataMember(Order = 15)]
        public Metadata Metadata { get; internal set; }

        [JsonProperty("riskEvaluation"), DataMember(Order = 16)]
        public RiskEvaluation RiskEvaluation { get; internal set; }

        [JsonProperty("createDate"), DataMember(Order = 17)]
        public string CreateDate { get; internal set; }

        [JsonProperty("updateDate"), DataMember(Order = 18)]
        public string UpdateDate { get; internal set; }
    }
}