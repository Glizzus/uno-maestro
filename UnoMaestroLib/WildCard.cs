namespace UnoMaestroLib;

/// <summary>
///     Represents an UNO Wild card.
///     Unlike normal UNO, a Wild card can have any face.
/// </summary>
/// <param name="Face">The Face to give the Wild card.</param>
public record WildCard(Face Face) : Card(Color.Undecided, Face)
{
    /// <summary>
    ///     Creates and returns a new <c>Card</c> with the given <c>Color</c> and this <c>Face</c>.
    /// </summary>
    /// <param name="color">The <c>Color</c> to assign to this <c>WildCard</c>.</param>
    /// <returns>A newly created <c>Card</c>.</returns>
    public Card AssignColor(Color color)
    {
        return new Card(color, Face);
    }
}