using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public enum Action
{
    [XmlEnum]
    Play,
    
    [XmlEnum]
    Draw
}