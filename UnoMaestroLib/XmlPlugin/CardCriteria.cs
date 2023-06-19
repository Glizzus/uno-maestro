using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public class CardCriteria : Node
{
   [XmlAttribute("inverse")]
   public string Inverse { get; set; }
  
   [XmlElement("Color")]
   public string Color { get; set; }
   
   [XmlElement("Face")]
   public string Face { get; set; }
}