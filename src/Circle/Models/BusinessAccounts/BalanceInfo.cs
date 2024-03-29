﻿#nullable enable
using System.Runtime.Serialization;
using MyJetWallet.Circle.Models.Payouts;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.BusinessAccounts
{
    [DataContract]
    public class BalanceInfo
    {
        [JsonProperty("available"), DataMember(Order = 1)]
        public CircleAmount[] Available { get; set; }

        [JsonProperty("unsettled"), DataMember(Order = 2)]
        public CircleAmount[] Unsettled { get; set; }
    }
}