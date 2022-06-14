#nullable enable
using System.Runtime.Serialization;
using MyJetWallet.Circle.Converters;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.BusinessAccounts
{
    [DataContract]
    public class ConfigurationInfo
    {
        [JsonProperty("payments"), DataMember(Order = 1)]
        public ConfigurationPaymentsInfo Payments { get; set; }
    }
}