
namespace Grauenwolf.TravellerTools.TradeCalculator
{
    /// <summary>
    /// A bid is the desire to sell a trade good [to the players].
    /// </summary>
    public class TradeOffer
    {
        public string Type { get; set; }
        public string Subtype { get; set; }
        public int Tons { get; set; }
        public decimal BasePrice { get; set; }
        public decimal CurrentPrice { get { return BasePrice * PriceModifier; } }
        public int PurchaseDM { get; set; }


        public decimal PriceModifier { get; set; }
        public int Roll { get; internal set; }
    }
}