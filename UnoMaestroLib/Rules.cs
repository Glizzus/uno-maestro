namespace UnoMaestroLib;

/// <summary>
///     Represents the rules in which the game of Uno is played.
/// </summary>
/// <param name="PlusStackingConvention">The convention by which Plus cards are stacked.</param>
public record Rules(PlusStackingConvention PlusStackingConvention)
{
    /// <summary>
    ///     Official rules of UNO.
    /// </summary>
    public static Rules Official()
    {
        return new Rules(PlusStackingConvention.Banned);
    }

    /// <summary>
    ///     Common rules by which UNO is played.
    /// </summary>
    public static Rules Common()
    {
        return new Rules(PlusStackingConvention.Conservative);
    }
}