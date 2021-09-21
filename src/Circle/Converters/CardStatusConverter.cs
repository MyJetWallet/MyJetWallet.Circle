using System.Collections.Generic;
using MyJetWallet.Circle.Base;
using MyJetWallet.Circle.Models.Cards;

namespace MyJetWallet.Circle.Converters
{
    public class CardStatusConverter : BaseConverter<CardStatus>
    {
        public CardStatusConverter() : this(true)
        {
        }

        public CardStatusConverter(bool quotes) : base(quotes)
        {
        }

        protected override List<KeyValuePair<CardStatus, string>> Mapping => new()
        {
            new KeyValuePair<CardStatus, string>(CardStatus.Pending, "pending"),
            new KeyValuePair<CardStatus, string>(CardStatus.Complete, "complete"),
            new KeyValuePair<CardStatus, string>(CardStatus.Failed, "failed"),
        };
    }
}