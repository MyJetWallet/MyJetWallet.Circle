using MyJetWallet.Circle.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyJetWallet.Circle.Models.BusinessAccounts
{
    [DataContract]
    public class TransferInfo
    {
        [DataMember(Order = 1), JsonProperty("id")]
        public string Id { get; set; }

        [DataMember(Order = 2), JsonProperty("source")]
        public TransferSource Source { get; set; }

        [DataMember(Order = 3), JsonProperty("destination")]
        public TransferDestination Destination { get; set; }

        [DataMember(Order = 4), JsonProperty("amount")]
        public Payouts.CircleAmount Amount { get; set; }

        [DataMember(Order = 5), JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }

        [DataMember(Order = 6), JsonProperty("status")]
        [JsonConverter(typeof(TransferStatusConverter))]
        public Transfers.TransferStatus Status { get; set; }

        [DataMember(Order = 7), JsonProperty("createDate")]
        public DateTime CreateDate { get; set; }

        [DataMember(Order = 8), JsonProperty("errorCode")]
        [JsonConverter(typeof(TransferErrorCodeConverter))]
        public Transfers.TransferErrorCode? ErrorCode { get; set; }

    }

    [DataContract]
    public class DepositDestination
    {
        [JsonProperty("id"), DataMember(Order = 1)]
        public string Id { get; set; }

        [JsonProperty("type"), DataMember(Order = 2)]
        public string Type { get; set; }
    }
}
