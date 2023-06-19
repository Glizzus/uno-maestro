using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

[XmlRoot]
public class Strategy : Node
{
    [XmlElement]
    public Branch Branch { get; set; }
    
    [XmlElement]
    public Default Default { get; set; }
    
    [XmlAttribute("name")]
    public string Name { get; set; }

}