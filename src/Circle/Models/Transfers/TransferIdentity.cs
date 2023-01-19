using System.Runtime.Serialization;
using MyJetWallet.Circle.Converters;
using Newtonsoft.Json;

namespace MyJetWallet.Circle.Models.Transfers
{
    [DataContract]
    public class TransferIdentity
    {
        [JsonProperty("type"), DataMember(Order = 1)]
        [JsonConverter(typeof(IdentityTypeConverter))]
        public IdentityType Type { get; set; }

        [JsonProperty("name"), DataMember(Order = 2)]
        public string Name { get; set; }

        [JsonProperty("addresses"), DataMember(Order = 3)]
        public Address[] Addresses { get; set; } //https://developers.circle.com/docs/travel-rule-on-chain

    }
    
    
    
}