using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public class Branch : Node
{
    public True True { get; set; }
    public False False { get; set; }

    [XmlAttribute("roundCondition")] private string? _roundConditionString;

    public RoundCondition? RoundCondition =>
        _roundConditionString is null ? null : new RoundCondition(_roundConditionString);

    [XmlAttribute("handCondition")] private string? _handConditionString;

    public HandCondition? HandCondition =>
        _handConditionString is null ? null : new HandCondition(_handConditionString);

}