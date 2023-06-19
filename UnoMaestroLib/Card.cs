namespace UnoMaestroLib;

/// <summary>
///     An UNO card.
/// </summary>
/// <param name="Color">The color of the UNO card.</param>
/// <param name="Face">The face type of the UNO card.</param>
public record Card(Color Color, Face Face)
{
    /// <summary>
    ///     Indicates whether this card is +2 or a +4
    /// </summary>
    public bool IsPlus => Face is Face.PlusTwo or Face.PlusFour;

    public uint PlusStackCount => Face switch
    {
        Face.PlusTwo => 2,
        Face.PlusFour => 4,
        _ => 0
    };

    public bool ColorMatches(Card other)
    {
        return Color == other.Color;
    }

    public bool FaceMatches(Card other)
    {
        return Face == other.Face;
    }
}