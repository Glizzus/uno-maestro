using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public class Filter : Node
{
    [XmlArray("CriteriaList")]
    [XmlArrayItem("CardCriteria")]
    public List<CardCriteria> CriteriaList{ get; set; }
}