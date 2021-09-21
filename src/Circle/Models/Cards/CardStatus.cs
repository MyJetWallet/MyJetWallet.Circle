using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Cards
{
    [DataContract]
    public enum CardStatus
    {
        Pending,
        Complete,
        Failed
    }
}