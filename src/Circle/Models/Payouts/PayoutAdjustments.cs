using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Payouts
{
    [DataContract]
    public class PayoutAdjustments
    {
        [JsonProperty("fxCredit"), DataMember(Order = 1)]
        public PayoutAmount FxCredit { get; set; }

        [JsonProperty("fxDebit"), DataMember(Order = 2)]
        public PayoutAmount FxDebit { get; set; }
    }
}