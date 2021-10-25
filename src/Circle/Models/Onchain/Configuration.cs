using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Onchain
{
    [DataContract]
    public class Configuration
    {
        [JsonProperty("payments"), DataMember(Order = 1)]
        public PaymentsConfiguration PaymentsConfiguration { get; internal set; }
    }
}