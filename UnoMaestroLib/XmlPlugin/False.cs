using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public class False : Node
{
    [XmlElement]
    public Action Action { get; set; }
   
    [XmlElement]
    public Branch Branch { get; set; }
}