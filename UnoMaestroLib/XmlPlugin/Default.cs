using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public class Default : Node
{
    [XmlElement] public Action Action { get; set; } = Action.Play;
}