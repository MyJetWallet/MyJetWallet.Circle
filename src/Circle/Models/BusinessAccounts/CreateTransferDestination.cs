using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Payments
{
    [DataContract]
    public class CreateTransferDestination
    {
        [JsonProperty("type"), DataMember(Order =1)]
        public string Type { get; set; }

        [JsonProperty("addressId"), DataMember(Order = 2)]
        public string AddressId { get; set; }
    }
}