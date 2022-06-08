using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Payouts
{
    [DataContract]
    public class PayoutMetadata
    {

        [JsonProperty("beneficiaryEmail"), DataMember(Order = 1)]
        public string BeneficiaryEmail { get; set; }
    }
}