﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Payments
{
    [DataContract]
    public class RequiredAction
    {
        [JsonProperty("type"), DataMember(Order = 1)]
        public string Type { get; set; }

        [JsonProperty("redirectUrl"), DataMember(Order = 2)]
        public string RedirectUrl { get; set; }
    }
}