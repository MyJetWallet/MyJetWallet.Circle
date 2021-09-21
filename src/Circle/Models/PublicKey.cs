﻿using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models
{
    public class PublicKey
    {
        [JsonProperty("keyId")] public string KeyId { get; internal set; }
        [JsonProperty("publicKey")] public string RsaPublicKey { get; internal set; }
    }
}