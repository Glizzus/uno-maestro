namespace UnoMaestroLib;

/// <summary>
///     Represents the UNO deck in which cards are pulled.
/// </summary>
public class Deck
{
    private readonly LinkedList<Card> _list;

    private Deck(IEnumerable<Card> list)
    {
        _list = new LinkedList<Card>(list);
    }

    /// <summary>
    ///     Indicates whether this deck has no cards.
    /// </summary>
    public bool Empty => _list.Count == 0;

    public int Count => _list.Count;

    private static IList<Card> DefaultUnoList()
    {
        var doubleFaces = new[]
        {
            Face.One, Face.Two, Face.Three, Face.Four, Face.Five, Face.Six, Face.Seven, Face.Eight,
            Face.Nine, Face.Reverse, Face.Skip, Face.PlusTwo
        };
        var list = new List<Card>(108);
        foreach (var color in new[] { Color.Blue, Color.Green, Color.Red, Color.Yellow })
        {
            list.Add(new Card(color, Face.Zero));
            for (var i = 0; i < 2; i++) list.AddRange(doubleFaces.Select(face => new Card(color, face)));
        }

        for (var i = 0; i < 4; i++)
            list.AddRange(new[] { Face.Wild, Face.PlusFour }.Select(face => new WildCard(face)));
        return list;
    }

    private static void ShuffleList(IList<Card> list)
    {
        list.Shuffle();
    }

    /// <summary>
    ///     Removes a card from the top of the deck and returns it.
    ///     This returns <c>null</c> if the deck is empty.
    /// </summary>
    /// <returns>The top card if the deck is non-empty, <c>null</c> otherwise.</returns>
    public Card? Pop()
    {
        if (_list.Count is 0) return null;
        var card = _list.Last!.Value;
        _list.RemoveLast();
        return card;
    }

    /// <summary>
    ///     A newly shuffled, standard UNO deck.
    /// </summary>
    public static Deck NewlyShuffled()
    {
        var list = DefaultUnoList();
        ShuffleList(list);
        return new Deck(list);
    }

    /// <summary>
    ///     Adds the given cards under what is currently in the deck.
    /// </summary>
    /// <param name="cards">The cards to add.</param>
    public void AddCardsUnder(IEnumerable<Card> cards)
    {
        var list = cards.ToList();
        list.Shuffle();
        list.Reverse();
        foreach (var card in list) _list.AddFirst(card);
    }
}