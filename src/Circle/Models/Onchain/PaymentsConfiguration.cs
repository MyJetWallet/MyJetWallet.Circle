using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Onchain
{
    [DataContract]
    public class PaymentsConfiguration
    {
        [JsonProperty("masterWalletId"), DataMember(Order = 1)]
        public string MasterWalletId { get; internal set; }
    }
}