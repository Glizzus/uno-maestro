namespace UnoMaestroLib;

/// <summary>
///     Represents the UNO discard pile.
///     The top of this pile is the card that players
///     will be stacking their cards on.
/// </summary>
public class DiscardPile
{
    private IList<Card> _list = new List<Card>();

    /// <summary>
    ///     The card on top of the discard pile.
    /// </summary>
    public Card Top => _list[^1];

    /// <summary>
    ///     Adds a card to the pile, making it the new top.
    /// </summary>
    /// <param name="card">The <c>Card</c> to add to the pile.</param>
    public void Push(Card card)
    {
        _list.Add(card);
    }

    /// <summary>
    ///     Removes every card from the discard pile EXCEPT for the top card.
    ///     This mutates the discard pile and returns the removed cards.
    ///     The returned cards are in the same order that they were pushed in.
    /// </summary>
    /// <returns>Every card from the discard pile that is not the top card.</returns>
    public IEnumerable<Card> ReduceToTop()
    {
        var top = Top;
        _list.RemoveAt(_list.Count - 1);
        var body = _list;
        _list = new List<Card> { top };
        return body;
    }
}