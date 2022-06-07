﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Payouts
{
    [DataContract]
    public class PayoutInfo
    {
        [JsonProperty("id"), DataMember(Order = 1)]
        public string Id { get; set; }

        [JsonProperty("sourceWalletId"), DataMember(Order = 2)]
        public string SourceWalletId { get; set; }

        [JsonProperty("createDate"), DataMember(Order = 3)]
        public DateTime CreateDate { get; set; }

        [JsonProperty("updateDate"), DataMember(Order = 4)]
        public DateTime UpdateDate { get; set; }

        [JsonProperty("destination"), DataMember(Order = 5)]
        public PayoutDestination Destination { get; set; }

        [JsonProperty("amount"), DataMember(Order = 6)]
        public PayoutAmount Amount { get; set; }

        [JsonProperty("status"), DataMember(Order = 7)]
        public PayoutStatus Status { get; set; }

        [JsonProperty("trackingRef"), DataMember(Order = 8)]
        public string TrackingRef { get; set; }

        [JsonProperty("error"), DataMember(Order = 9)]
        public PayoutErrorCode Error { get; set; }

        [JsonProperty("riskEvaluation"), DataMember(Order = 10)]
        public RiskEvaluation RiskEvaluation { get; set; }

        [JsonProperty("adjustments"), DataMember(Order = 11)]
        public PayoutAdjustments Adjustments { get; set; }

    }
}