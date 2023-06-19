namespace UnoMaestroLib;

public static class GameServant
{
    public static void Rebalance(Deck deck, DiscardPile discardPile)
    {
        var cards = discardPile.ReduceToTop();
        deck.AddCardsUnder(cards);
    }
}