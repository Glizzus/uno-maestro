namespace UnoMaestroLib;

/// <summary>
///     Represents common ways Plus cards can be stacked.
/// </summary>
public enum PlusStackingConvention
{
    /// <summary>
    ///     Plus cards can not be stacked.
    ///     This is the official stance of UNO.
    /// </summary>
    Banned,

    /// <summary>
    ///     +4 can stack on any Plus card, but +2 can only stack on +2.
    /// </summary>
    Conservative,

    /// <summary>
    ///     +4 can stack on any Plus card, but +2 can stack on +4
    ///     IF the +2 is the same color as the +4.
    /// </summary>
    Liberal
}